using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace ReadReader
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Theme darkTheme = new Theme(Color.FromArgb(31, 31, 31), Color.FromArgb(61, 61, 61), Color.White);
            Theme lightTheme = new Theme(Color.White, Color.White, Color.Black);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LibraryForm(".\\library", lightTheme, darkTheme));
        }
    }
}
