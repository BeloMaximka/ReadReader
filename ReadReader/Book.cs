using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace ReadReader
{
    internal class Book
    {
        public string Title { get; set; }
        public string RTF { get; set; }
        public BindingList<Bookmark> Bookmarks { get; set; }
        public BindingList<Note> Notes { get; set; }
        public List<string> Authors { get; set; }
        public Book()
        {
            Bookmarks=new BindingList<Bookmark>();
            Notes=new BindingList<Note>();
        }
    }
}
