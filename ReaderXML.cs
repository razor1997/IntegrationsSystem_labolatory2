using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using IntegrationsSystem_labolatory2;

namespace IntegrationsSystem_labolatory2
{
    public static class ReaderXML
    {
        public static void CreatingXMLFile()
        {
            XElement root = new XElement("Laptops","");
            XDocument doc = new XDocument(root);
            Product product = new Product();
            product.Manufacturer = "ss";
            doc.Save(product.Manufacturer);
        }


    }
}
