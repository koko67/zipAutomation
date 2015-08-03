using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomationTestCases7zip
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zipper z = new Zipper("D:\\c#\\7za920\\7za.exe");

            //z.compress("-t7z", "D:\\c#\\readme", "D:\\c#\\readme.txt");

            Automation aut = new Automation();
            aut.CreateFileTCs();
            aut.CreateFolderTCs();

            

            //var tc = TCSerializer.Deserialize(@".\TestCase.xml");
        }
    }
}
