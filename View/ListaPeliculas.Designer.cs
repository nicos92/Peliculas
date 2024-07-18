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
            BtnActualizar = new Button();
            BtnEliminar = new Button();
            BtnRefresh = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            TxtBuscar = new TextBox();
            BtnBuscar = new Button();
            PanelPeliculas = new Panel();
            ((System.ComponentModel.ISupportInitialize)DataGridPeliculas).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            PanelPeliculas.SuspendLayout();
            SuspendLayout();
            // 
            // DataGridPeliculas
            // 
            DataGridPeliculas.AllowUserToOrderColumns = true;
            DataGridPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridPeliculas.Dock = DockStyle.Fill;
            DataGridPeliculas.Location = new Point(61, 49);
            DataGridPeliculas.Name = "DataGridPeliculas";
            DataGridPeliculas.Size = new Size(461, 362);
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
            tableLayoutPanel1.Size = new Size(584, 461);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoScroll = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(BtnActualizar, 0, 0);
            tableLayoutPanel2.Controls.Add(BtnEliminar, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(61, 417);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(461, 41);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Anchor = AnchorStyles.None;
            BtnActualizar.Location = new Point(40, 5);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(150, 30);
            BtnActualizar.TabIndex = 0;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = true;
            BtnActualizar.Click += BtnActualizar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Anchor = AnchorStyles.None;
            BtnEliminar.FlatAppearance.BorderColor = Color.Red;
            BtnEliminar.Location = new Point(270, 5);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(150, 30);
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
            BtnRefresh.Location = new Point(528, 3);
            BtnRefresh.Name = "BtnRefresh";
            BtnRefresh.Size = new Size(53, 40);
            BtnRefresh.TabIndex = 3;
            BtnRefresh.Text = "Refrescar";
            BtnRefresh.TextAlign = ContentAlignment.BottomCenter;
            BtnRefresh.UseVisualStyleBackColor = false;
            BtnRefresh.Click += BtnRefresh_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(TxtBuscar, 1, 0);
            tableLayoutPanel3.Controls.Add(BtnBuscar, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(61, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(461, 40);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 7);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 4;
            label1.Text = "Peliculas";
            // 
            // TxtBuscar
            // 
            TxtBuscar.Anchor = AnchorStyles.None;
            TxtBuscar.Location = new Point(156, 8);
            TxtBuscar.MaxLength = 23;
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(147, 23);
            TxtBuscar.TabIndex = 5;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.None;
            BtnBuscar.Cursor = Cursors.Hand;
            BtnBuscar.Location = new Point(327, 7);
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
            PanelPeliculas.Location = new Point(0, 0);
            PanelPeliculas.Name = "PanelPeliculas";
            PanelPeliculas.Size = new Size(584, 461);
            PanelPeliculas.TabIndex = 4;
            // 
            // ListaPeliculas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelPeliculas);
            Name = "ListaPeliculas";
            Size = new Size(584, 461);
            ((System.ComponentModel.ISupportInitialize)DataGridPeliculas).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            PanelPeliculas.ResumeLayout(false);
            ResumeLayout(false);
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
    }
}
