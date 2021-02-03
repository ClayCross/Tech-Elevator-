﻿using Lecture.Aids;
using System;
using System.IO;

namespace FileAndDirectory
{
    class Program
    {
        public static object Declaration { get; private set; }

        static void Main(string[] args)
        {

            // Files and Directories
            FileAndDirectories fad = new FileAndDirectories();
            fad.UsingTheDirectoryClass();
            fad.UsingTheFileClass();

            // File Paths
            //FilePaths fp = new FilePaths();
            //fp.UsingPathToCombineTwoFilePaths();
            //fp.UsingPathForTemporaryFolders();

            // Reading Text Files
            //ReadingTextFiles rtf = new ReadingTextFiles();
            //rtf.ReadACharacterFile();

            // Reading CSV
            //ReadingCSVFiles rcf = new ReadingCSVFiles();
            //rcf.ReadFile();

            // Summing up numbers
            //SummingUpNumbers sun = new SummingUpNumbers();
            //sun.ReadFile();

            // Navigator
            //Navigator nav = new Navigator();
            //nav.Run();

            // File 
            //FileAndDirDemo fdDemo = new FileAndDirDemo();
            //fdDemo.DoFileAndDirDemo();
            //Console.ReadLine();

            // Path
            //PathDemo pd = new PathDemo();
            //pd.DoPathDemo();



            // Read and display an entire text file
            string path = @"..\..\..\Declaration.txt";
            using (StreamReader rdr = new StreamReader(path))
            {
                string body = rdr.ReadToEnd();
                Console.WriteLine(body);
            }



            //Read and disply a file line-by-line, with line numbers
            path = @"..\..\..\Files/Hamlet.txt";
            using (StreamReader rdr = new StreamReader(path))
            {
                int linenumber = 1;
                while (!rdr.EndOfStream)
                {
                    string line = rdr.ReadLine();
                    Console.WriteLine($"{linenumber} {line}");
                    linenumber++;
                }
            }



                
        }

    }
}