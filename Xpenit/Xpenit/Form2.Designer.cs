namespace Xpenit
{
    partial class Form2
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
            tabControl1 = new TabControl();
            tabIngresos = new TabPage();
            tabGastos = new TabPage();
            lblFechaIngresos = new Label();
            lblMontoIngresos = new Label();
            lblCategoriaIngresos = new Label();
            lblCuentaIngresos = new Label();
            lblNotaIngresos = new Label();
            txtFecha = new TextBox();
            txtMonto = new TextBox();
            txtCategoria = new TextBox();
            txtCuenta = new TextBox();
            txtNota = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            lblNotaGastos = new Label();
            lblCuentaGastos = new Label();
            lblCategoriaGastos = new Label();
            lblMontoGastos = new Label();
            lblFechaGastos = new Label();
            tabControl1.SuspendLayout();
            tabIngresos.SuspendLayout();
            tabGastos.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabIngresos);
            tabControl1.Controls.Add(tabGastos);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(427, 496);
            tabControl1.TabIndex = 0;
            // 
            // tabIngresos
            // 
            tabIngresos.Controls.Add(txtNota);
            tabIngresos.Controls.Add(txtCuenta);
            tabIngresos.Controls.Add(txtCategoria);
            tabIngresos.Controls.Add(txtMonto);
            tabIngresos.Controls.Add(txtFecha);
            tabIngresos.Controls.Add(lblNotaIngresos);
            tabIngresos.Controls.Add(lblCuentaIngresos);
            tabIngresos.Controls.Add(lblCategoriaIngresos);
            tabIngresos.Controls.Add(lblMontoIngresos);
            tabIngresos.Controls.Add(lblFechaIngresos);
            tabIngresos.Location = new Point(4, 24);
            tabIngresos.Name = "tabIngresos";
            tabIngresos.Padding = new Padding(3);
            tabIngresos.Size = new Size(419, 468);
            tabIngresos.TabIndex = 0;
            tabIngresos.Text = "Ingresos";
            tabIngresos.UseVisualStyleBackColor = true;
            // 
            // tabGastos
            // 
            tabGastos.Controls.Add(textBox1);
            tabGastos.Controls.Add(textBox2);
            tabGastos.Controls.Add(textBox3);
            tabGastos.Controls.Add(textBox4);
            tabGastos.Controls.Add(textBox5);
            tabGastos.Controls.Add(lblNotaGastos);
            tabGastos.Controls.Add(lblCuentaGastos);
            tabGastos.Controls.Add(lblCategoriaGastos);
            tabGastos.Controls.Add(lblMontoGastos);
            tabGastos.Controls.Add(lblFechaGastos);
            tabGastos.Location = new Point(4, 24);
            tabGastos.Name = "tabGastos";
            tabGastos.Padding = new Padding(3);
            tabGastos.Size = new Size(419, 468);
            tabGastos.TabIndex = 1;
            tabGastos.Text = "Gastos";
            tabGastos.UseVisualStyleBackColor = true;
            // 
            // lblFechaIngresos
            // 
            lblFechaIngresos.AutoSize = true;
            lblFechaIngresos.Location = new Point(15, 34);
            lblFechaIngresos.Name = "lblFechaIngresos";
            lblFechaIngresos.Size = new Size(38, 15);
            lblFechaIngresos.TabIndex = 0;
            lblFechaIngresos.Text = "Fecha";
            // 
            // lblMontoIngresos
            // 
            lblMontoIngresos.AutoSize = true;
            lblMontoIngresos.Location = new Point(15, 84);
            lblMontoIngresos.Name = "lblMontoIngresos";
            lblMontoIngresos.Size = new Size(43, 15);
            lblMontoIngresos.TabIndex = 1;
            lblMontoIngresos.Text = "Monto";
            // 
            // lblCategoriaIngresos
            // 
            lblCategoriaIngresos.AutoSize = true;
            lblCategoriaIngresos.Location = new Point(15, 124);
            lblCategoriaIngresos.Name = "lblCategoriaIngresos";
            lblCategoriaIngresos.Size = new Size(58, 15);
            lblCategoriaIngresos.TabIndex = 2;
            lblCategoriaIngresos.Text = "Categoría";
            // 
            // lblCuentaIngresos
            // 
            lblCuentaIngresos.AutoSize = true;
            lblCuentaIngresos.Location = new Point(15, 167);
            lblCuentaIngresos.Name = "lblCuentaIngresos";
            lblCuentaIngresos.Size = new Size(45, 15);
            lblCuentaIngresos.TabIndex = 3;
            lblCuentaIngresos.Text = "Cuenta";
            // 
            // lblNotaIngresos
            // 
            lblNotaIngresos.AutoSize = true;
            lblNotaIngresos.Location = new Point(15, 215);
            lblNotaIngresos.Name = "lblNotaIngresos";
            lblNotaIngresos.Size = new Size(33, 15);
            lblNotaIngresos.TabIndex = 4;
            lblNotaIngresos.Text = "Nota";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(91, 34);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(100, 23);
            txtFecha.TabIndex = 5;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(91, 81);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 6;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(91, 124);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 7;
            // 
            // txtCuenta
            // 
            txtCuenta.Location = new Point(91, 167);
            txtCuenta.Name = "txtCuenta";
            txtCuenta.Size = new Size(100, 23);
            txtCuenta.TabIndex = 8;
            // 
            // txtNota
            // 
            txtNota.Location = new Point(91, 215);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(100, 23);
            txtNota.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(73, 203);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(85, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(110, 115);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(85, 72);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(85, 25);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 15;
            // 
            // lblNotaGastos
            // 
            lblNotaGastos.AutoSize = true;
            lblNotaGastos.Location = new Point(34, 206);
            lblNotaGastos.Name = "lblNotaGastos";
            lblNotaGastos.Size = new Size(33, 15);
            lblNotaGastos.TabIndex = 14;
            lblNotaGastos.Text = "Nota";
            // 
            // lblCuentaGastos
            // 
            lblCuentaGastos.AutoSize = true;
            lblCuentaGastos.Location = new Point(34, 158);
            lblCuentaGastos.Name = "lblCuentaGastos";
            lblCuentaGastos.Size = new Size(45, 15);
            lblCuentaGastos.TabIndex = 13;
            lblCuentaGastos.Text = "Cuenta";
            // 
            // lblCategoriaGastos
            // 
            lblCategoriaGastos.AutoSize = true;
            lblCategoriaGastos.Location = new Point(34, 115);
            lblCategoriaGastos.Name = "lblCategoriaGastos";
            lblCategoriaGastos.Size = new Size(58, 15);
            lblCategoriaGastos.TabIndex = 12;
            lblCategoriaGastos.Text = "Categoría";
            // 
            // lblMontoGastos
            // 
            lblMontoGastos.AutoSize = true;
            lblMontoGastos.Location = new Point(34, 75);
            lblMontoGastos.Name = "lblMontoGastos";
            lblMontoGastos.Size = new Size(43, 15);
            lblMontoGastos.TabIndex = 11;
            lblMontoGastos.Text = "Monto";
            // 
            // lblFechaGastos
            // 
            lblFechaGastos.AutoSize = true;
            lblFechaGastos.Location = new Point(34, 25);
            lblFechaGastos.Name = "lblFechaGastos";
            lblFechaGastos.Size = new Size(38, 15);
            lblFechaGastos.TabIndex = 10;
            lblFechaGastos.Text = "Fecha";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 530);
            Controls.Add(tabControl1);
            Name = "Form2";
            Text = "Form2";
            tabControl1.ResumeLayout(false);
            tabIngresos.ResumeLayout(false);
            tabIngresos.PerformLayout();
            tabGastos.ResumeLayout(false);
            tabGastos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabIngresos;
        private Label lblNotaIngresos;
        private Label lblCuentaIngresos;
        private Label lblCategoriaIngresos;
        private Label lblMontoIngresos;
        private Label lblFechaIngresos;
        private TabPage tabGastos;
        private TextBox txtNota;
        private TextBox txtCuenta;
        private TextBox txtCategoria;
        private TextBox txtMonto;
        private TextBox txtFecha;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label lblNotaGastos;
        private Label lblCuentaGastos;
        private Label lblCategoriaGastos;
        private Label lblMontoGastos;
        private Label lblFechaGastos;
    }
}