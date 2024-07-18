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
            TxtRecaudacion = new NumericUpDown();
            TxtFechaEstreno = new DateTimePicker();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TxtRecaudacion).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 461);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(TxtDirector, 2, 3);
            tableLayoutPanel1.Controls.Add(BtnGuardar, 2, 5);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 1, 3);
            tableLayoutPanel1.Controls.Add(label4, 1, 4);
            tableLayoutPanel1.Controls.Add(TxtTitulo, 2, 1);
            tableLayoutPanel1.Controls.Add(TxtRecaudacion, 2, 4);
            tableLayoutPanel1.Controls.Add(TxtFechaEstreno, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel1.Size = new Size(584, 461);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // TxtDirector
            // 
            TxtDirector.Dock = DockStyle.Top;
            TxtDirector.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtDirector.Location = new Point(294, 193);
            TxtDirector.MaxLength = 20;
            TxtDirector.Name = "TxtDirector";
            TxtDirector.Size = new Size(227, 29);
            TxtDirector.TabIndex = 2;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Dock = DockStyle.Bottom;
            BtnGuardar.Location = new Point(294, 380);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(227, 35);
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
            label1.Location = new Point(61, 38);
            label1.Name = "label1";
            label1.Size = new Size(227, 21);
            label1.TabIndex = 44;
            label1.Text = "Titulo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 114);
            label2.Name = "label2";
            label2.Size = new Size(227, 21);
            label2.TabIndex = 44;
            label2.Text = "Fecha de Estreno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 190);
            label3.Name = "label3";
            label3.Size = new Size(227, 21);
            label3.TabIndex = 44;
            label3.Text = "Director:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(61, 266);
            label4.Name = "label4";
            label4.Size = new Size(227, 21);
            label4.TabIndex = 44;
            label4.Text = "Recaudacion: ";
            // 
            // TxtTitulo
            // 
            TxtTitulo.Dock = DockStyle.Top;
            TxtTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtTitulo.Location = new Point(294, 41);
            TxtTitulo.MaxLength = 20;
            TxtTitulo.Name = "TxtTitulo";
            TxtTitulo.Size = new Size(227, 29);
            TxtTitulo.TabIndex = 0;
            // 
            // TxtRecaudacion
            // 
            TxtRecaudacion.Dock = DockStyle.Top;
            TxtRecaudacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtRecaudacion.Location = new Point(294, 269);
            TxtRecaudacion.Maximum = new decimal(new int[] { 276447231, 23283, 0, 0 });
            TxtRecaudacion.Name = "TxtRecaudacion";
            TxtRecaudacion.Size = new Size(227, 29);
            TxtRecaudacion.TabIndex = 3;
            TxtRecaudacion.Tag = "";
            TxtRecaudacion.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtFechaEstreno
            // 
            TxtFechaEstreno.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtFechaEstreno.CustomFormat = "yyyy-MM-dd";
            TxtFechaEstreno.Dock = DockStyle.Top;
            TxtFechaEstreno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtFechaEstreno.Format = DateTimePickerFormat.Custom;
            TxtFechaEstreno.Location = new Point(294, 117);
            TxtFechaEstreno.MaxDate = new DateTime(2024, 7, 17, 0, 0, 0, 0);
            TxtFechaEstreno.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            TxtFechaEstreno.Name = "TxtFechaEstreno";
            TxtFechaEstreno.Size = new Size(227, 23);
            TxtFechaEstreno.TabIndex = 1;
            TxtFechaEstreno.Value = new DateTime(2024, 7, 17, 0, 0, 0, 0);
            // 
            // IngresarPelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "IngresarPelicula";
            Size = new Size(584, 461);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TxtRecaudacion).EndInit();
            ResumeLayout(false);
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
        private NumericUpDown TxtRecaudacion;
        private DateTimePicker TxtFechaEstreno;
    }
}
