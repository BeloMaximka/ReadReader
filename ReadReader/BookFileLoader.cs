using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using VersOne.Epub;
using MarkupConverter;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            book.Title = eBook.Title;
            book.Authors = eBook.AuthorList;
            return book;
        }
    }
}