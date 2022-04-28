using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadReader
{
    internal class Bookmark
    {
        public int Position { get; set; }
        public string Name { get; set; }
        public Bookmark(int position, string name)
        {
            Position = position;
            Name = name;
        }
    }
}
