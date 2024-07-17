namespace Peliculas.View
{
    partial class ActualizarPelicula
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
            Panel1Actualizar = new Panel();
            TableLayoutPanel1Actualizar = new TableLayoutPanel();
            TxtIdActualizar = new TextBox();
            TxtDirectorActualizar = new TextBox();
            BtnActualizarActualizar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TxtTituloActualizar = new TextBox();
            TxtRecaudacionActualizar = new NumericUpDown();
            TxtFechaEstrenoActualizar = new DateTimePicker();
            Panel1Actualizar.SuspendLayout();
            TableLayoutPanel1Actualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TxtRecaudacionActualizar).BeginInit();
            SuspendLayout();
            // 
            // Panel1Actualizar
            // 
            Panel1Actualizar.Controls.Add(TableLayoutPanel1Actualizar);
            Panel1Actualizar.Dock = DockStyle.Fill;
            Panel1Actualizar.Location = new Point(0, 0);
            Panel1Actualizar.Name = "Panel1Actualizar";
            Panel1Actualizar.Size = new Size(584, 461);
            Panel1Actualizar.TabIndex = 1;
            // 
            // TableLayoutPanel1Actualizar
            // 
            TableLayoutPanel1Actualizar.ColumnCount = 4;
            TableLayoutPanel1Actualizar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            TableLayoutPanel1Actualizar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            TableLayoutPanel1Actualizar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            TableLayoutPanel1Actualizar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            TableLayoutPanel1Actualizar.Controls.Add(TxtIdActualizar, 2, 6);
            TableLayoutPanel1Actualizar.Controls.Add(TxtDirectorActualizar, 2, 3);
            TableLayoutPanel1Actualizar.Controls.Add(BtnActualizarActualizar, 2, 5);
            TableLayoutPanel1Actualizar.Controls.Add(label1, 1, 1);
            TableLayoutPanel1Actualizar.Controls.Add(label2, 1, 2);
            TableLayoutPanel1Actualizar.Controls.Add(label3, 1, 3);
            TableLayoutPanel1Actualizar.Controls.Add(label4, 1, 4);
            TableLayoutPanel1Actualizar.Controls.Add(TxtTituloActualizar, 2, 1);
            TableLayoutPanel1Actualizar.Controls.Add(TxtRecaudacionActualizar, 2, 4);
            TableLayoutPanel1Actualizar.Controls.Add(TxtFechaEstrenoActualizar, 2, 2);
            TableLayoutPanel1Actualizar.Dock = DockStyle.Fill;
            TableLayoutPanel1Actualizar.Location = new Point(0, 0);
            TableLayoutPanel1Actualizar.Name = "TableLayoutPanel1Actualizar";
            TableLayoutPanel1Actualizar.RowCount = 7;
            TableLayoutPanel1Actualizar.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            TableLayoutPanel1Actualizar.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            TableLayoutPanel1Actualizar.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            TableLayoutPanel1Actualizar.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            TableLayoutPanel1Actualizar.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            TableLayoutPanel1Actualizar.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            TableLayoutPanel1Actualizar.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            TableLayoutPanel1Actualizar.Size = new Size(584, 461);
            TableLayoutPanel1Actualizar.TabIndex = 0;
            // 
            // TxtIdActualizar
            // 
            TxtIdActualizar.Dock = DockStyle.Top;
            TxtIdActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtIdActualizar.Location = new Point(294, 421);
            TxtIdActualizar.MaxLength = 20;
            TxtIdActualizar.Name = "TxtIdActualizar";
            TxtIdActualizar.Size = new Size(227, 29);
            TxtIdActualizar.TabIndex = 13;
            TxtIdActualizar.Visible = false;
            // 
            // TxtDirectorActualizar
            // 
            TxtDirectorActualizar.Dock = DockStyle.Top;
            TxtDirectorActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtDirectorActualizar.Location = new Point(294, 193);
            TxtDirectorActualizar.MaxLength = 20;
            TxtDirectorActualizar.Name = "TxtDirectorActualizar";
            TxtDirectorActualizar.Size = new Size(227, 29);
            TxtDirectorActualizar.TabIndex = 9;
            // 
            // BtnActualizarActualizar
            // 
            BtnActualizarActualizar.Dock = DockStyle.Bottom;
            BtnActualizarActualizar.Location = new Point(294, 380);
            BtnActualizarActualizar.Name = "BtnActualizarActualizar";
            BtnActualizarActualizar.Size = new Size(227, 35);
            BtnActualizarActualizar.TabIndex = 2;
            BtnActualizarActualizar.Text = "Actualizar";
            BtnActualizarActualizar.UseVisualStyleBackColor = true;
            BtnActualizarActualizar.Click += BtnActualizarActualizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 38);
            label1.Name = "label1";
            label1.Size = new Size(227, 21);
            label1.TabIndex = 3;
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
            label2.TabIndex = 4;
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
            label3.TabIndex = 5;
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
            label4.TabIndex = 6;
            label4.Text = "Recaudacion: ";
            // 
            // TxtTituloActualizar
            // 
            TxtTituloActualizar.Dock = DockStyle.Top;
            TxtTituloActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtTituloActualizar.Location = new Point(294, 41);
            TxtTituloActualizar.MaxLength = 20;
            TxtTituloActualizar.Name = "TxtTituloActualizar";
            TxtTituloActualizar.Size = new Size(227, 29);
            TxtTituloActualizar.TabIndex = 7;
            // 
            // TxtRecaudacionActualizar
            // 
            TxtRecaudacionActualizar.Dock = DockStyle.Top;
            TxtRecaudacionActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtRecaudacionActualizar.Location = new Point(294, 269);
            TxtRecaudacionActualizar.Maximum = new decimal(new int[] { 276447231, 23283, 0, 0 });
            TxtRecaudacionActualizar.Name = "TxtRecaudacionActualizar";
            TxtRecaudacionActualizar.Size = new Size(227, 29);
            TxtRecaudacionActualizar.TabIndex = 11;
            TxtRecaudacionActualizar.Tag = "";
            TxtRecaudacionActualizar.TextAlign = HorizontalAlignment.Right;
            TxtRecaudacionActualizar.ThousandsSeparator = true;
            // 
            // TxtFechaEstrenoActualizar
            // 
            TxtFechaEstrenoActualizar.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtFechaEstrenoActualizar.CustomFormat = "yyyy-MM-dd";
            TxtFechaEstrenoActualizar.Dock = DockStyle.Top;
            TxtFechaEstrenoActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtFechaEstrenoActualizar.Format = DateTimePickerFormat.Custom;
            TxtFechaEstrenoActualizar.Location = new Point(294, 117);
            TxtFechaEstrenoActualizar.MaxDate = new DateTime(2024, 7, 17, 0, 0, 0, 0);
            TxtFechaEstrenoActualizar.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            TxtFechaEstrenoActualizar.Name = "TxtFechaEstrenoActualizar";
            TxtFechaEstrenoActualizar.Size = new Size(227, 23);
            TxtFechaEstrenoActualizar.TabIndex = 12;
            TxtFechaEstrenoActualizar.Value = new DateTime(2024, 7, 17, 0, 0, 0, 0);
            // 
            // ActualizarPelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Panel1Actualizar);
            Name = "ActualizarPelicula";
            Size = new Size(584, 461);
            Panel1Actualizar.ResumeLayout(false);
            TableLayoutPanel1Actualizar.ResumeLayout(false);
            TableLayoutPanel1Actualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TxtRecaudacionActualizar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel1Actualizar;
        private TableLayoutPanel TableLayoutPanel1Actualizar;
        private TextBox TxtDirectorActualizar;
        private Button BtnActualizarActualizar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TxtTituloActualizar;
        private NumericUpDown TxtRecaudacionActualizar;
        private DateTimePicker TxtFechaEstrenoActualizar;
        private TextBox TxtIdActualizar;
    }
}
