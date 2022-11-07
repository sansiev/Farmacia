namespace Farmacia_Proyecto
{
    partial class Ventas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataVentas = new System.Windows.Forms.DataGridView();
            this.texBusqueda = new System.Windows.Forms.TextBox();
            this.Busqueda = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.Radioid = new System.Windows.Forms.RadioButton();
            this.Radioarti = new System.Windows.Forms.RadioButton();
            this.panelNombrador = new System.Windows.Forms.Panel();
            this.Nombrador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataVentas)).BeginInit();
            this.panelNombrador.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataVentas
            // 
            this.dataVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVentas.Location = new System.Drawing.Point(68, 146);
            this.dataVentas.Name = "dataVentas";
            this.dataVentas.ReadOnly = true;
            this.dataVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataVentas.Size = new System.Drawing.Size(544, 234);
            this.dataVentas.TabIndex = 0;
            // 
            // texBusqueda
            // 
            this.texBusqueda.Location = new System.Drawing.Point(120, 88);
            this.texBusqueda.Name = "texBusqueda";
            this.texBusqueda.Size = new System.Drawing.Size(177, 20);
            this.texBusqueda.TabIndex = 1;
            // 
            // Busqueda
            // 
            this.Busqueda.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Busqueda.Location = new System.Drawing.Point(323, 88);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(75, 23);
            this.Busqueda.TabIndex = 2;
            this.Busqueda.Text = "Busqueda";
            this.Busqueda.UseVisualStyleBackColor = true;
            this.Busqueda.Click += new System.EventHandler(this.Busqueda_Click);
            // 
            // Refresh
            // 
            this.Refresh.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.Location = new System.Drawing.Point(416, 88);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 3;
            this.Refresh.Text = "Refrescar";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Radioid
            // 
            this.Radioid.AutoSize = true;
            this.Radioid.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radioid.Location = new System.Drawing.Point(230, 123);
            this.Radioid.Name = "Radioid";
            this.Radioid.Size = new System.Drawing.Size(37, 18);
            this.Radioid.TabIndex = 4;
            this.Radioid.TabStop = true;
            this.Radioid.Text = "ID";
            this.Radioid.UseVisualStyleBackColor = true;
            // 
            // Radioarti
            // 
            this.Radioarti.AutoSize = true;
            this.Radioarti.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radioarti.Location = new System.Drawing.Point(290, 123);
            this.Radioarti.Name = "Radioarti";
            this.Radioarti.Size = new System.Drawing.Size(91, 18);
            this.Radioarti.TabIndex = 5;
            this.Radioarti.TabStop = true;
            this.Radioarti.Text = "ID producto";
            this.Radioarti.UseVisualStyleBackColor = true;
            // 
            // panelNombrador
            // 
            this.panelNombrador.BackColor = System.Drawing.Color.Turquoise;
            this.panelNombrador.Controls.Add(this.Nombrador);
            this.panelNombrador.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNombrador.Location = new System.Drawing.Point(0, 0);
            this.panelNombrador.Name = "panelNombrador";
            this.panelNombrador.Size = new System.Drawing.Size(690, 60);
            this.panelNombrador.TabIndex = 25;
            // 
            // Nombrador
            // 
            this.Nombrador.AutoSize = true;
            this.Nombrador.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombrador.Location = new System.Drawing.Point(187, 9);
            this.Nombrador.Name = "Nombrador";
            this.Nombrador.Size = new System.Drawing.Size(304, 31);
            this.Nombrador.TabIndex = 0;
            this.Nombrador.Text = "-Historial de ventas-";
            this.Nombrador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(690, 383);
            this.Controls.Add(this.panelNombrador);
            this.Controls.Add(this.Radioarti);
            this.Controls.Add(this.Radioid);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Busqueda);
            this.Controls.Add(this.texBusqueda);
            this.Controls.Add(this.dataVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataVentas)).EndInit();
            this.panelNombrador.ResumeLayout(false);
            this.panelNombrador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataVentas;
        private System.Windows.Forms.TextBox texBusqueda;
        private System.Windows.Forms.Button Busqueda;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.RadioButton Radioid;
        private System.Windows.Forms.RadioButton Radioarti;
        private System.Windows.Forms.Panel panelNombrador;
        private System.Windows.Forms.Label Nombrador;
    }
}