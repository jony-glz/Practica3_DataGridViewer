namespace Practica3_DataGridViewer
{
    partial class frmDateTimePick
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            dtpNacimiento = new DateTimePicker();
            label2 = new Label();
            dtpCalculo = new DateTimePicker();
            btnCalcular = new Button();
            tbCurp = new TextBox();
            label3 = new Label();
            btnCurp = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.3611336F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.6388664F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(dtpNacimiento, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(dtpCalculo, 0, 3);
            tableLayoutPanel1.Controls.Add(btnCalcular, 1, 3);
            tableLayoutPanel1.Location = new Point(36, 52);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 98F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 131F));
            tableLayoutPanel1.Size = new Size(1163, 406);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(355, 48);
            label1.TabIndex = 0;
            label1.Text = "Fecha de Nacimiento";
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Location = new Point(3, 91);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(696, 55);
            dtpNacimiento.TabIndex = 1;
            dtpNacimiento.ValueChanged += dtpNacimiento_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 176);
            label2.Name = "label2";
            label2.Size = new Size(288, 48);
            label2.TabIndex = 2;
            label2.Text = "Fecha de Calculo";
            // 
            // dtpCalculo
            // 
            dtpCalculo.Enabled = false;
            dtpCalculo.Location = new Point(3, 277);
            dtpCalculo.Name = "dtpCalculo";
            dtpCalculo.Size = new Size(696, 55);
            dtpCalculo.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnCalcular.Location = new Point(705, 305);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(455, 69);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // tbCurp
            // 
            tbCurp.Location = new Point(36, 586);
            tbCurp.Name = "tbCurp";
            tbCurp.Size = new Size(699, 55);
            tbCurp.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 521);
            label3.Name = "label3";
            label3.Size = new Size(109, 48);
            label3.TabIndex = 2;
            label3.Text = "CURP";
            // 
            // btnCurp
            // 
            btnCurp.Location = new Point(741, 572);
            btnCurp.Name = "btnCurp";
            btnCurp.Size = new Size(225, 69);
            btnCurp.TabIndex = 3;
            btnCurp.Text = "CURP";
            btnCurp.UseVisualStyleBackColor = true;
            btnCurp.Click += btnCurp_Click;
            // 
            // frmDateTimePick
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1602, 861);
            Controls.Add(btnCurp);
            Controls.Add(label3);
            Controls.Add(tbCurp);
            Controls.Add(tableLayoutPanel1);
            Name = "frmDateTimePick";
            Text = "frmDateTimePick";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DateTimePicker dtpNacimiento;
        private Label label2;
        private DateTimePicker dtpCalculo;
        private Button btnCalcular;
        private TextBox tbCurp;
        private Label label3;
        private Button btnCurp;
    }
}