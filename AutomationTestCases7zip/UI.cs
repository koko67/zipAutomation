using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AutomationTestCases7zip
{
    class UI
    {
        public void DisplayMenu ()
        {
            Boolean exit = false;
            Automation executer = new Automation();
            do
            {
                centerText("Automation TC 7zip");
                centerText("=========================");
                Console.WriteLine("Type an option:");
                Console.WriteLine("1.Create Test Case ");
                Console.WriteLine("2.Executed Test Case");
                Console.WriteLine("3.Change 7zip path");
                Console.WriteLine("4.Exit");
                var initOption = Console.ReadLine();
                switch(initOption)
                {
                    case "1":
                        Console.WriteLine("Type an option:");
                        Console.WriteLine("1. File");
                        Console.WriteLine("2. Folder");
                        var dataOption = Console.ReadLine();
                        switch (dataOption) 
                        {
                            case "1":
                                Console.WriteLine("Put the entry data");
                                Console.WriteLine("Type the path File");
                                var pathFile = Console.ReadLine();
                                extensionMenu();
                                //executer.CreateFileTCs;
                                if (!exit)
                                {
                                    TestCase tc = new TestCase();
                                    //executer.CreateFileTCs;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    displayErrorMessage("ERROR : Invalid data was entered");
                                    Console.ResetColor();
                                }

                                break;

                            case "2":
                                Console.WriteLine("Put the entry data");
                                Console.WriteLine("Type the path File");
                                var pathFolder = Console.ReadLine();
                                break;

                        }
                        break;
                    case "3":
                        Console.WriteLine("Type the path File");
                        var path7zip = Console.ReadLine();
                        break;
                    case "4":                    
                        exit = true;
                        break;
                }

            } while (!exit);

        }
        public void extensionMenu()
        {
            Console.WriteLine("Select a extension to compress");
            Console.WriteLine("1. zip ");
            Console.WriteLine("2. 7z ");
            Console.WriteLine("3. gzip ");
            Console.WriteLine("4. bzip2 ");
            Console.WriteLine("5. tar ");
            var ext = Console.ReadLine();
            
        }

        public void displayErrorMessage(String message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + message + "\n");
            Console.ResetColor();
        }

        
        public static void centerText(String text)
        {
            Console.Write(new string(' ', (Console.WindowWidth - text.Length) / 2));
            Console.WriteLine(text);
        }


    }
}
