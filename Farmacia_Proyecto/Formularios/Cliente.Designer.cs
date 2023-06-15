namespace Farmacia_Proyecto
{
    partial class Cliente
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.Modificar = new System.Windows.Forms.Button();
            this.agregado = new System.Windows.Forms.Button();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.dataClie = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textDirec = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.RadioNom = new System.Windows.Forms.RadioButton();
            this.Radioid = new System.Windows.Forms.RadioButton();
            this.texBusqueda = new System.Windows.Forms.TextBox();
            this.Busqueda = new System.Windows.Forms.Button();
            this.Refresf = new System.Windows.Forms.Button();
            this.errorcito = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelNombrador = new System.Windows.Forms.Panel();
            this.Nombrador = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataClie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcito)).BeginInit();
            this.panelNombrador.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nombre";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.Location = new System.Drawing.Point(106, 155);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(32, 18);
            this.labelid.TabIndex = 22;
            this.labelid.Text = "----";
            // 
            // Modificar
            // 
            this.Modificar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modificar.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar.Location = new System.Drawing.Point(78, 409);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(91, 27);
            this.Modificar.TabIndex = 21;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = false;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // agregado
            // 
            this.agregado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.agregado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.agregado.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregado.Location = new System.Drawing.Point(67, 367);
            this.agregado.Name = "agregado";
            this.agregado.Size = new System.Drawing.Size(111, 29);
            this.agregado.TabIndex = 20;
            this.agregado.Text = "Agregar cliente";
            this.agregado.UseVisualStyleBackColor = false;
            this.agregado.Click += new System.EventHandler(this.agregado_Click);
            // 
            // txttelefono
            // 
            this.txttelefono.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.Location = new System.Drawing.Point(84, 329);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 25);
            this.txttelefono.TabIndex = 19;
            // 
            // txtapellido
            // 
            this.txtapellido.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido.Location = new System.Drawing.Point(84, 238);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 25);
            this.txtapellido.TabIndex = 18;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(84, 190);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 25);
            this.txtNom.TabIndex = 17;
            // 
            // dataClie
            // 
            this.dataClie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClie.Location = new System.Drawing.Point(208, 172);
            this.dataClie.Name = "dataClie";
            this.dataClie.ReadOnly = true;
            this.dataClie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataClie.Size = new System.Drawing.Size(574, 274);
            this.dataClie.TabIndex = 14;
            this.dataClie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEmp_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Direccion";
            // 
            // textDirec
            // 
            this.textDirec.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDirec.Location = new System.Drawing.Point(84, 283);
            this.textDirec.Name = "textDirec";
            this.textDirec.Size = new System.Drawing.Size(100, 25);
            this.textDirec.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(84, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 29;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "ID Cliente";
            // 
            // RadioNom
            // 
            this.RadioNom.AutoSize = true;
            this.RadioNom.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioNom.Location = new System.Drawing.Point(544, 134);
            this.RadioNom.Name = "RadioNom";
            this.RadioNom.Size = new System.Drawing.Size(71, 18);
            this.RadioNom.TabIndex = 31;
            this.RadioNom.TabStop = true;
            this.RadioNom.Text = "Nombre";
            this.RadioNom.UseVisualStyleBackColor = true;
            // 
            // Radioid
            // 
            this.Radioid.AutoSize = true;
            this.Radioid.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radioid.Location = new System.Drawing.Point(383, 134);
            this.Radioid.Name = "Radioid";
            this.Radioid.Size = new System.Drawing.Size(85, 18);
            this.Radioid.TabIndex = 32;
            this.Radioid.TabStop = true;
            this.Radioid.Text = "ID_Cliente";
            this.Radioid.UseVisualStyleBackColor = true;
            // 
            // texBusqueda
            // 
            this.texBusqueda.Location = new System.Drawing.Point(361, 89);
            this.texBusqueda.Name = "texBusqueda";
            this.texBusqueda.Size = new System.Drawing.Size(181, 20);
            this.texBusqueda.TabIndex = 33;
            // 
            // Busqueda
            // 
            this.Busqueda.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Busqueda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Busqueda.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Busqueda.Location = new System.Drawing.Point(569, 84);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(75, 26);
            this.Busqueda.TabIndex = 34;
            this.Busqueda.Text = "Buscar";
            this.Busqueda.UseVisualStyleBackColor = false;
            this.Busqueda.Click += new System.EventHandler(this.Busqueda_Click);
            // 
            // Refresf
            // 
            this.Refresf.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Refresf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Refresf.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresf.Location = new System.Drawing.Point(659, 84);
            this.Refresf.Name = "Refresf";
            this.Refresf.Size = new System.Drawing.Size(80, 26);
            this.Refresf.TabIndex = 35;
            this.Refresf.Text = "Refrescar";
            this.Refresf.UseVisualStyleBackColor = false;
            this.Refresf.Click += new System.EventHandler(this.Refresf_Click);
            // 
            // errorcito
            // 
            this.errorcito.ContainerControl = this;
            // 
            // panelNombrador
            // 
            this.panelNombrador.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelNombrador.Controls.Add(this.Nombrador);
            this.panelNombrador.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNombrador.Location = new System.Drawing.Point(0, 0);
            this.panelNombrador.Name = "panelNombrador";
            this.panelNombrador.Size = new System.Drawing.Size(794, 60);
            this.panelNombrador.TabIndex = 36;
            // 
            // Nombrador
            // 
            this.Nombrador.AutoSize = true;
            this.Nombrador.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombrador.Location = new System.Drawing.Point(270, 16);
            this.Nombrador.Name = "Nombrador";
            this.Nombrador.Size = new System.Drawing.Size(283, 31);
            this.Nombrador.TabIndex = 0;
            this.Nombrador.Text = "- Registro de clientes -";
            this.Nombrador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(301, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 37;
            this.label6.Text = "Buscar";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(794, 512);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelNombrador);
            this.Controls.Add(this.Refresf);
            this.Controls.Add(this.Busqueda);
            this.Controls.Add(this.texBusqueda);
            this.Controls.Add(this.Radioid);
            this.Controls.Add(this.RadioNom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textDirec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.agregado);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.dataClie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataClie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcito)).EndInit();
            this.panelNombrador.ResumeLayout(false);
            this.panelNombrador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button agregado;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.DataGridView dataClie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textDirec;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton RadioNom;
        private System.Windows.Forms.RadioButton Radioid;
        private System.Windows.Forms.TextBox texBusqueda;
        private System.Windows.Forms.Button Busqueda;
        private System.Windows.Forms.Button Refresf;
        private System.Windows.Forms.ErrorProvider errorcito;
        private System.Windows.Forms.Panel panelNombrador;
        private System.Windows.Forms.Label Nombrador;
        private System.Windows.Forms.Label label6;
    }
}