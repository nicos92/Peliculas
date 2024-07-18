namespace Peliculas
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
            panel1 = new Panel();
            PanelVistas = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            BtnIngresar = new Button();
            BtnVerTodas = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(PanelVistas);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 461);
            panel1.TabIndex = 0;
            // 
            // PanelVistas
            // 
            PanelVistas.Dock = DockStyle.Fill;
            PanelVistas.Location = new Point(200, 0);
            PanelVistas.Name = "PanelVistas";
            PanelVistas.Size = new Size(584, 461);
            PanelVistas.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(BtnIngresar, 0, 1);
            tableLayoutPanel1.Controls.Add(BtnVerTodas, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.7058792F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.705883F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.705883F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.705883F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 41.17647F));
            tableLayoutPanel1.Size = new Size(200, 461);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // BtnIngresar
            // 
            BtnIngresar.Dock = DockStyle.Fill;
            BtnIngresar.FlatAppearance.BorderSize = 3;
            BtnIngresar.Font = new Font("Segoe UI", 12F);
            BtnIngresar.Location = new Point(3, 70);
            BtnIngresar.Name = "BtnIngresar";
            BtnIngresar.Size = new Size(194, 61);
            BtnIngresar.TabIndex = 1;
            BtnIngresar.Text = "Ingreso";
            BtnIngresar.UseVisualStyleBackColor = true;
            BtnIngresar.Click += BtnIngresar_Click;
            // 
            // BtnVerTodas
            // 
            BtnVerTodas.Dock = DockStyle.Fill;
            BtnVerTodas.FlatAppearance.BorderSize = 3;
            BtnVerTodas.Font = new Font("Segoe UI", 12F);
            BtnVerTodas.Location = new Point(3, 3);
            BtnVerTodas.Name = "BtnVerTodas";
            BtnVerTodas.Size = new Size(194, 61);
            BtnVerTodas.TabIndex = 0;
            BtnVerTodas.Text = "Peliculas";
            BtnVerTodas.UseVisualStyleBackColor = true;
            BtnVerTodas.Click += BtnVerTodas_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Peliculas";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button BtnIngresar;
        private Button BtnVerTodas;
        private Panel PanelVistas;
    }
}
