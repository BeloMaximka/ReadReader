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

namespace ReadReader
{
    static class BookFileLoader
    {
        delegate Book Loader(string path);
        static Dictionary<string, Loader> loaders;
        static BookFileLoader()
        {
            loaders = new Dictionary<string, Loader>();
            loaders.Add(".epub", LoadFromEpub);
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
        static Book LoadFromEpub(string path)
        {
            EpubBook eBook = EpubReader.ReadBook(path);
            StringBuilder sb = new StringBuilder();
            sb.Append("{\\rtf1");
            for (int i = 0; i < eBook.ReadingOrder.Count; i++)
            {
                string temp = HtmlToRtfConverter.ConvertHtmlToRtf(eBook.ReadingOrder[i].Content).Substring(6);
                temp = temp.Remove(temp.Length - 1);
                sb.Append(temp);
            }
            sb.Append('}');

            Book book = new Book();
            RichTextBox textBox = new RichTextBox();
            textBox.Rtf = sb.ToString();
            book.RTF = textBox.Text;
            book.Info.Title = eBook.Title;
            book.Info.Authors = eBook.AuthorList;
            return book;
        }

        public static BindingList<BookInfo> LoadAllBooksFromDir(string path)
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