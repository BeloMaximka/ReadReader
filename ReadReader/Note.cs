using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadReader
{
    internal class Note
    {
        public int StartIndex { get; set; }
        public int EndIndex { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public Note(int startIndex, int endIndex, string name, string text)
        {
            StartIndex = startIndex;
            EndIndex = endIndex;
            Name = name;
            Text = text;
        }
    }
}