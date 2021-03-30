using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IntegrationsSystem_labolatory2
{
    [Serializable]
    public class Product
    {
        [XmlAttribute]
        public int Id { get; set; }
        [XmlElement("Manufacturer")]
        public string Manufacturer { get; set; }
        [XmlElement("screen touch")]
        public Screen screen { get; set; }
        [XmlElement("processor")]
        public Processor processor { get; set; }
    }

    public class Screen
    {
        [XmlAttribute]
        public string ScreenTouch { get; set; }
        [XmlElement("size")]
        public string Size { get; set; }
        [XmlElement("resolution")]
        public string Resolution { get; set; }
        [XmlElement("type")]
        public string Type { get; set; }
    }

    public class Processor
    {
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("physical_cores")]
        public int Cores { get; set; }
        [XmlElement("clock_speed")]
        public int MyProperty { get; set; }
    }





}
