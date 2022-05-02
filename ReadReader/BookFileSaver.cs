using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace ReadReader
{
    public class BookFileSaver
    {
        string path;
        LibraryManager library;
        public BookFileSaver(string path)
        {
            this.path = path;
            library = new LibraryManager(path);
        }
        public void SaveBook(uint id, Book book)
        {
            string resultDir = "";
            string[] directories = null;
            try
            {
                directories = Directory.GetDirectories(path);
            }
            catch (DirectoryNotFoundException)
            {
                Directory.CreateDirectory(path);
            }

            foreach (var directory in directories)
            {
                uint dirId;
                Regex regex = new Regex("\\\\\\d+.");
                string number = regex.Match(directory).ToString().Trim('\\', '.');
                if (uint.TryParse(number, out dirId) && dirId == id)
                {
                    Regex nameRegex = new Regex("[\\/:*?\"<>|+.]");
                    string correctName = nameRegex.Replace(book.Info.Title, "").Trim(' ');
                    resultDir = id.ToString() + ". " + correctName;
                    if (directory != $"{path}\\{resultDir}")
                        Directory.Move(directory, $"{path}\\{resultDir}");
                    break;
                }
            }
            uint curID = ++library.ID;

            if (resultDir == "")
            {
                Regex regex = new Regex("[\\/:*?\"<>|+.]");
                string correctName = regex.Replace(book.Info.Title, "").Trim(' ');

                resultDir = curID.ToString() + ". " + correctName;
                Directory.CreateDirectory($"{path}\\{resultDir}");
            }
            var data = new { Title = book.Info.Title, Authors = book.Info.Authors, ID = curID };
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter($"{path}\\{resultDir}\\info.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
                serializer.Serialize(writer, data);

            using (StreamWriter sw = new StreamWriter($"{path}\\{resultDir}\\notes.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
                serializer.Serialize(writer, book.Notes);

            using (StreamWriter sw = new StreamWriter($"{path}\\{resultDir}\\bookmarks.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
                serializer.Serialize(writer, book.Bookmarks);

            File.WriteAllText($"{path}\\{resultDir}\\text.rtf", book.RTF);
        }
        public void SaveBookmarks(uint id, Book book)
        {
            string resultDir = "";

            foreach (var directory in Directory.GetDirectories(path))
            {
                uint dirId;
                Regex regex = new Regex("\\\\\\d+.");
                string number = regex.Match(directory).ToString().Trim('\\', '.');
                if (uint.TryParse(number, out dirId) && dirId == id)
                {
                    resultDir = directory;
                    break;
                }
            }
            if (resultDir == "")
                throw new DirectoryNotFoundException($"Cannot find book directory with id {id}");
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter($"{resultDir}\\bookmarks.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
                serializer.Serialize(writer, book.Bookmarks);
        }
        public void SaveNotes(uint id, Book book)
        {
            string resultDir = "";

            foreach (var directory in Directory.GetDirectories(path))
            {
                uint dirId;
                Regex regex = new Regex("\\\\\\d+.");
                string number = regex.Match(directory).ToString().Trim('\\', '.');
                if (uint.TryParse(number, out dirId) && dirId == id)
                {
                    resultDir = directory;
                    break;
                }
            }
            if (resultDir == "")
                throw new DirectoryNotFoundException($"Cannot find book directory with id {id}");
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter($"{resultDir}\\notes.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
                serializer.Serialize(writer, book.Notes);
        }
    }
}
