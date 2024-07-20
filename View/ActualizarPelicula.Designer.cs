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
            tableLayoutPanel2 = new TableLayoutPanel();
            TxtRecaudacionAct = new TextBox();
            TxtErrorRecaudacionAct = new Label();
            TxtIdActualizar = new TextBox();
            TxtDirectorActualizar = new TextBox();
            BtnActualizarActualizar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TxtTituloActualizar = new TextBox();
            TxtFechaEstrenoActualizar = new DateTimePicker();
            groupBox1 = new GroupBox();
            Panel1Actualizar.SuspendLayout();
            TableLayoutPanel1Actualizar.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1Actualizar
            // 
            Panel1Actualizar.Controls.Add(TableLayoutPanel1Actualizar);
            Panel1Actualizar.Dock = DockStyle.Fill;
            Panel1Actualizar.Location = new Point(3, 19);
            Panel1Actualizar.Name = "Panel1Actualizar";
            Panel1Actualizar.Size = new Size(578, 439);
            Panel1Actualizar.TabIndex = 1;
            // 
            // TableLayoutPanel1Actualizar
            // 
            TableLayoutPanel1Actualizar.ColumnCount = 4;
            TableLayoutPanel1Actualizar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            TableLayoutPanel1Actualizar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            TableLayoutPanel1Actualizar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            TableLayoutPanel1Actualizar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            TableLayoutPanel1Actualizar.Controls.Add(tableLayoutPanel2, 2, 4);
            TableLayoutPanel1Actualizar.Controls.Add(TxtIdActualizar, 2, 6);
            TableLayoutPanel1Actualizar.Controls.Add(TxtDirectorActualizar, 2, 3);
            TableLayoutPanel1Actualizar.Controls.Add(BtnActualizarActualizar, 2, 5);
            TableLayoutPanel1Actualizar.Controls.Add(label1, 1, 1);
            TableLayoutPanel1Actualizar.Controls.Add(label2, 1, 2);
            TableLayoutPanel1Actualizar.Controls.Add(label3, 1, 3);
            TableLayoutPanel1Actualizar.Controls.Add(label4, 1, 4);
            TableLayoutPanel1Actualizar.Controls.Add(TxtTituloActualizar, 2, 1);
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
            TableLayoutPanel1Actualizar.Size = new Size(578, 439);
            TableLayoutPanel1Actualizar.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(TxtRecaudacionAct, 0, 0);
            tableLayoutPanel2.Controls.Add(TxtErrorRecaudacionAct, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(291, 258);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(225, 67);
            tableLayoutPanel2.TabIndex = 46;
            // 
            // TxtRecaudacionAct
            // 
            TxtRecaudacionAct.Dock = DockStyle.Top;
            TxtRecaudacionAct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtRecaudacionAct.Location = new Point(3, 3);
            TxtRecaudacionAct.MaxLength = 14;
            TxtRecaudacionAct.Name = "TxtRecaudacionAct";
            TxtRecaudacionAct.Size = new Size(219, 29);
            TxtRecaudacionAct.TabIndex = 46;
            TxtRecaudacionAct.TextAlign = HorizontalAlignment.Right;
            TxtRecaudacionAct.TextChanged += TxtRecaudacionAct_TextChanged;
            // 
            // TxtErrorRecaudacionAct
            // 
            TxtErrorRecaudacionAct.AutoSize = true;
            TxtErrorRecaudacionAct.Dock = DockStyle.Top;
            TxtErrorRecaudacionAct.ForeColor = Color.Firebrick;
            TxtErrorRecaudacionAct.Location = new Point(3, 33);
            TxtErrorRecaudacionAct.Name = "TxtErrorRecaudacionAct";
            TxtErrorRecaudacionAct.Size = new Size(219, 15);
            TxtErrorRecaudacionAct.TabIndex = 2;
            TxtErrorRecaudacionAct.Text = "Ingreso Invalido, Solo Numeros";
            TxtErrorRecaudacionAct.Visible = false;
            // 
            // TxtIdActualizar
            // 
            TxtIdActualizar.Dock = DockStyle.Top;
            TxtIdActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtIdActualizar.Location = new Point(291, 404);
            TxtIdActualizar.MaxLength = 20;
            TxtIdActualizar.Name = "TxtIdActualizar";
            TxtIdActualizar.Size = new Size(225, 29);
            TxtIdActualizar.TabIndex = 44;
            TxtIdActualizar.Visible = false;
            // 
            // TxtDirectorActualizar
            // 
            TxtDirectorActualizar.Dock = DockStyle.Top;
            TxtDirectorActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtDirectorActualizar.Location = new Point(291, 185);
            TxtDirectorActualizar.MaxLength = 20;
            TxtDirectorActualizar.Name = "TxtDirectorActualizar";
            TxtDirectorActualizar.Size = new Size(225, 29);
            TxtDirectorActualizar.TabIndex = 2;
            TxtDirectorActualizar.TextChanged += TxtDirectorActualizar_TextChanged;
            // 
            // BtnActualizarActualizar
            // 
            BtnActualizarActualizar.Dock = DockStyle.Bottom;
            BtnActualizarActualizar.Location = new Point(291, 363);
            BtnActualizarActualizar.Name = "BtnActualizarActualizar";
            BtnActualizarActualizar.Size = new Size(225, 35);
            BtnActualizarActualizar.TabIndex = 4;
            BtnActualizarActualizar.Text = "Actualizar";
            BtnActualizarActualizar.UseVisualStyleBackColor = true;
            BtnActualizarActualizar.Click += BtnActualizarActualizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 36);
            label1.Name = "label1";
            label1.Size = new Size(225, 21);
            label1.TabIndex = 44;
            label1.Text = "Titulo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 109);
            label2.Name = "label2";
            label2.Size = new Size(225, 21);
            label2.TabIndex = 44;
            label2.Text = "Fecha de Estreno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(60, 182);
            label3.Name = "label3";
            label3.Size = new Size(225, 21);
            label3.TabIndex = 44;
            label3.Text = "Director:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(60, 255);
            label4.Name = "label4";
            label4.Size = new Size(225, 21);
            label4.TabIndex = 44;
            label4.Text = "Recaudacion: ";
            // 
            // TxtTituloActualizar
            // 
            TxtTituloActualizar.Dock = DockStyle.Top;
            TxtTituloActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtTituloActualizar.Location = new Point(291, 39);
            TxtTituloActualizar.MaxLength = 20;
            TxtTituloActualizar.Name = "TxtTituloActualizar";
            TxtTituloActualizar.Size = new Size(225, 29);
            TxtTituloActualizar.TabIndex = 0;
            TxtTituloActualizar.TextChanged += TxtTituloActualizar_TextChanged;
            // 
            // TxtFechaEstrenoActualizar
            // 
            TxtFechaEstrenoActualizar.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtFechaEstrenoActualizar.CustomFormat = "yyyy-MM-dd";
            TxtFechaEstrenoActualizar.Dock = DockStyle.Top;
            TxtFechaEstrenoActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtFechaEstrenoActualizar.Format = DateTimePickerFormat.Custom;
            TxtFechaEstrenoActualizar.Location = new Point(291, 112);
            TxtFechaEstrenoActualizar.MaxDate = new DateTime(2024, 7, 17, 0, 0, 0, 0);
            TxtFechaEstrenoActualizar.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            TxtFechaEstrenoActualizar.Name = "TxtFechaEstrenoActualizar";
            TxtFechaEstrenoActualizar.Size = new Size(225, 23);
            TxtFechaEstrenoActualizar.TabIndex = 1;
            TxtFechaEstrenoActualizar.Value = new DateTime(2024, 7, 17, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(Panel1Actualizar);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(584, 461);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actualizar Pelicula";
            // 
            // ActualizarPelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "ActualizarPelicula";
            Size = new Size(584, 461);
            Panel1Actualizar.ResumeLayout(false);
            TableLayoutPanel1Actualizar.ResumeLayout(false);
            TableLayoutPanel1Actualizar.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private DateTimePicker TxtFechaEstrenoActualizar;
        private TextBox TxtIdActualizar;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox TxtRecaudacionAct;
        private Label TxtErrorRecaudacionAct;
    }
}
