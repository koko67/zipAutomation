using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace AutomationTestCases7zip
{
    [XmlRoot("TestCase")]
    public class TestCase
    {
        [XmlElement("ID")]
        public int Id { get; set; }
        [XmlElement("Title")]
        public string Title { get; set; }
        [XmlElement("Description")]
        public string Description { get; set; }
        [XmlElement("ExpectedResult")]
        public string ExpectedResult { get; set; }
    }
}