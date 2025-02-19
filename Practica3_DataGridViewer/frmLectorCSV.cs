using Practica3_DataGridViewer;

namespace Practica3_DataGridViewer
{
    public partial class frmDataGrid : Form
    {
        public frmDataGrid()
        {
            InitializeComponent();
        }

        string fileName = "";
        string[] text = null;
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialogCSV.ShowDialog();
            if (res == DialogResult.OK)
            {
                // Obtiene el nombre del archivo para leer toda la informacion de este
                fileName = openFileDialogCSV.FileName;
                text = File.ReadAllLines(fileName);

                // Se le asigna el nombre del archivo al frame
                this.Text = Path.GetFileName(fileName);

                // Borra los registros de renglones, columnas y valores por asignar
                dataGridViewCSV.Rows.Clear();
                dataGridViewCSV.Columns.Clear();

                // Determina la cantidad de encabezados y les asigna el respectivo nombre
                string[] header = text[0].Split(',');
                for (int i = 0; i < header.Length; i++)
                {
                    dataGridViewCSV.Columns.Add("Header" + (i + 1) + "", header[i]);
                }

                // Asigna los valores a guardar
                for (int i = 1; i < text.Length; i++)
                {
                    dataGridViewCSV.Rows.Add(text[i].Split(','));
                }

            }
        }

        private void fechaDeNacimientoYCURPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDateTimePick dDTP = new frmDateTimePick();
            dDTP.Show();
        }
    }
}
