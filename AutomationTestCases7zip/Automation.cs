using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomationTestCases7zip
{
    public class Automation
    {
        private List<TestCase> testCases;
        private string[] extensions;

        public Automation()
        {
            testCases = new List<TestCase>();
            extensions = new string[] { "zip", "7z", "gzip", "bzip2", "tar" };
        }
        public void CreateFileTCs()
        {
            for (int i = 0; i < extensions.Length; i++)
            {
                TestCase tc = new TestCase();
                tc.Id = i;
                tc.Title = "Verify that a file is compressed according to " + extensions[i] + " extension";
                tc.Description = "It should be possible that 7zip compress a file according the " + extensions[i] + " extension";
                tc.ExpectedResult = "a compressed file with the " + extensions[i] + " extension";
                TCSerializer.Serialize(tc, "File" + i);
            }


        }

        public void CreateFolderTCs()
        {
            for (int i = 0; i < extensions.Length; i++)
            {
                TestCase tc = new TestCase();
                tc.Id = i;
                tc.Title = "Verify that a folder is compressed according to " + extensions[i] + " extension";
                tc.Description = "It should be possible that 7zip compress a folder according the " + extensions[i] + " extension";
                tc.ExpectedResult = "a compressed folder with the " + extensions[i] + " extension";
                TCSerializer.Serialize(tc, "Folder" + i);
            }
        }

        //private string isFile(bool file)
        //{
        //    if(file)
        //    {
        //        return "file";
        //    }
        //    return "folder";
        //}
    }

    public enum Extensions
    {
        SevenZ,
        zip,
        gzip,
        bzip2,
        tar
    };


}
