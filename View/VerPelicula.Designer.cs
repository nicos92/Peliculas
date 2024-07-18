namespace Peliculas.View
{
    partial class VerPelicula
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
            PanelVerPelicula = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            TxtIdVer = new TextBox();
            BtnActualizar = new Button();
            TxtDirectorVer = new TextBox();
            BtnEliminarVer = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TxtTituloVer = new TextBox();
            TxtRecaudacionVer = new NumericUpDown();
            TxtFechaEstrenoVer = new DateTimePicker();
            PanelVerPelicula.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TxtRecaudacionVer).BeginInit();
            SuspendLayout();
            // 
            // PanelVerPelicula
            // 
            PanelVerPelicula.Controls.Add(tableLayoutPanel1);
            PanelVerPelicula.Dock = DockStyle.Fill;
            PanelVerPelicula.Location = new Point(0, 0);
            PanelVerPelicula.Name = "PanelVerPelicula";
            PanelVerPelicula.Size = new Size(584, 461);
            PanelVerPelicula.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(TxtIdVer, 2, 6);
            tableLayoutPanel1.Controls.Add(BtnActualizar, 2, 5);
            tableLayoutPanel1.Controls.Add(TxtDirectorVer, 2, 3);
            tableLayoutPanel1.Controls.Add(BtnEliminarVer, 1, 5);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 1, 3);
            tableLayoutPanel1.Controls.Add(label4, 1, 4);
            tableLayoutPanel1.Controls.Add(TxtTituloVer, 2, 1);
            tableLayoutPanel1.Controls.Add(TxtRecaudacionVer, 2, 4);
            tableLayoutPanel1.Controls.Add(TxtFechaEstrenoVer, 2, 2);
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
            // TxtIdVer
            // 
            TxtIdVer.Dock = DockStyle.Top;
            TxtIdVer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtIdVer.Location = new Point(294, 421);
            TxtIdVer.MaxLength = 20;
            TxtIdVer.Name = "TxtIdVer";
            TxtIdVer.Size = new Size(227, 29);
            TxtIdVer.TabIndex = 44;
            TxtIdVer.Visible = false;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Dock = DockStyle.Fill;
            BtnActualizar.Location = new Point(311, 362);
            BtnActualizar.Margin = new Padding(20);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(193, 36);
            BtnActualizar.TabIndex = 4;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = true;
            BtnActualizar.Click += BtnActualizar_Click;
            // 
            // TxtDirectorVer
            // 
            TxtDirectorVer.Dock = DockStyle.Top;
            TxtDirectorVer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtDirectorVer.Location = new Point(294, 193);
            TxtDirectorVer.MaxLength = 20;
            TxtDirectorVer.Name = "TxtDirectorVer";
            TxtDirectorVer.Size = new Size(227, 29);
            TxtDirectorVer.TabIndex = 2;
            // 
            // BtnEliminarVer
            // 
            BtnEliminarVer.Dock = DockStyle.Fill;
            BtnEliminarVer.Location = new Point(78, 362);
            BtnEliminarVer.Margin = new Padding(20);
            BtnEliminarVer.Name = "BtnEliminarVer";
            BtnEliminarVer.Size = new Size(193, 36);
            BtnEliminarVer.TabIndex = 5;
            BtnEliminarVer.Text = "Eliminar";
            BtnEliminarVer.UseVisualStyleBackColor = true;
            BtnEliminarVer.Click += BtnEliminarVer_Click;
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
            // TxtTituloVer
            // 
            TxtTituloVer.Dock = DockStyle.Top;
            TxtTituloVer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtTituloVer.Location = new Point(294, 41);
            TxtTituloVer.MaxLength = 20;
            TxtTituloVer.Name = "TxtTituloVer";
            TxtTituloVer.Size = new Size(227, 29);
            TxtTituloVer.TabIndex = 0;
            // 
            // TxtRecaudacionVer
            // 
            TxtRecaudacionVer.Dock = DockStyle.Top;
            TxtRecaudacionVer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtRecaudacionVer.Location = new Point(294, 269);
            TxtRecaudacionVer.Maximum = new decimal(new int[] { 276447231, 23283, 0, 0 });
            TxtRecaudacionVer.Name = "TxtRecaudacionVer";
            TxtRecaudacionVer.Size = new Size(227, 29);
            TxtRecaudacionVer.TabIndex = 3;
            TxtRecaudacionVer.Tag = ".";
            TxtRecaudacionVer.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtFechaEstrenoVer
            // 
            TxtFechaEstrenoVer.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtFechaEstrenoVer.CustomFormat = "yyyy-MM-dd";
            TxtFechaEstrenoVer.Dock = DockStyle.Top;
            TxtFechaEstrenoVer.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtFechaEstrenoVer.Format = DateTimePickerFormat.Custom;
            TxtFechaEstrenoVer.Location = new Point(294, 117);
            TxtFechaEstrenoVer.MaxDate = new DateTime(2024, 7, 17, 0, 0, 0, 0);
            TxtFechaEstrenoVer.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            TxtFechaEstrenoVer.Name = "TxtFechaEstrenoVer";
            TxtFechaEstrenoVer.Size = new Size(227, 23);
            TxtFechaEstrenoVer.TabIndex = 1;
            TxtFechaEstrenoVer.Value = new DateTime(2024, 7, 17, 0, 0, 0, 0);
            // 
            // VerPelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelVerPelicula);
            Name = "VerPelicula";
            Size = new Size(584, 461);
            PanelVerPelicula.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TxtRecaudacionVer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelVerPelicula;
        private TableLayoutPanel tableLayoutPanel1;
        private Button BtnActualizar;
        private TextBox TxtDirectorVer;
        private Button BtnEliminarVer;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TxtTituloVer;
        private NumericUpDown TxtRecaudacionVer;
        private DateTimePicker TxtFechaEstrenoVer;
        private TextBox TxtIdVer;
    }
}
