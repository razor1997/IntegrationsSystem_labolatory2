using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationsSystem_labolatory2
{
    public static class ReadingTxtFiles
    {
        static List<String[]> dane = new List<string[]>();
        public static void ShowProductSpecification(string filePath, List<String[]> infoProducts, Dictionary<String, Int32> prodSpec)
        {
            StreamReader readerTxt = new StreamReader(filePath);
            int i = 0;

            while (readerTxt.ReadLine() != null)
            {
                i++;
                var productInfo = readerTxt.ReadLine();
                var separator = productInfo.Split(';');

                if (prodSpec.ContainsKey(separator[0]))
                {
                    prodSpec[separator[0]]++;
                }
                else
                {
                    prodSpec.Add(separator[0], 1);
                }
                for (int j = 0; j < separator.Length; j++)
                {
                    if (separator[j] == null || separator[j] == "")
                    {
                        separator[j] = "MISS";
                    }
                }

                infoProducts.Add(separator);
                dane.Add(separator);
            }
        }
    }
}
