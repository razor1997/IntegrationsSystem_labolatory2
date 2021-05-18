namespace IntegrationsSystem_labolatory2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.bImportFromTxt = new System.Windows.Forms.Button();
            this.bExportToTxt = new System.Windows.Forms.Button();
            this.openFileTxt = new System.Windows.Forms.OpenFileDialog();
            this.infoProductTable = new System.Windows.Forms.DataGridView();
            this.Produc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScreenResolution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeScreen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TouchScreen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPUThread = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpeedCPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAMSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StorageSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StorageType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPUName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAMGpu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpticalDrive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bImportToXML = new System.Windows.Forms.Button();
            this.bExportToXML = new System.Windows.Forms.Button();
            this.bImportToDatabase = new System.Windows.Forms.Button();
            this.bExportToDatabase = new System.Windows.Forms.Button();
            this.cBProducentName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bCountProducentItems = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.iQuantityItems = new System.Windows.Forms.Label();
            this.cBScreenResolutionType = new System.Windows.Forms.ComboBox();
            this.bFiltrByMatrix = new System.Windows.Forms.Button();
            this.iMatrixInfo = new System.Windows.Forms.Label();
            this.iQuantityItemsMatrix = new System.Windows.Forms.Label();
            this.bCountByScreenResolution = new System.Windows.Forms.Button();
            this.cBMatrixType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.infoProductTable)).BeginInit();
            this.SuspendLayout();
            // 
            // bImportFromTxt
            // 
            this.bImportFromTxt.Location = new System.Drawing.Point(12, 12);
            this.bImportFromTxt.Name = "bImportFromTxt";
            this.bImportFromTxt.Size = new System.Drawing.Size(106, 32);
            this.bImportFromTxt.TabIndex = 0;
            this.bImportFromTxt.Text = "Import From Txt";
            this.bImportFromTxt.UseVisualStyleBackColor = true;
            this.bImportFromTxt.Click += new System.EventHandler(this.bImportFromTxt_Click);
            // 
            // bExportToTxt
            // 
            this.bExportToTxt.Location = new System.Drawing.Point(12, 50);
            this.bExportToTxt.Name = "bExportToTxt";
            this.bExportToTxt.Size = new System.Drawing.Size(106, 32);
            this.bExportToTxt.TabIndex = 1;
            this.bExportToTxt.Text = "Export To Txt";
            this.bExportToTxt.UseVisualStyleBackColor = true;
            this.bExportToTxt.Click += new System.EventHandler(this.bExportToTxt_Click);
            // 
            // openFileTxt
            // 
            this.openFileTxt.FileName = "Katalog.txt";
            // 
            // infoProductTable
            // 
            this.infoProductTable.AllowDrop = true;
            this.infoProductTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoProductTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produc,
            this.Size,
            this.ScreenResolution,
            this.TypeScreen,
            this.TouchScreen,
            this.CPU,
            this.CPUThread,
            this.SpeedCPU,
            this.RAMSize,
            this.StorageSize,
            this.StorageType,
            this.CPUName,
            this.RAMGpu,
            this.OS,
            this.OpticalDrive});
            this.infoProductTable.Location = new System.Drawing.Point(2, 108);
            this.infoProductTable.Name = "infoProductTable";
            this.infoProductTable.Size = new System.Drawing.Size(1555, 374);
            this.infoProductTable.TabIndex = 3;
            this.infoProductTable.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.infoProductTable_CellValidating);
            // 
            // Produc
            // 
            this.Produc.HeaderText = "Produc";
            this.Produc.Name = "Produc";
            // 
            // Size
            // 
            this.Size.DataPropertyName = "int";
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            // 
            // ScreenResolution
            // 
            this.ScreenResolution.HeaderText = "Screen Resolution";
            this.ScreenResolution.Name = "ScreenResolution";
            // 
            // TypeScreen
            // 
            this.TypeScreen.HeaderText = "Type Screen";
            this.TypeScreen.Name = "TypeScreen";
            // 
            // TouchScreen
            // 
            this.TouchScreen.HeaderText = "Touch Screen";
            this.TouchScreen.Name = "TouchScreen";
            // 
            // CPU
            // 
            this.CPU.HeaderText = "CPU";
            this.CPU.Name = "CPU";
            // 
            // CPUThread
            // 
            this.CPUThread.HeaderText = "CPU Thread";
            this.CPUThread.Name = "CPUThread";
            // 
            // SpeedCPU
            // 
            this.SpeedCPU.HeaderText = "Speed CPU";
            this.SpeedCPU.Name = "SpeedCPU";
            // 
            // RAMSize
            // 
            this.RAMSize.HeaderText = "RAM size";
            this.RAMSize.Name = "RAMSize";
            // 
            // StorageSize
            // 
            this.StorageSize.HeaderText = "Storage Size";
            this.StorageSize.Name = "StorageSize";
            // 
            // StorageType
            // 
            this.StorageType.HeaderText = "Storage Type";
            this.StorageType.Name = "StorageType";
            // 
            // CPUName
            // 
            this.CPUName.HeaderText = "CPU Name";
            this.CPUName.Name = "CPUName";
            // 
            // RAMGpu
            // 
            this.RAMGpu.HeaderText = "RAM Gpu";
            this.RAMGpu.Name = "RAMGpu";
            // 
            // OS
            // 
            this.OS.HeaderText = "OS";
            this.OS.Name = "OS";
            // 
            // OpticalDrive
            // 
            this.OpticalDrive.HeaderText = "Optival Drive";
            this.OpticalDrive.Name = "OpticalDrive";
            // 
            // bImportToXML
            // 
            this.bImportToXML.Location = new System.Drawing.Point(138, 12);
            this.bImportToXML.Name = "bImportToXML";
            this.bImportToXML.Size = new System.Drawing.Size(106, 32);
            this.bImportToXML.TabIndex = 4;
            this.bImportToXML.Text = "Import From XML";
            this.bImportToXML.UseVisualStyleBackColor = true;
            // 
            // bExportToXML
            // 
            this.bExportToXML.Location = new System.Drawing.Point(138, 50);
            this.bExportToXML.Name = "bExportToXML";
            this.bExportToXML.Size = new System.Drawing.Size(106, 32);
            this.bExportToXML.TabIndex = 5;
            this.bExportToXML.Text = "Export To XML";
            this.bExportToXML.UseVisualStyleBackColor = true;
            this.bExportToXML.Click += new System.EventHandler(this.bExportToXML_Click);
            // 
            // bImportToDatabase
            // 
            this.bImportToDatabase.Location = new System.Drawing.Point(265, 12);
            this.bImportToDatabase.Name = "bImportToDatabase";
            this.bImportToDatabase.Size = new System.Drawing.Size(113, 32);
            this.bImportToDatabase.TabIndex = 6;
            this.bImportToDatabase.Text = "Import to Database";
            this.bImportToDatabase.UseVisualStyleBackColor = true;
            this.bImportToDatabase.Click += new System.EventHandler(this.bImportToDatabase_Click);
            // 
            // bExportToDatabase
            // 
            this.bExportToDatabase.Location = new System.Drawing.Point(265, 50);
            this.bExportToDatabase.Name = "bExportToDatabase";
            this.bExportToDatabase.Size = new System.Drawing.Size(113, 32);
            this.bExportToDatabase.TabIndex = 7;
            this.bExportToDatabase.Text = "Export To Database";
            this.bExportToDatabase.UseVisualStyleBackColor = true;
            this.bExportToDatabase.Click += new System.EventHandler(this.bExportToDatabase_Click);
            // 
            // cBProducentName
            // 
            this.cBProducentName.FormattingEnabled = true;
            this.cBProducentName.Items.AddRange(new object[] {
            "DELL",
            "Asus",
            "Fujitsu",
            "Huawei",
            "MSI",
            "Samsung",
            "Sony"});
            this.cBProducentName.Location = new System.Drawing.Point(408, 28);
            this.cBProducentName.Name = "cBProducentName";
            this.cBProducentName.Size = new System.Drawing.Size(121, 21);
            this.cBProducentName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Producent";
            // 
            // bCountProducentItems
            // 
            this.bCountProducentItems.Location = new System.Drawing.Point(408, 55);
            this.bCountProducentItems.Name = "bCountProducentItems";
            this.bCountProducentItems.Size = new System.Drawing.Size(121, 27);
            this.bCountProducentItems.TabIndex = 11;
            this.bCountProducentItems.Text = "Count producent items";
            this.bCountProducentItems.UseVisualStyleBackColor = true;
            this.bCountProducentItems.Click += new System.EventHandler(this.bCountProducentItems_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(551, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Quantity items of producent";
            // 
            // iQuantityItems
            // 
            this.iQuantityItems.AutoSize = true;
            this.iQuantityItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iQuantityItems.Location = new System.Drawing.Point(586, 50);
            this.iQuantityItems.Name = "iQuantityItems";
            this.iQuantityItems.Size = new System.Drawing.Size(77, 22);
            this.iQuantityItems.TabIndex = 13;
            this.iQuantityItems.Text = "Quantity";
            // 
            // cBScreenResolutionType
            // 
            this.cBScreenResolutionType.FormattingEnabled = true;
            this.cBScreenResolutionType.Items.AddRange(new object[] {
            "1600x900",
            "1920x1080",
            "1366x768",
            "1280x800"});
            this.cBScreenResolutionType.Location = new System.Drawing.Point(739, 63);
            this.cBScreenResolutionType.Name = "cBScreenResolutionType";
            this.cBScreenResolutionType.Size = new System.Drawing.Size(121, 21);
            this.cBScreenResolutionType.TabIndex = 14;
            // 
            // bFiltrByMatrix
            // 
            this.bFiltrByMatrix.Location = new System.Drawing.Point(1101, 21);
            this.bFiltrByMatrix.Name = "bFiltrByMatrix";
            this.bFiltrByMatrix.Size = new System.Drawing.Size(121, 36);
            this.bFiltrByMatrix.TabIndex = 15;
            this.bFiltrByMatrix.Text = "Show items with matrix";
            this.bFiltrByMatrix.UseVisualStyleBackColor = true;
            this.bFiltrByMatrix.Click += new System.EventHandler(this.bShowItemsWithMatrix_Click);
            // 
            // iMatrixInfo
            // 
            this.iMatrixInfo.AutoSize = true;
            this.iMatrixInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iMatrixInfo.Location = new System.Drawing.Point(866, 28);
            this.iMatrixInfo.Name = "iMatrixInfo";
            this.iMatrixInfo.Size = new System.Drawing.Size(229, 16);
            this.iMatrixInfo.TabIndex = 16;
            this.iMatrixInfo.Text = "Quantity items with Screen Resolution";
            // 
            // iQuantityItemsMatrix
            // 
            this.iQuantityItemsMatrix.AutoSize = true;
            this.iQuantityItemsMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iQuantityItemsMatrix.Location = new System.Drawing.Point(897, 53);
            this.iQuantityItemsMatrix.Name = "iQuantityItemsMatrix";
            this.iQuantityItemsMatrix.Size = new System.Drawing.Size(77, 22);
            this.iQuantityItemsMatrix.TabIndex = 17;
            this.iQuantityItemsMatrix.Text = "Quantity";
            // 
            // bCountByScreenResolution
            // 
            this.bCountByScreenResolution.Location = new System.Drawing.Point(739, 21);
            this.bCountByScreenResolution.Name = "bCountByScreenResolution";
            this.bCountByScreenResolution.Size = new System.Drawing.Size(121, 36);
            this.bCountByScreenResolution.TabIndex = 18;
            this.bCountByScreenResolution.Text = "Filtr by screen resolution";
            this.bCountByScreenResolution.UseVisualStyleBackColor = true;
            this.bCountByScreenResolution.Click += new System.EventHandler(this.bFiltrByScreenResolution_Click);
            // 
            // cBMatrixType
            // 
            this.cBMatrixType.FormattingEnabled = true;
            this.cBMatrixType.Items.AddRange(new object[] {
            "blyszczaca",
            "matowa"});
            this.cBMatrixType.Location = new System.Drawing.Point(1101, 63);
            this.cBMatrixType.Name = "cBMatrixType";
            this.cBMatrixType.Size = new System.Drawing.Size(121, 21);
            this.cBMatrixType.TabIndex = 19;
            this.cBMatrixType.SelectedIndexChanged += new System.EventHandler(this.cBMatrixType_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 494);
            this.Controls.Add(this.cBMatrixType);
            this.Controls.Add(this.bCountByScreenResolution);
            this.Controls.Add(this.iQuantityItemsMatrix);
            this.Controls.Add(this.iMatrixInfo);
            this.Controls.Add(this.bFiltrByMatrix);
            this.Controls.Add(this.cBScreenResolutionType);
            this.Controls.Add(this.iQuantityItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bCountProducentItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBProducentName);
            this.Controls.Add(this.bExportToDatabase);
            this.Controls.Add(this.bImportToDatabase);
            this.Controls.Add(this.bExportToXML);
            this.Controls.Add(this.bImportToXML);
            this.Controls.Add(this.infoProductTable);
            this.Controls.Add(this.bExportToTxt);
            this.Controls.Add(this.bImportFromTxt);
            this.Name = "Form1";
            this.Text = "Integration System Projekt";
            ((System.ComponentModel.ISupportInitialize)(this.infoProductTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bImportFromTxt;
        private System.Windows.Forms.Button bExportToTxt;
        private System.Windows.Forms.OpenFileDialog openFileTxt;
        private System.Windows.Forms.DataGridView infoProductTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScreenResolution;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeScreen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TouchScreen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPUThread;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpeedCPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAMSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn StorageSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn StorageType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPUName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAMGpu;
        private System.Windows.Forms.DataGridViewTextBoxColumn OS;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpticalDrive;
        private System.Windows.Forms.Button bImportToXML;
        private System.Windows.Forms.Button bExportToXML;
        private System.Windows.Forms.Button bImportToDatabase;
        private System.Windows.Forms.Button bExportToDatabase;
        private System.Windows.Forms.ComboBox cBProducentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bCountProducentItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label iQuantityItems;
        private System.Windows.Forms.ComboBox cBScreenResolutionType;
        private System.Windows.Forms.Button bFiltrByMatrix;
        private System.Windows.Forms.Label iMatrixInfo;
        private System.Windows.Forms.Label iQuantityItemsMatrix;
        private System.Windows.Forms.Button bCountByScreenResolution;
        private System.Windows.Forms.ComboBox cBMatrixType;
    }
}

