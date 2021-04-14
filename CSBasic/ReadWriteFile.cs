/*
 * This file demonstrates the use of iDisposable.
 * The concept simply tells how C# handles if the file or stream is not closed before the program exits.
 * This file demonstrates the use of below statement
 * - using
 */
using System;
using System.Collections.Generic;
using System.IO;

namespace CSBasic
{
    /// <summary>
    /// This is a ReadWriteFile class used for the demo.
    /// This is xml style documention and a good practice to use.
    /// </summary>
    class ReadWriteFile
    {
        public ReadWriteFile(string fileName)
        {
            FileName = fileName;
        }
        public string FileName;
        public void WriteToFile(List<String> writeString)
        {
            // This is how using statement works.
            // it ensures that the file handle is closed after being used.
            using(var writer = File.AppendText(FileName))
            {
                foreach(string word in writeString)
                writer.WriteLine(word);
            }            
        }
    }
}
