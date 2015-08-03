using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace AutomationTestCases7zip
{
    [XmlRoot("Report")]
    class Report : TestCase
    {
        [XmlElement("Status")]
        public string status { get; set; }

        
        public static void serialize(Report test)
        {
            var ser = new XmlSerializer(typeof(Report));
            using (var writer = XmlWriter.Create(@"..\..\results\reports\TestCase" + test.Id + ".xml"))
            {
                ser.Serialize(writer, test);
            }
        }
    }
}
