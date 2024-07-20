namespace Peliculas.View
{
    partial class ListaPeliculas
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
            DataGridPeliculas = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            BtnVer = new Button();
            BtnActualizar = new Button();
            BtnEliminar = new Button();
            BtnRefresh = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            TxtBuscar = new TextBox();
            BtnBuscar = new Button();
            PanelPeliculas = new Panel();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)DataGridPeliculas).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            PanelPeliculas.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // DataGridPeliculas
            // 
            DataGridPeliculas.AllowUserToOrderColumns = true;
            DataGridPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridPeliculas.Dock = DockStyle.Fill;
            DataGridPeliculas.Location = new Point(60, 46);
            DataGridPeliculas.Name = "DataGridPeliculas";
            DataGridPeliculas.Size = new Size(456, 345);
            DataGridPeliculas.TabIndex = 0;
            DataGridPeliculas.RowsAdded += DataGridPeliculas_RowsAdded;
            DataGridPeliculas.RowsRemoved += DataGridPeliculas_RowsRemoved;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(DataGridPeliculas, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Controls.Add(BtnRefresh, 2, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(578, 439);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoScroll = true;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(BtnVer, 0, 0);
            tableLayoutPanel2.Controls.Add(BtnActualizar, 1, 0);
            tableLayoutPanel2.Controls.Add(BtnEliminar, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(60, 397);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(456, 39);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // BtnVer
            // 
            BtnVer.Anchor = AnchorStyles.None;
            BtnVer.Location = new Point(3, 4);
            BtnVer.Name = "BtnVer";
            BtnVer.Size = new Size(145, 30);
            BtnVer.TabIndex = 2;
            BtnVer.Text = "Ver";
            BtnVer.UseVisualStyleBackColor = true;
            BtnVer.Click += BtnVer_Click;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Anchor = AnchorStyles.None;
            BtnActualizar.Location = new Point(154, 4);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(145, 30);
            BtnActualizar.TabIndex = 0;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = true;
            BtnActualizar.Click += BtnActualizar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Anchor = AnchorStyles.None;
            BtnEliminar.FlatAppearance.BorderColor = Color.Red;
            BtnEliminar.Location = new Point(305, 4);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(148, 30);
            BtnEliminar.TabIndex = 1;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnRefresh
            // 
            BtnRefresh.BackColor = Color.Transparent;
            BtnRefresh.Dock = DockStyle.Fill;
            BtnRefresh.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnRefresh.Image = Properties.Resources.refresh25;
            BtnRefresh.ImageAlign = ContentAlignment.TopCenter;
            BtnRefresh.Location = new Point(522, 3);
            BtnRefresh.Name = "BtnRefresh";
            BtnRefresh.Size = new Size(53, 37);
            BtnRefresh.TabIndex = 3;
            BtnRefresh.Text = "Refrescar";
            BtnRefresh.TextAlign = ContentAlignment.BottomCenter;
            BtnRefresh.UseVisualStyleBackColor = false;
            BtnRefresh.Click += BtnRefresh_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(TxtBuscar, 1, 0);
            tableLayoutPanel3.Controls.Add(BtnBuscar, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(60, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(456, 37);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 8);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 4;
            label1.Text = "Titulo:";
            // 
            // TxtBuscar
            // 
            TxtBuscar.Dock = DockStyle.Bottom;
            TxtBuscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtBuscar.Location = new Point(94, 7);
            TxtBuscar.MaxLength = 23;
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(222, 27);
            TxtBuscar.TabIndex = 5;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.None;
            BtnBuscar.Cursor = Cursors.Hand;
            BtnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBuscar.Location = new Point(331, 5);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(112, 26);
            BtnBuscar.TabIndex = 6;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // PanelPeliculas
            // 
            PanelPeliculas.Controls.Add(tableLayoutPanel1);
            PanelPeliculas.Dock = DockStyle.Fill;
            PanelPeliculas.Location = new Point(3, 19);
            PanelPeliculas.Name = "PanelPeliculas";
            PanelPeliculas.Size = new Size(578, 439);
            PanelPeliculas.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(PanelPeliculas);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(584, 461);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista Peliculas";
            // 
            // ListaPeliculas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "ListaPeliculas";
            Size = new Size(584, 461);
            ((System.ComponentModel.ISupportInitialize)DataGridPeliculas).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            PanelPeliculas.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridPeliculas;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button BtnActualizar;
        private Button BtnEliminar;
        private Button BtnRefresh;
        private Panel PanelPeliculas;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private TextBox TxtBuscar;
        private Button BtnBuscar;
        private Button BtnVer;
        private GroupBox groupBox1;
    }
}
