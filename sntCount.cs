using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SntCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the folder you want to count their:");
            string FolderName = System.Console.ReadLine();
            List<string> FileNameList = new List<string>();
            getFileName(FileNameList, FolderName);
        }
        public static void getFileName(List<string> FileNameList, string FolderName)
        {
            DirectoryInfo root = new DirectoryInfo(FolderName);
            foreach (FileInfo f in root.GetFiles())
            {
                string FileName = f.FullName;
                FileNameList.Add(FileName);
                GetSntCount(FileName);
            }
        }
        public static void GetSntCount(String FileName)
        {
            //snt count:0
            int i = 0;
            //word count:0
            int w = 0;
            //char count:0
            int c = 0;
            foreach (string str in File.ReadAllLines(FileName, Encoding.Default))
            {
                string[] LinieWordList = str.Split(" ");
                int wordCount_line = LinieWordList.Count();
                foreach(string eachWrod in LinieWordList)
                {
                    int eachWrodLength = eachWrod.Count();
                    c += eachWrodLength;
                }                
                i += 1;
                w += wordCount_line;  
            }

            Console.WriteLine(FileName + " snt count:" + i);
            Console.WriteLine(FileName + " word count:" + w);
            Console.WriteLine(FileName + " char count:" + c);
        }

    }
}
