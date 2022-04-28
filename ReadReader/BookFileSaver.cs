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
    static class BookFileSaver
    {
        public static void SaveBook(string path, uint id, Book book)
        {
            string resultDir = "";
            string[] directories;
            try
            {
                directories = Directory.GetDirectories(path);
            }
            catch (DirectoryNotFoundException)
            {
                Directory.CreateDirectory(path);
            }

            foreach (var directory in Directory.GetDirectories(path))
            {
                uint dirId;
                Regex regex = new Regex("\\\\\\d.");
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
            if (resultDir == "")
            {
                uint curID;
                if (File.Exists(path + '\\' + "data.bin"))
                {
                    curID = BitConverter.ToUInt32(File.ReadAllBytes(path + '\\' + "data.bin"), 0);
                    File.WriteAllBytes(path + '\\' + "data.bin", BitConverter.GetBytes(curID + 1));
                }
                else
                {
                    curID = 1;
                    File.WriteAllBytes(path + '\\' + "data.bin", BitConverter.GetBytes(2u));
                }

                Regex regex = new Regex("[\\/:*?\"<>|+.]");
                string correctName = regex.Replace(book.Info.Title, "").Trim(' ');

                resultDir = curID.ToString() + ". " + correctName;
                Directory.CreateDirectory($"{path}\\{resultDir}");
            }
            var data = new { Title = book.Info.Title, Authors = book.Info.Authors, ID = id};
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
    }
}
