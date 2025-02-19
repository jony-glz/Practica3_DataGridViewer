namespace Practica3_DataGridViewer
{
    partial class frmDataGrid
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialogCSV = new OpenFileDialog();
            saveFileDialogCSV = new SaveFileDialog();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridViewCSV = new DataGridView();
            btnAbrir = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            menuStrip1 = new MenuStrip();
            aplicacionesToolStripMenuItem = new ToolStripMenuItem();
            fechaDeNacimientoYCURPToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCSV).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialogCSV
            // 
            openFileDialogCSV.Filter = "Archivo CSV|*.csv";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(dataGridViewCSV, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 111);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.20611F));
            tableLayoutPanel1.Size = new Size(2000, 1000);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewCSV
            // 
            dataGridViewCSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCSV.Location = new Point(3, 3);
            dataGridViewCSV.Name = "dataGridViewCSV";
            dataGridViewCSV.RowHeadersWidth = 123;
            dataGridViewCSV.Size = new Size(1994, 994);
            dataGridViewCSV.TabIndex = 0;
            // 
            // btnAbrir
            // 
            btnAbrir.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAbrir.Location = new Point(3, 12);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(2094, 75);
            btnAbrir.TabIndex = 2;
            btnAbrir.Text = "Abrir";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnAbrir, 0, 0);
            tableLayoutPanel2.Location = new Point(12, 1105);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(2100, 99);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(48, 48);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aplicacionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2128, 61);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // aplicacionesToolStripMenuItem
            // 
            aplicacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fechaDeNacimientoYCURPToolStripMenuItem });
            aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            aplicacionesToolStripMenuItem.Size = new Size(246, 57);
            aplicacionesToolStripMenuItem.Text = "Aplicaciones";
            // 
            // fechaDeNacimientoYCURPToolStripMenuItem
            // 
            fechaDeNacimientoYCURPToolStripMenuItem.Name = "fechaDeNacimientoYCURPToolStripMenuItem";
            fechaDeNacimientoYCURPToolStripMenuItem.Size = new Size(679, 66);
            fechaDeNacimientoYCURPToolStripMenuItem.Text = "Fecha de Nacimiento y CURP";
            fechaDeNacimientoYCURPToolStripMenuItem.Click += fechaDeNacimientoYCURPToolStripMenuItem_Click;
            // 
            // frmDataGrid
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2128, 1205);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmDataGrid";
            Text = "DataGridView";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCSV).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialogCSV;
        private SaveFileDialog saveFileDialogCSV;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridViewCSV;
        private Button btnAbrir;
        private DataGridViewTextBoxColumn dgvNombre;
        private DataGridViewTextBoxColumn dgvTelefono;
        private DataGridViewComboBoxColumn dgvSexo;
        private DataGridViewCheckBoxColumn dgvMayor;
        private DataGridViewTextBoxColumn dgvCurp;
        private TableLayoutPanel tableLayoutPanel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aplicacionesToolStripMenuItem;
        private ToolStripMenuItem fechaDeNacimientoYCURPToolStripMenuItem;
    }
}
