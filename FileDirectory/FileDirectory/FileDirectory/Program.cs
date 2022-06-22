using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", "d:\tenp\myfile.jpg, true"); // We want to get rid of \\ noise
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }

            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists) // Property whether file exist or not
            {

            }
            //fileInfo.Read; // OpenRead is a file string (Its a bit complex)
            // @ Allow us to use \ instead of \\
        }
    }
}
