namespace Peliculas.View
{
    partial class IngresarPelicula
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            TxtDirector = new TextBox();
            BtnGuardar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TxtTitulo = new TextBox();
            TxtFechaEstreno = new DateTimePicker();
            tableLayoutPanel2 = new TableLayoutPanel();
            TxtRecaudacionIng = new TextBox();
            TxtErrorRecaudacion = new Label();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(578, 439);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(TxtDirector, 2, 3);
            tableLayoutPanel1.Controls.Add(BtnGuardar, 2, 5);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 1, 3);
            tableLayoutPanel1.Controls.Add(label4, 1, 4);
            tableLayoutPanel1.Controls.Add(TxtTitulo, 2, 1);
            tableLayoutPanel1.Controls.Add(TxtFechaEstreno, 2, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333334F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333334F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(578, 439);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // TxtDirector
            // 
            TxtDirector.Dock = DockStyle.Top;
            TxtDirector.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtDirector.Location = new Point(233, 175);
            TxtDirector.MaxLength = 20;
            TxtDirector.Name = "TxtDirector";
            TxtDirector.Size = new Size(283, 29);
            TxtDirector.TabIndex = 2;
            TxtDirector.TextChanged += TxtDirector_TextChanged;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Dock = DockStyle.Bottom;
            BtnGuardar.Enabled = false;
            BtnGuardar.Location = new Point(233, 341);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(283, 35);
            BtnGuardar.TabIndex = 4;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 34);
            label1.Name = "label1";
            label1.Size = new Size(167, 21);
            label1.TabIndex = 44;
            label1.Text = "Titulo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 103);
            label2.Name = "label2";
            label2.Size = new Size(167, 21);
            label2.TabIndex = 44;
            label2.Text = "Fecha de Estreno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(60, 172);
            label3.Name = "label3";
            label3.Size = new Size(167, 21);
            label3.TabIndex = 44;
            label3.Text = "Director:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(60, 241);
            label4.Name = "label4";
            label4.Size = new Size(167, 21);
            label4.TabIndex = 44;
            label4.Text = "Recaudacion: ";
            // 
            // TxtTitulo
            // 
            TxtTitulo.Dock = DockStyle.Top;
            TxtTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtTitulo.Location = new Point(233, 37);
            TxtTitulo.MaxLength = 20;
            TxtTitulo.Name = "TxtTitulo";
            TxtTitulo.Size = new Size(283, 29);
            TxtTitulo.TabIndex = 0;
            TxtTitulo.TextChanged += TxtTitulo_TextChanged;
            // 
            // TxtFechaEstreno
            // 
            TxtFechaEstreno.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtFechaEstreno.CustomFormat = "yyyy-MM-dd";
            TxtFechaEstreno.Dock = DockStyle.Top;
            TxtFechaEstreno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtFechaEstreno.Format = DateTimePickerFormat.Custom;
            TxtFechaEstreno.Location = new Point(233, 106);
            TxtFechaEstreno.MaxDate = new DateTime(2024, 7, 17, 0, 0, 0, 0);
            TxtFechaEstreno.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            TxtFechaEstreno.Name = "TxtFechaEstreno";
            TxtFechaEstreno.Size = new Size(283, 23);
            TxtFechaEstreno.TabIndex = 1;
            TxtFechaEstreno.Value = new DateTime(2024, 7, 17, 0, 0, 0, 0);
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(TxtRecaudacionIng, 0, 0);
            tableLayoutPanel2.Controls.Add(TxtErrorRecaudacion, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(233, 244);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(283, 63);
            tableLayoutPanel2.TabIndex = 45;
            // 
            // TxtRecaudacionIng
            // 
            TxtRecaudacionIng.Dock = DockStyle.Top;
            TxtRecaudacionIng.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtRecaudacionIng.Location = new Point(3, 3);
            TxtRecaudacionIng.MaxLength = 14;
            TxtRecaudacionIng.Name = "TxtRecaudacionIng";
            TxtRecaudacionIng.Size = new Size(277, 29);
            TxtRecaudacionIng.TabIndex = 3;
            TxtRecaudacionIng.TextAlign = HorizontalAlignment.Right;
            TxtRecaudacionIng.TextChanged += TxtRecaudacionIng_TextChanged;
            // 
            // TxtErrorRecaudacion
            // 
            TxtErrorRecaudacion.AutoSize = true;
            TxtErrorRecaudacion.Dock = DockStyle.Top;
            TxtErrorRecaudacion.ForeColor = Color.Firebrick;
            TxtErrorRecaudacion.Location = new Point(3, 31);
            TxtErrorRecaudacion.Name = "TxtErrorRecaudacion";
            TxtErrorRecaudacion.Size = new Size(277, 15);
            TxtErrorRecaudacion.TabIndex = 2;
            TxtErrorRecaudacion.Text = "Ingreso Invalido, Solo Numeros";
            TxtErrorRecaudacion.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(panel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(584, 461);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingresar Pelicula";
            // 
            // IngresarPelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "IngresarPelicula";
            Size = new Size(584, 461);
            Load += IngresarPelicula_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button BtnGuardar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TxtDirector;
        private TextBox TxtTitulo;
        private DateTimePicker TxtFechaEstreno;
        private GroupBox groupBox1;
        private Label TxtErrorRecaudacion;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox TxtRecaudacionIng;
    }
}
