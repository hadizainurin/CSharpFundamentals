using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp\folder1");
            // Noted: *.* (look for all in extension all), *.sln (look for all in extension sln)
            var files = Directory.GetFiles(@"d:\Projects\CSharpFundamentals", "*.sln", SearchOption.AllDirectories);
            foreach (var file in files)
                Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"d:\Projects\CSharpFundamentals", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
                Console.WriteLine(directory); // Only returning the directories

            //Directory.Exists("..."); Need to specify a path, this is for logic testing

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
