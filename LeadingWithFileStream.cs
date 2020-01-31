using System;
using System.IO;
using System.Text;

namespace streams
{
    public partial class Program 
    {
        private static void LeadingWithFileStream()
        {
            var path = "persons.txt";
            using var file = new FileStream(path, FileMode.Open);

            var buffer = new byte[10];
            var readSize = -1;

            while (readSize != 0)
            {
                readSize = file.Read(buffer, 0, 10);
                WriteBuffer(buffer, readSize);
            }

            Console.ReadLine();
        }

        private static void WriteBuffer(byte[] buffer, int size)
        {
            var utf8 = Encoding.UTF8;
            var text = utf8.GetString(buffer, 0, size);
            Console.Write(text);
        }
    }
}