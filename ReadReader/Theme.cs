using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ReadReader
{
    public class Theme
    {
        public Color BackgroundColor { get; set; }
        public Color BackColor { get; set; }
        public Color ForeColor { get; set; }
        public Theme(Color backgroundColor, Color backColor, Color foreColor)
        {
            BackgroundColor = backgroundColor;
            BackColor = backColor;
            ForeColor = foreColor;
        }
    }
}