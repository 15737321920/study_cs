using System;
using System.Diagnostics;
using System.IO;

namespace day3_letast
{
    class Program
    {
        static void Main(string[] args)
        {
            //can call an external .exe.
            Console.WriteLine("Please call you HelloWorld.exe path:");
            string ExeHWFilePath = System.Console.ReadLine();
            Process p1 = new Process();
            p1.StartInfo.FileName = ExeHWFilePath;
            p1.Start();
            p1.WaitForExit();
            p1.Close();

            //can call an external .exe with argument
            Console.WriteLine("Please call you Sum.exe path:");
            string ExeSumFilePath = System.Console.ReadLine();
            Process p2 = new Process();
            p2.StartInfo.FileName = ExeSumFilePath;
            p2.StartInfo.Arguments =args[1]+ args[2] ;
            p2.Start();
            p2.WaitForExit();
            p2.Close();

            //can call an external .exe in certain working director.
            Process p3 = new Process();           
            p3.StartInfo.Arguments = args[1];
            String FolferName = args[1].ToString();
            string[] filePaths = Directory.GetFiles(FolferName, "SntCount.exe", SearchOption.AllDirectories);
            String EXEFilename = filePaths.ToString();
            p3.StartInfo.FileName = EXEFilename;
            p3.Start();
            p3.WaitForExit();
            p3.Close();
        }
    }
}
