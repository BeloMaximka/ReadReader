using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using VersOne.Epub;
using MarkupConverter;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.Xml;

namespace ReadReader
{
    class BookFileLoader
    {
        string path;
        delegate Book Loader(string path);
        static Dictionary<string, Loader> loaders;
        public BookFileLoader(string path)
        {
            this.path = path;
            loaders = new Dictionary<string, Loader>();
            loaders.Add(".epub", LoadFromEpub);
            loaders.Add(".fb2", LoadFromFb2);
        }
        public static Book LoadFromFile(string path)
        {
            Book book;
            FileInfo info = new FileInfo(path);
            if (loaders.ContainsKey(info.Extension))
                book = loaders[info.Extension].Invoke(path);
            else
                throw new FileFormatException("This file format is not supported.");
            return book;
        }
        static string GetChildNodesText(XmlNodeList nodes)
        {
            string result = "";
            foreach (XmlNode node in nodes)
            {
                result += "{\\f2" + node.InnerText + GetChildNodesText(node.ChildNodes) + "\\par}\n";
            }
                
            return result;
        }
        static Book LoadFromEpub(string path)
        {
            EpubBook eBook = EpubReader.ReadBook(path);
            StringBuilder sb = new StringBuilder();
            sb.Append(@"{\rtf1\fi567\sb50{\fonttbl{\f2\fs24\fcharset0 Times New Roman;}}");
            for (int i = 1; i < eBook.ReadingOrder.Count; i++)
            {
                string temp = HtmlToRtfConverter.ConvertHtmlToRtf(eBook.ReadingOrder[i].Content).Substring(6);
                temp = temp.Remove(temp.Length - 1);
                sb.Append(temp);
            }
            sb.Append('}');
            string rtf = sb.ToString();
            Regex regex = new Regex(@"\\fi\d+");
            string fi = regex.Match(rtf).ToString();
            rtf = regex.Replace(rtf, "\\fi567");
            regex = new Regex(@"\\sb\d+");
            rtf = regex.Replace(rtf, "\\sb50");

            Book book = new Book();
            book.RTF = rtf;
            book.Info.Title = eBook.Title;
            book.Info.Authors = eBook.AuthorList;
            return book;
        }
        static Book LoadFromFb2(string path)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path);
            StringBuilder sb = new StringBuilder();
            sb.Append(@"{\rtf1\fi567\sb50{\fonttbl{\f2\fs24\fcharset0 Times New Roman;}}");
            foreach (XmlNode node in xDoc.DocumentElement.ChildNodes[1])
            {
                if (node.Name == "section")
                {
                    foreach (XmlNode sectionNode in node.ChildNodes)
                    {

                        string temp = null;
                        if (sectionNode.Name == "title")
                            foreach (XmlNode titleNode in sectionNode.ChildNodes)
                            {
                                sb.Append("{\\f2\\fs36");
                                if (titleNode.FirstChild != null)
                                {
                                    temp = titleNode.FirstChild.InnerText;
                                    foreach (short code in temp)
                                        sb.Append($"\\u{code}?");
                                }
                                sb.Append("\\par}\n");
                            }
                        else
                        {
                            sb.Append("{\\f2");
                            if (sectionNode.FirstChild != null)
                            {
                                temp = sectionNode.FirstChild.InnerText;
                                foreach (short code in temp)
                                    sb.Append($"\\u{code}?");
                            }
                            sb.Append("\\par}\n");
                        }
                    }
                }
            }
            sb.Append('}');

            Book book = new Book();
            RichTextBox textBox = new RichTextBox();
            textBox.Text = sb.ToString();
            book.RTF = sb.ToString();
            XmlNode title = xDoc.DocumentElement.SelectSingleNode("//*[local-name()='title-info']");
            book.Info.Title = title.SelectSingleNode("//*[local-name()='book-title']").InnerText;

            List<string> authors = new List<string>();
            foreach (XmlNode authorNode in title.SelectNodes("//*[local-name()='author']"))
            {
                string authorName = "";
                foreach (XmlNode namePart in authorNode.ChildNodes)
                    authorName += namePart.InnerText + " ";
                authorName = authorName.Substring(0, authorName.Length - 1);
                authors.Add(authorName);
            }
            book.Info.Authors = authors;

            return book;
        }
        public Book LoadBookFromDir(uint id)
        {
            foreach (var directory in Directory.GetDirectories(path))
            {
                uint dirId;
                Regex regex = new Regex("\\\\\\d+.");
                string number = regex.Match(directory).ToString().Trim('\\', '.');
                if (uint.TryParse(number, out dirId) && dirId == id)
                {
                    Book book = new Book();
                    book.RTF = File.ReadAllText(directory + "\\text.rtf");

                    JsonSerializer serializer = new JsonSerializer();
                    using (StreamReader sr = new StreamReader(directory + "\\info.json"))
                    using (JsonReader reader = new JsonTextReader(sr))
                    {
                        dynamic data = serializer.Deserialize(reader);
                        book.Info.Title = data.Title;
                        var list = ((Newtonsoft.Json.Linq.JArray)data.Authors).ToList();
                        book.Info.Authors = new List<string>();
                        foreach (var item in list)
                            book.Info.Authors.Add(item.ToString());
                        book.Info.ID = (uint)data.ID;
                    }

                    book.Bookmarks = JsonConvert.DeserializeObject<BindingList<Bookmark>>(File.ReadAllText(directory + "\\bookmarks.json"));
                    if (book.Bookmarks == null)
                        book.Bookmarks = new BindingList<Bookmark>();

                    book.Notes = JsonConvert.DeserializeObject<BindingList<Note>>(File.ReadAllText(directory + "\\notes.json"));
                    if (book.Notes == null)
                        book.Notes = new BindingList<Note>();
                    return book;
                }
            }
            return null;
        }
        public BindingList<BookInfo> LoadAllBooksFromDir()
        {
            BindingList<BookInfo> result = new BindingList<BookInfo>();
            foreach (var directory in Directory.GetDirectories(path))
            {
                BookInfo info = new BookInfo();
                JsonSerializer serializer = new JsonSerializer();
                using (StreamReader sr = new StreamReader(directory + "\\" + "info.json"))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    dynamic data = serializer.Deserialize(reader);
                    info.Title = data.Title;
                    var list = ((Newtonsoft.Json.Linq.JArray)data.Authors).ToList();
                    info.Authors = new List<string>();
                    foreach (var item in list)
                        info.Authors.Add(item.ToString());
                    info.ID = (uint)data.ID;
                }

                result.Add(info);
            }
            return result;
        }
    }
}