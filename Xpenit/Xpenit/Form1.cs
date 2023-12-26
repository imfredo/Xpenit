using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Xpenit
{
    public partial class Form1 : Form
    {
        Form2 ventana2;
        public Form1()
        {
            InitializeComponent();
            ventana2 = new Form2(this);

            // Agregar las columnas al DataGridView
            dataGridView1.Columns.Add("ColumnaFecha", "Fecha");
            dataGridView1.Columns.Add("ColumnaMonto", "Monto");
            dataGridView1.Columns.Add("ColumnaCategoria", "Categoría");
            dataGridView1.Columns.Add("ColumnaCuenta", "Cuenta");
            dataGridView1.Columns.Add("ColumnaNota", "Nota");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lblIngreso1.Text = "";
            lblGasto1.Text = "";
            lblTotal1.Text = "";

        }


        public void ActualizarLabelIngreso(string texto)
        {
            lblIngreso1.Text = texto;
        }
        public void ActualizarLabelGasto(string texto)
        {
            lblGasto1.Text = texto;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ventana2.ShowDialog();
        }

        public void AgregarFilaDataGridView(string Fecha, string Monto, string Categoria, string Cuenta, string Nota)
        {
            dataGridView1.Rows.Add(Fecha, Monto, Categoria, Cuenta, Nota);
        }
    }



}
