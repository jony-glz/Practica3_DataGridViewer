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
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCSV).BeginInit();
            tableLayoutPanel2.SuspendLayout();
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
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.20611F));
            tableLayoutPanel1.Size = new Size(1900, 900);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewCSV
            // 
            dataGridViewCSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCSV.Dock = DockStyle.Fill;
            dataGridViewCSV.Location = new Point(3, 3);
            dataGridViewCSV.Name = "dataGridViewCSV";
            dataGridViewCSV.RowHeadersWidth = 123;
            dataGridViewCSV.Size = new Size(1900, 894);
            dataGridViewCSV.TabIndex = 0;
            // 
            // btnAbrir
            // 
            btnAbrir.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAbrir.Location = new Point(3, 6);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(1897, 69);
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
            tableLayoutPanel2.Location = new Point(12, 921);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1903, 81);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // frmDataGrid
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1945, 1014);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "frmDataGrid";
            Text = "DataGridView";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCSV).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
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
    }
}
