using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTA_Day2
{
    public class BinaryFile
    {
        public static void WriteFile()
        {
            BinaryWriter binaryWriter = new BinaryWriter(File.Create("test.txt"));

            binaryWriter.Write(24);
            binaryWriter.Write("Luu Torng Tan");
            binaryWriter.Write("Vu Dieu Phuong Linh");

            binaryWriter.Close();
        }

        public static void ReadFile()
        {
            BinaryReader binaryReader = new BinaryReader(File.OpenRead("test.txt"));

            Console.WriteLine(binaryReader.ReadInt32());
            Console.WriteLine(binaryReader.ReadString());
            Console.WriteLine(binaryReader.ReadString());

            binaryReader.Close();
        }
    }
}
