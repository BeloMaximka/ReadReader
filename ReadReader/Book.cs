using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace ReadReader
{
    public class Book
    {
        public BookInfo Info { get; set; } = new BookInfo();
        public string RTF { get; set; }
        public BindingList<Bookmark> Bookmarks { get; set; }
        public BindingList<Note> Notes { get; set; }
        
        public Book()
        {
            Bookmarks = new BindingList<Bookmark>();
            Notes = new BindingList<Note>();
            Info.ID = 0;
        }
    }
}
