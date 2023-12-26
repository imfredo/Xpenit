using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xpenit
{
    public partial class Form2 : Form
    {
        private Form1 ventana1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            ventana1 = form1;
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Fecha = txtFecha.Text;
            ventana1.ActualizarLabelIngreso(txtMonto.Text);
            string Monto = txtMonto.Text;
            string Categoria = txtCategoria.Text;
            string Cuenta = txtCuenta.Text;
            string Nota = txtNota.Text;
            
            ventana1.AgregarFilaDataGridView(Fecha, Monto, Categoria, Cuenta, Nota);


            this.Close();//Esto va a cerrar el Form2 despues de guardar todos los datos
            
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*Este evento lo que hará es permitir que solo puedas digitar solo números (0-9),
            teclas de control (como borrar)*/
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // este Handled detiene la entrada de caracteres no permitidos
            }
            
        }

        private void btnGuardarGastos_Click(object sender, EventArgs e)
        {
            string Fecha = txtFecha1.Text;
            ventana1.ActualizarLabelGasto(txtMonto1.Text);
            string Monto = txtMonto1.Text;
            string Categoria = txtCategoria1.Text;
            string Cuenta = txtCuenta1.Text;
            string Nota = txtNota1.Text;

            ventana1.AgregarFilaDataGridView(Fecha, Monto, Categoria, Cuenta, Nota);
            
        }
    }
}
