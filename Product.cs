using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IntegrationsSystem_labolatory2
{
    public class Product
    {
        public int Id { get; set; }
        public string Manufacture { get; set; }
        public string ScreenSize { get; set; }
        public string ScreenResolution { get; set; }
        public string ScreenType { get; set; }
        public string ScreenTouch { get; set; }
        public string ProcessorName { get; set; }
        public string CpuSpeed { get; set; }
        public string CpuThread { get; set; }
        public string RamSize { get; set; }
        public string SsdSize { get; set; }
        public string SsdType { get; set; }
        public string GpuName { get; set; }
        public string GpuRam { get; set; }
        public string OsName { get; set; }
        public string DiscReader { get; set; }
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
