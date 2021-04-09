﻿/*
 * This file is shows demo of how can we call python 
 * method from a C#.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace CSBasic
{
    /// <summary>
    /// This is a Scribble class used rouch work
    /// </summary>
    public class CallingPy
    {
        public void CallPy()
        {
            // full path of python interpreter 
            string python = @"C:\Users\jaypras\AppData\Local\Programs\Python\Python38-32\python.exe";

            // python app to call 
            string myPythonApp = "Demo.py";

            // dummy parameters to send Python script 
            int x = 2;
            int y = 5;

            // Create new process start info 
            ProcessStartInfo myProcessStartInfo = new ProcessStartInfo(python);

            // make sure we can read the output from stdout 
            myProcessStartInfo.UseShellExecute = false;
            myProcessStartInfo.RedirectStandardOutput = true;

            // start python app with 3 arguments  
            // 1st arguments is pointer to itself,  
            // 2nd and 3rd are actual arguments we want to send 
            myProcessStartInfo.Arguments = myPythonApp + " sum "+ x + " " + y;

            Process myProcess = new Process();
            // assign start information to the process 
            myProcess.StartInfo = myProcessStartInfo;

            Console.WriteLine("Calling Python script with arguments {0} and {1}", x, y);
            // start the process 
            myProcess.Start();

            // Read the standard output of the app we called.  
            // in order to avoid deadlock we will read output first 
            // and then wait for process terminate: 
            StreamReader myStreamReader = myProcess.StandardOutput;
            string myString = myStreamReader.ReadLine();

            /*if you need to read multiple lines, you might use: 
                string myString = myStreamReader.ReadToEnd() */

            // wait exit signal from the app we called and then close it. 
            myProcess.WaitForExit();
            myProcess.Close();

            // write the output we got from python app 
            Console.WriteLine("Value received from script: " + myString);

        }


    }
}
