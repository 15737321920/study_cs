using com.sun.tools.javac.util;
using FSharp.Compiler.SourceCodeServices;
using javax.xml.bind.annotation;
using System;
using System.Collections.Generic;
using System.Xml;

namespace xml
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument document = new XmlDocument();
            document.Load(@"D:\learning\tmp_file\tmp.xml");
            XmlNode xn = document.SelectSingleNode("a");
            XmlNodeList xnl = xn.ChildNodes;
            foreach (XmlNode node in xnl)
            {
               
                System.Xml.XmlElement xe = (System.Xml.XmlElement)node;
                if (xe.Name == "TagName3") 
                {
                    xe.GetAttribute("TagName3").ToString();
                    Console.WriteLine(xe.InnerText);                   
                }                
            }           
            Console.ReadKey();


        }
    }
}
