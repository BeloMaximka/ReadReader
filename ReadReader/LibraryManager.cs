using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadReader
{
    class LibraryManager
    {
        string path;
        public LibraryManager(string path)
        {
            this.path = path;
        }
        public uint ID
        {
            get
            {
                uint id;
                if (File.Exists(path + '\\' + "data.bin"))
                    return BitConverter.ToUInt32(File.ReadAllBytes(path + "\\data.bin"), 0);
                else
                    return 1u;
            }
            set
            {
                File.WriteAllBytes(path + "\\data.bin", BitConverter.GetBytes(value));
            }
        }
        public uint GetId(string path, bool inc = false)
        {
            uint id;
            if (File.Exists(path + '\\' + "data.bin"))
            {
                id = BitConverter.ToUInt32(File.ReadAllBytes(path + '\\' + "data.bin"), 0) - (inc ? 0 : 1u);
                File.WriteAllBytes(path + '\\' + "data.bin", BitConverter.GetBytes(id + (inc ? 1u : 0)));
            }
            else
            {
                id = 1;
                File.WriteAllBytes(path + '\\' + "data.bin", BitConverter.GetBytes(2u));
            }
            return id;
        }
    }
}
