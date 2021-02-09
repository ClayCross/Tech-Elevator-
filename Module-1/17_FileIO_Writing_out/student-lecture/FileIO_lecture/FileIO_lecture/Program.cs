﻿using System;
using System.Collections.Generic;
using System.IO;

namespace FileIO_lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a file in the local folder to write result to
<<<<<<< HEAD

            // using here...
            string outPath = "GitFolders.txt";

            using (StreamWriter writer = new StreamWriter(outPath, false )) // File will be overridden each time this program is run.
=======
            string outputPath = "GitFolders.txt";
            
            using (StreamWriter writer = new StreamWriter(outputPath,false))
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4
            {
                // Get a list of folders from a directory on disk
                string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                path = Path.Combine(path, "GIT");
                Console.WriteLine($"Getting folders in {path}");
                DirectoryInfo dir1 = new DirectoryInfo(path);

                // First, write the top-level folder
<<<<<<< HEAD
                writer.WriteLine($"Theses are the folders under {dir1.FullName}:");

                // Find all the folders in this folder
                Ienuumerable<DirectoryInfo> folders = (Ienuumerable<DirectoryInfo>)dir1.EnumerateDirectories();
                foreach(DirectoryInfo folder in folders)
                {
                    writer.WriteLine($"\t{folder.Name}");
                }

=======
                writer.WriteLine($"These are the folders under {dir1.FullName}:");
                
                // Find all the folders in this folder
                IEnumerable<DirectoryInfo> folders = dir1.EnumerateDirectories();
                foreach (DirectoryInfo folder in folders) {
                    writer.WriteLine($"\t{folder.Name}");
                    foreach (DirectoryInfo subFolder in folder.EnumerateDirectories()) {
                        writer.WriteLine($"\t\t{subFolder.Name}");
                    }
                }
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4
            }

            // The file is now closed.  We can open it again for append to add more lines
            using (StreamWriter sw = new StreamWriter(outputPath,true))
            {
                for (int i = 1; i <= 100; i++)
                {
                    sw.Write($"{i:000} ");
                    if (i % 10 == 0)
                    {
                        sw.WriteLine();
                    }
                }
            }

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
