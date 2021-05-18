using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using IntegrationsSystem_labolatory2;

namespace IntegrationsSystem_labolatory2
{
    public partial class Form1 : Form
    {
        static List<String[]> dane = new List<string[]>();
        static Dictionary<String, Int32> prodSpec = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bImportFromTxt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openTxt = new OpenFileDialog();
            openTxt.ShowDialog();
            
            string fileStream = openTxt.FileName;

            ReadingTxtFiles.ShowProductSpecification(fileStream, dane, prodSpec);

            foreach (var item in dane)
            {
                infoProductTable.Rows.Add(item);
            }
        }

        private void tableInfoProducts_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bExportToTxt_Click(object sender, EventArgs e)
        {
            using (TextWriter tw = new StreamWriter("example.txt"))
            {
                for (int i = 0; i < infoProductTable.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < infoProductTable.Columns.Count; j++)
                    {
                        tw.Write($"{infoProductTable.Rows[i].Cells[j].Value.ToString()}");

                        if (j != infoProductTable.Columns.Count - 1)
                        {
                            tw.Write(",");
                        }
                    }
                    tw.WriteLine();
                }             
            }
            
            MessageBox.Show("Pomyślnie wyeksportowano do pliku txt pod nazwą example.txt");
        }

        private void infoProductTable_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            if (columnIndex == 6 || columnIndex == 7)
            {
                string value = e.FormattedValue.ToString();
                if (!value.All(char.IsDigit))
                {
                    infoProductTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                    MessageBox.Show(this, "Niepoprawny typ liczbowy", "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    infoProductTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                }
            }
            if (columnIndex == 5 || columnIndex == 13 || columnIndex == 11 || columnIndex == 2)
            {
                string value = e.FormattedValue.ToString();
                if (!value.All(char.IsLetterOrDigit))
                {
                    infoProductTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                    MessageBox.Show(this, "Niepoprawny format. Te pole może się składać z liter i liczb", "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    infoProductTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                }
            }
            if (columnIndex == 8 || columnIndex == 9 || columnIndex == 12)
            {
                string pattern = @"^[0-9]{2}[A-Z]{2}$";

                string value = e.FormattedValue.ToString();
                if (!Regex.IsMatch(value, pattern))
                {
                    infoProductTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                    MessageBox.Show(this, "Dane muszą być w formacie Rozmiar + GB", "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    infoProductTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                }
            }
            if (columnIndex == 0 || columnIndex == 4 || columnIndex == 11 && columnIndex == 14 || columnIndex == 3)
            {
                string value = e.FormattedValue.ToString();
                if (!value.All(char.IsLetter))
                {
                    infoProductTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                    MessageBox.Show(this, "Niepoprawny typ", "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    infoProductTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                }
            }
            if (columnIndex == 10)
            {
                string pattern = @"^[A-Z]{3}$";

                string value = e.FormattedValue.ToString();
                if (!Regex.IsMatch(value, pattern))
                {
                    infoProductTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                    MessageBox.Show(this, "Dane mogą zawierać 3 duże litery", "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    infoProductTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                }
            }
        }

        private void bExportToXML_Click(object sender, EventArgs e)
        {
            //int IdProduct = 0;
            //List<Product> products = new List<Product>();
            //for (int i = 0; i < infoProductTable.Rows.Count - 1; i++)
            //{
            //    Product product = new Product();

            //    Screen screenProduct = new Screen();

            //    product.Id = IdProduct++;
            //    product.Manufacturer = infoProductTable.Rows[i].Cells[0].Value.ToString();
            //    screenProduct.Size = infoProductTable.Rows[i].Cells[1].Value.ToString();
            //    screenProduct.Resolution = infoProductTable.Rows[i].Cells[2].Value.ToString();
            //    screenProduct.Type = infoProductTable.Rows[i].Cells[3].Value.ToString();
            //    screenProduct.ScreenTouch = infoProductTable.Rows[i].Cells[4].Value.ToString();

            //    product.screen = screenProduct;
            //    products.Add(product);

            //    products.Add(product);
            //}
            //ReaderXML.CreatingXMLFile();   
        }

        private void bImportToDatabase_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < infoProductTable.Rows.Count - 1; i++)
            {
                Product product = new Product();
                product.Id = i;
                product.Manufacture = infoProductTable.Rows[i].Cells[0].Value.ToString();
                product.ScreenSize = infoProductTable.Rows[i].Cells[1].Value.ToString();
                product.ScreenResolution = infoProductTable.Rows[i].Cells[2].Value.ToString();
                product.ScreenType = infoProductTable.Rows[i].Cells[3].Value.ToString();
                product.ScreenTouch = infoProductTable.Rows[i].Cells[4].Value.ToString();
                product.ProcessorName = infoProductTable.Rows[i].Cells[5].Value.ToString();
                product.CpuSpeed = infoProductTable.Rows[i].Cells[6].Value.ToString();
                product.CpuThread = infoProductTable.Rows[i].Cells[7].Value.ToString();
                product.RamSize = infoProductTable.Rows[i].Cells[8].Value.ToString();
                product.SsdSize = infoProductTable.Rows[i].Cells[9].Value.ToString();
                product.SsdType = infoProductTable.Rows[i].Cells[10].Value.ToString();
                product.GpuName = infoProductTable.Rows[i].Cells[11].Value.ToString();
                product.GpuRam = infoProductTable.Rows[i].Cells[12].Value.ToString();
                product.OsName = infoProductTable.Rows[i].Cells[13].Value.ToString();
                product.DiscReader = infoProductTable.Rows[i].Cells[14].Value.ToString();

                if (Helper.AddRecordToDatabse(product))
                {
                    MessageBox.Show("Record " + i.ToString() + " Added");
                }
                else
                {
                    MessageBox.Show("Nope");
                }
            }
            
        }

        private void bExportToDatabase_Click(object sender, EventArgs e)
        {
            Helper.GetDataFromDatabase(infoProductTable);
        }

        private void bCountProducentItems_Click(object sender, EventArgs e)
        {
            iQuantityItems.Text = Helper.ShowCountProducentItems(cBProducentName.SelectedItem.ToString()).ToString();
        }

        private void bShowItemsWithMatrix_Click(object sender, EventArgs e)
        {
            Helper.ShowItemsMatrix(infoProductTable, cBMatrixType.SelectedItem.ToString());          
        }

        private void bFiltrByScreenResolution_Click(object sender, EventArgs e)
        {
            iQuantityItemsMatrix.Text = Helper.ScreenResolutionCount(cBScreenResolutionType.SelectedItem.ToString()).ToString();
        }

        private void cBMatrixType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
