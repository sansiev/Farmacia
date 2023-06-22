namespace FarmaciaUsuari
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgtPro = new System.Windows.Forms.DataGridView();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btndescargar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelF = new System.Windows.Forms.Label();
            this.BuscarPro = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgtpro2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtPro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtpro2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtdocumento);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 60);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 89;
            this.label2.Text = "Telefono:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 87;
            this.label1.Text = "Nombres:";
            // 
            // txtdocumento
            // 
            this.txtdocumento.Location = new System.Drawing.Point(95, 23);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(154, 26);
            this.txtdocumento.TabIndex = 88;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(341, 26);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(144, 26);
            this.txtTel.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre Del Producto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FarmaciaUsuari.Properties.Resources.LogotipoPNG;
            this.pictureBox1.Location = new System.Drawing.Point(621, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // dgtPro
            // 
            this.dgtPro.AllowUserToAddRows = false;
            this.dgtPro.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgtPro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgtPro.ColumnHeadersHeight = 30;
            this.dgtPro.EnableHeadersVisualStyles = false;
            this.dgtPro.GridColor = System.Drawing.Color.DimGray;
            this.dgtPro.Location = new System.Drawing.Point(30, 129);
            this.dgtPro.MultiSelect = false;
            this.dgtPro.Name = "dgtPro";
            this.dgtPro.ReadOnly = true;
            this.dgtPro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgtPro.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgtPro.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgtPro.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgtPro.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgtPro.RowTemplate.Height = 30;
            this.dgtPro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgtPro.Size = new System.Drawing.Size(566, 126);
            this.dgtPro.TabIndex = 95;
            this.dgtPro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproductos_CellContentClick);
            this.dgtPro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproductos_CellContentClick);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnagregar.ForeColor = System.Drawing.Color.White;
            this.btnagregar.Location = new System.Drawing.Point(234, 326);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(131, 29);
            this.btnagregar.TabIndex = 96;
            this.btnagregar.Text = "Agregar Producto";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btndescargar
            // 
            this.btndescargar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btndescargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndescargar.ForeColor = System.Drawing.Color.White;
            this.btndescargar.Location = new System.Drawing.Point(246, 507);
            this.btndescargar.Name = "btndescargar";
            this.btndescargar.Size = new System.Drawing.Size(119, 27);
            this.btndescargar.TabIndex = 97;
            this.btndescargar.Text = "Terminar e Imprimir";
            this.btndescargar.UseVisualStyleBackColor = false;
            this.btndescargar.Click += new System.EventHandler(this.btndescargar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(606, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 98;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(606, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 18);
            this.label7.TabIndex = 99;
            this.label7.Text = "Fecha:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelF
            // 
            this.labelF.AutoSize = true;
            this.labelF.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelF.Location = new System.Drawing.Point(665, 12);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(11, 16);
            this.labelF.TabIndex = 100;
            this.labelF.Text = ".";
            this.labelF.Click += new System.EventHandler(this.labelF_Click);
            // 
            // BuscarPro
            // 
            this.BuscarPro.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BuscarPro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuscarPro.ForeColor = System.Drawing.Color.White;
            this.BuscarPro.Location = new System.Drawing.Point(387, 98);
            this.BuscarPro.Name = "BuscarPro";
            this.BuscarPro.Size = new System.Drawing.Size(110, 25);
            this.BuscarPro.TabIndex = 101;
            this.BuscarPro.Text = "Buscar Producto";
            this.BuscarPro.UseVisualStyleBackColor = false;
            this.BuscarPro.Click += new System.EventHandler(this.BuscarPro_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(249, 103);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(116, 20);
            this.TxtNombre.TabIndex = 90;
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(128, 19);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(91, 20);
            this.txtdescripcion.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 91;
            this.label4.Text = "Cantidad:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(450, 20);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(59, 20);
            this.txtcantidad.TabIndex = 92;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(230, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 91;
            this.label5.Text = "Precio:";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(298, 20);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(59, 20);
            this.txtprecio.TabIndex = 92;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 21);
            this.label8.TabIndex = 90;
            this.label8.Text = "Descripcion";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtprecio);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtcantidad);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtdescripcion);
            this.groupBox2.Location = new System.Drawing.Point(30, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 59);
            this.groupBox2.TabIndex = 92;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle Producto";
            // 
            // dgtpro2
            // 
            this.dgtpro2.AllowUserToAddRows = false;
            this.dgtpro2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgtpro2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgtpro2.ColumnHeadersHeight = 30;
            this.dgtpro2.EnableHeadersVisualStyles = false;
            this.dgtpro2.GridColor = System.Drawing.Color.DimGray;
            this.dgtpro2.Location = new System.Drawing.Point(30, 361);
            this.dgtpro2.MultiSelect = false;
            this.dgtpro2.Name = "dgtpro2";
            this.dgtpro2.ReadOnly = true;
            this.dgtpro2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgtpro2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgtpro2.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgtpro2.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgtpro2.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgtpro2.RowTemplate.Height = 30;
            this.dgtpro2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgtpro2.Size = new System.Drawing.Size(566, 140);
            this.dgtpro2.TabIndex = 102;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(812, 547);
            this.Controls.Add(this.dgtpro2);
            this.Controls.Add(this.BuscarPro);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.labelF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btndescargar);
            this.Controls.Add(this.dgtPro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtPro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtpro2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdocumento;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgtPro;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btndescargar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelF;
        private System.Windows.Forms.Button BuscarPro;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.ErrorProvider Error;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.DataGridView dgtpro2;
    }
}

