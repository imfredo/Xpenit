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
            lblTotal = new Label();
            lblGasto = new Label();
            lblIngreso = new Label();
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            tabPage3 = new TabPage();
            dateTimePicker1 = new DateTimePicker();
            Iingreso1 = new DataGridViewTextBoxColumn();
            Movimiento1 = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Nota = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tab1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.ItemSize = new Size(60, 30);
            tabControl1.Location = new Point(12, 41);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(693, 397);
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
            tab1.Location = new Point(4, 34);
            tab1.Name = "tab1";
            tab1.Padding = new Padding(3);
            tab1.Size = new Size(685, 359);
            tab1.TabIndex = 0;
            tab1.Text = "Diario";
            tab1.UseVisualStyleBackColor = true;
            // 
            // lblTotal1
            // 
            lblTotal1.AutoSize = true;
            lblTotal1.Location = new Point(629, 37);
            lblTotal1.Name = "lblTotal1";
            lblTotal1.Size = new Size(38, 15);
            lblTotal1.TabIndex = 7;
            lblTotal1.Text = "label6";
            // 
            // lblGasto1
            // 
            lblGasto1.AutoSize = true;
            lblGasto1.Location = new Point(251, 42);
            lblGasto1.Name = "lblGasto1";
            lblGasto1.Size = new Size(38, 15);
            lblGasto1.TabIndex = 6;
            lblGasto1.Text = "label5";
            // 
            // lblIngreso1
            // 
            lblIngreso1.AutoSize = true;
            lblIngreso1.Location = new Point(26, 42);
            lblIngreso1.Name = "lblIngreso1";
            lblIngreso1.Size = new Size(38, 15);
            lblIngreso1.TabIndex = 5;
            lblIngreso1.Text = "label4";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(629, 282);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(33, 31);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "+";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Iingreso1, Movimiento1, Categoria, Monto, Fecha, Nota });
            dataGridView1.Location = new Point(22, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(597, 154);
            dataGridView1.TabIndex = 3;
            dataGridView1.Visible = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(635, 22);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(32, 15);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total";
            // 
            // lblGasto
            // 
            lblGasto.AutoSize = true;
            lblGasto.Location = new Point(251, 22);
            lblGasto.Name = "lblGasto";
            lblGasto.Size = new Size(55, 15);
            lblGasto.TabIndex = 1;
            lblGasto.Text = "Expenses";
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(22, 22);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(47, 15);
            lblIngreso.TabIndex = 0;
            lblIngreso.Text = "Income";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(685, 359);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Semanal";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(685, 359);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Mensual";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(685, 359);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "Calendario";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(406, 50);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(277, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // Iingreso1
            // 
            Iingreso1.HeaderText = "Ingreso";
            Iingreso1.Name = "Iingreso1";
            // 
            // Movimiento1
            // 
            Movimiento1.HeaderText = "$";
            Movimiento1.Name = "Movimiento1";
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto";
            Monto.Name = "Monto";
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            // 
            // Nota
            // 
            Nota.HeaderText = "Nota";
            Nota.Name = "Nota";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 457);
            Controls.Add(dateTimePicker1);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tab1.ResumeLayout(false);
            tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}
