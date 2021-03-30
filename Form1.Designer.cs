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
            ((System.ComponentModel.ISupportInitialize)(this.infoProductTable)).BeginInit();
            this.SuspendLayout();
            // 
            // bImportFromTxt
            // 
            this.bImportFromTxt.Location = new System.Drawing.Point(35, 25);
            this.bImportFromTxt.Name = "bImportFromTxt";
            this.bImportFromTxt.Size = new System.Drawing.Size(106, 32);
            this.bImportFromTxt.TabIndex = 0;
            this.bImportFromTxt.Text = "Import From Txt";
            this.bImportFromTxt.UseVisualStyleBackColor = true;
            this.bImportFromTxt.Click += new System.EventHandler(this.bImportFromTxt_Click);
            // 
            // bExportToTxt
            // 
            this.bExportToTxt.Location = new System.Drawing.Point(308, 25);
            this.bExportToTxt.Name = "bExportToTxt";
            this.bExportToTxt.Size = new System.Drawing.Size(118, 32);
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
            this.bImportToXML.Location = new System.Drawing.Point(168, 25);
            this.bImportToXML.Name = "bImportToXML";
            this.bImportToXML.Size = new System.Drawing.Size(106, 32);
            this.bImportToXML.TabIndex = 4;
            this.bImportToXML.Text = "Import From XML";
            this.bImportToXML.UseVisualStyleBackColor = true;
            // 
            // bExportToXML
            // 
            this.bExportToXML.Location = new System.Drawing.Point(455, 25);
            this.bExportToXML.Name = "bExportToXML";
            this.bExportToXML.Size = new System.Drawing.Size(118, 32);
            this.bExportToXML.TabIndex = 5;
            this.bExportToXML.Text = "Export To XML";
            this.bExportToXML.UseVisualStyleBackColor = true;
            this.bExportToXML.Click += new System.EventHandler(this.bExportToXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 494);
            this.Controls.Add(this.bExportToXML);
            this.Controls.Add(this.bImportToXML);
            this.Controls.Add(this.infoProductTable);
            this.Controls.Add(this.bExportToTxt);
            this.Controls.Add(this.bImportFromTxt);
            this.Name = "Form1";
            this.Text = "Integration System Projekt";
            ((System.ComponentModel.ISupportInitialize)(this.infoProductTable)).EndInit();
            this.ResumeLayout(false);

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
    }
}

