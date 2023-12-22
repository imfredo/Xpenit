namespace Xpenit
{
    partial class Form1
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
            tabControl1 = new TabControl();
            tab1 = new TabPage();
            lblTotal1 = new Label();
            lblGasto1 = new Label();
            lblIngreso1 = new Label();
            btnAgregar = new Button();
            dataGridView1 = new DataGridView();
            Iingreso1 = new DataGridViewTextBoxColumn();
            Movimiento1 = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Nota = new DataGridViewTextBoxColumn();
            lblTotal = new Label();
            lblGasto = new Label();
            lblIngreso = new Label();
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            tabPage3 = new TabPage();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tab1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.ItemSize = new Size(60, 30);
            tabControl1.Location = new Point(22, 87);
            tabControl1.Margin = new Padding(6, 6, 6, 6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1287, 847);
            tabControl1.TabIndex = 0;
            // 
            // tab1
            // 
            tab1.Controls.Add(lblTotal1);
            tab1.Controls.Add(lblGasto1);
            tab1.Controls.Add(lblIngreso1);
            tab1.Controls.Add(btnAgregar);
            tab1.Controls.Add(dataGridView1);
            tab1.Controls.Add(lblTotal);
            tab1.Controls.Add(lblGasto);
            tab1.Controls.Add(lblIngreso);
            tab1.Location = new Point(8, 38);
            tab1.Margin = new Padding(6, 6, 6, 6);
            tab1.Name = "tab1";
            tab1.Padding = new Padding(6, 6, 6, 6);
            tab1.Size = new Size(1271, 801);
            tab1.TabIndex = 0;
            tab1.Text = "Diario";
            tab1.UseVisualStyleBackColor = true;
            // 
            // lblTotal1
            // 
            lblTotal1.AutoSize = true;
            lblTotal1.Location = new Point(1168, 79);
            lblTotal1.Margin = new Padding(6, 0, 6, 0);
            lblTotal1.Name = "lblTotal1";
            lblTotal1.Size = new Size(78, 32);
            lblTotal1.TabIndex = 7;
            lblTotal1.Text = "label6";
            // 
            // lblGasto1
            // 
            lblGasto1.AutoSize = true;
            lblGasto1.Location = new Point(466, 90);
            lblGasto1.Margin = new Padding(6, 0, 6, 0);
            lblGasto1.Name = "lblGasto1";
            lblGasto1.Size = new Size(78, 32);
            lblGasto1.TabIndex = 6;
            lblGasto1.Text = "label5";
            // 
            // lblIngreso1
            // 
            lblIngreso1.AutoSize = true;
            lblIngreso1.Location = new Point(48, 90);
            lblIngreso1.Margin = new Padding(6, 0, 6, 0);
            lblIngreso1.Name = "lblIngreso1";
            lblIngreso1.Size = new Size(78, 32);
            lblIngreso1.TabIndex = 5;
            lblIngreso1.Text = "label4";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(1168, 602);
            btnAgregar.Margin = new Padding(6, 6, 6, 6);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(61, 66);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "+";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Iingreso1, Movimiento1, Categoria, Monto, Fecha, Nota });
            dataGridView1.Location = new Point(41, 339);
            dataGridView1.Margin = new Padding(6, 6, 6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1109, 329);
            dataGridView1.TabIndex = 3;
            dataGridView1.Visible = false;
            // 
            // Iingreso1
            // 
            Iingreso1.HeaderText = "Ingreso";
            Iingreso1.MinimumWidth = 10;
            Iingreso1.Name = "Iingreso1";
            Iingreso1.Width = 200;
            // 
            // Movimiento1
            // 
            Movimiento1.HeaderText = "$";
            Movimiento1.MinimumWidth = 10;
            Movimiento1.Name = "Movimiento1";
            Movimiento1.Width = 200;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 10;
            Categoria.Name = "Categoria";
            Categoria.Width = 200;
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto";
            Monto.MinimumWidth = 10;
            Monto.Name = "Monto";
            Monto.Width = 200;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 10;
            Fecha.Name = "Fecha";
            Fecha.Width = 200;
            // 
            // Nota
            // 
            Nota.HeaderText = "Nota";
            Nota.MinimumWidth = 10;
            Nota.Name = "Nota";
            Nota.Width = 200;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(1179, 47);
            lblTotal.Margin = new Padding(6, 0, 6, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(65, 32);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total";
            // 
            // lblGasto
            // 
            lblGasto.AutoSize = true;
            lblGasto.Location = new Point(466, 47);
            lblGasto.Margin = new Padding(6, 0, 6, 0);
            lblGasto.Name = "lblGasto";
            lblGasto.Size = new Size(111, 32);
            lblGasto.TabIndex = 1;
            lblGasto.Text = "Expenses";
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(41, 47);
            lblIngreso.Margin = new Padding(6, 0, 6, 0);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(93, 32);
            lblIngreso.TabIndex = 0;
            lblIngreso.Text = "Income";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button1);
            tabPage2.Location = new Point(8, 38);
            tabPage2.Margin = new Padding(6, 6, 6, 6);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(6, 6, 6, 6);
            tabPage2.Size = new Size(1271, 801);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Semanal";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(8, 38);
            tabPage1.Margin = new Padding(6, 6, 6, 6);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(6, 6, 6, 6);
            tabPage1.Size = new Size(1271, 801);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Mensual";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(8, 38);
            tabPage3.Margin = new Padding(6, 6, 6, 6);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(6, 6, 6, 6);
            tabPage3.Size = new Size(1271, 801);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "Calendario";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(754, 107);
            dateTimePicker1.Margin = new Padding(6, 6, 6, 6);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(511, 39);
            dateTimePicker1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(355, 245);
            button1.Name = "button1";
            button1.Size = new Size(470, 203);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1330, 975);
            Controls.Add(dateTimePicker1);
            Controls.Add(tabControl1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tab1.ResumeLayout(false);
            tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tab1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private Label lblTotal;
        private Label lblGasto;
        private Label lblIngreso;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Button btnAgregar;
        private Label lblTotal1;
        private Label lblGasto1;
        private Label lblIngreso1;
        private DataGridViewTextBoxColumn Iingreso1;
        private DataGridViewTextBoxColumn Movimiento1;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Nota;
        private Button button1;
    }
}
