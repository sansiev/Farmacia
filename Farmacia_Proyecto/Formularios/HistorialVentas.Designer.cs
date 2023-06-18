namespace Farmacia_Proyecto
{
    partial class HistorialVentas
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
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataVentas)).BeginInit();
            this.panelNombrador.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataVentas
            // 
            this.dataVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVentas.Location = new System.Drawing.Point(183, 187);
            this.dataVentas.Name = "dataVentas";
            this.dataVentas.ReadOnly = true;
            this.dataVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataVentas.Size = new System.Drawing.Size(478, 234);
            this.dataVentas.TabIndex = 0;
            // 
            // texBusqueda
            // 
            this.texBusqueda.Font = new System.Drawing.Font("Georgia", 10F);
            this.texBusqueda.Location = new System.Drawing.Point(262, 100);
            this.texBusqueda.Name = "texBusqueda";
            this.texBusqueda.Size = new System.Drawing.Size(177, 23);
            this.texBusqueda.TabIndex = 1;
            // 
            // Busqueda
            // 
            this.Busqueda.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Busqueda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Busqueda.Font = new System.Drawing.Font("Georgia", 10F);
            this.Busqueda.Location = new System.Drawing.Point(463, 95);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(89, 33);
            this.Busqueda.TabIndex = 2;
            this.Busqueda.Text = "Busqueda";
            this.Busqueda.UseVisualStyleBackColor = false;
            this.Busqueda.Click += new System.EventHandler(this.Busqueda_Click);
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Refresh.Font = new System.Drawing.Font("Georgia", 10F);
            this.Refresh.Location = new System.Drawing.Point(576, 95);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(85, 33);
            this.Refresh.TabIndex = 3;
            this.Refresh.Text = "Refrescar";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Radioid
            // 
            this.Radioid.AutoSize = true;
            this.Radioid.Font = new System.Drawing.Font("Georgia", 10F);
            this.Radioid.Location = new System.Drawing.Point(301, 145);
            this.Radioid.Name = "Radioid";
            this.Radioid.Size = new System.Drawing.Size(88, 21);
            this.Radioid.TabIndex = 4;
            this.Radioid.TabStop = true;
            this.Radioid.Text = "ID_Venta";
            this.Radioid.UseVisualStyleBackColor = true;
            // 
            // Radioarti
            // 
            this.Radioarti.AutoSize = true;
            this.Radioarti.Font = new System.Drawing.Font("Georgia", 10F);
            this.Radioarti.Location = new System.Drawing.Point(423, 145);
            this.Radioarti.Name = "Radioarti";
            this.Radioarti.Size = new System.Drawing.Size(103, 21);
            this.Radioarti.TabIndex = 5;
            this.Radioarti.TabStop = true;
            this.Radioarti.Text = "ID producto";
            this.Radioarti.UseVisualStyleBackColor = true;
            // 
            // panelNombrador
            // 
            this.panelNombrador.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelNombrador.Controls.Add(this.Nombrador);
            this.panelNombrador.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNombrador.Location = new System.Drawing.Point(0, 0);
            this.panelNombrador.Name = "panelNombrador";
            this.panelNombrador.Size = new System.Drawing.Size(794, 60);
            this.panelNombrador.TabIndex = 25;
            this.panelNombrador.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNombrador_Paint);
            // 
            // Nombrador
            // 
            this.Nombrador.AutoSize = true;
            this.Nombrador.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombrador.Location = new System.Drawing.Point(273, 16);
            this.Nombrador.Name = "Nombrador";
            this.Nombrador.Size = new System.Drawing.Size(280, 31);
            this.Nombrador.TabIndex = 0;
            this.Nombrador.Text = "- Historial de ventas -";
            this.Nombrador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 10F);
            this.label7.Location = new System.Drawing.Point(205, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Buscar";
            // 
            // HistorialVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(794, 512);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panelNombrador);
            this.Controls.Add(this.Radioarti);
            this.Controls.Add(this.Radioid);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Busqueda);
            this.Controls.Add(this.texBusqueda);
            this.Controls.Add(this.dataVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistorialVentas";
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
        private System.Windows.Forms.Label label7;
    }
}