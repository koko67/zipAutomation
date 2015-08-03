using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace AutomationTestCases7zip
{
    class Zipper
    {
        public string FormatCompress { get; set; }
        public string SourceName { get; set; }
        public string TargetName { get; set; }

        public string MethodCompress { get; set; }

        private ProcessStartInfo process;

        public Zipper(string path7zip){
            try
            {
                if (File.Exists(path7zip))
                {
                    process = new ProcessStartInfo();
                    process.FileName = @path7zip;
                }
                else {
                    Console.WriteLine("The path of 7zip program isn't correct");
                    Console.ReadLine();
                }
            }
            catch(Exception error)
            {
                Console.WriteLine(error);
            }            
        }

        //Funtion Compress
            //Type of compress, destiny, source, method of compress
        public bool compress(string fc, string tn, string sn){
            bool res = false;

            try{                
                process.Arguments = "a " + fc + " \"" + tn + "\" \"" + sn + "\" -mx=9";
                //process.Arguments = "a -tgzip \"" + tn + "\" \"" + sn + "\" -mx=9";

                process.WindowStyle = ProcessWindowStyle.Hidden;

                Process x = Process.Start(process);
                x.WaitForExit();
            }
            catch{

            }

            return res;
        }
    }
}
