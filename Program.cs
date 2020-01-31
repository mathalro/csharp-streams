using System;
using System.IO;
using System.Text;

namespace streams
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // LeadingWithFileStream();

            var path = "persons.txt";

            using var file = new FileStream(path, FileMode.Open);
            var reader = new StreamReader(file);
        }
    }
}
