using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;


namespace AutomationTestCases7zip
{
    public class TCSerializer
    {
        public static void Serialize(TestCase testCase, string type)
        {
            var serializer = new XmlSerializer(typeof(TestCase));

            using (var writer = XmlWriter.Create(@".\TCs\TestCase" + type + ".xml"))
            {
                serializer.Serialize(writer, testCase);
            }
        }

        public static TestCase Deserialize(string pathFile)
        {
            var serializer = new XmlSerializer(typeof(TestCase));

            using (var reader = XmlReader.Create(pathFile))
            {
                return serializer.Deserialize(reader) as TestCase;
            }
        }
    }
}
