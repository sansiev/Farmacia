namespace Farmacia_Proyecto
{
    partial class Productos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Agregar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.texId_Pro = new System.Windows.Forms.TextBox();
            this.texNombre = new System.Windows.Forms.TextBox();
            this.texDescr = new System.Windows.Forms.TextBox();
            this.texExis = new System.Windows.Forms.TextBox();
            this.texPrecio = new System.Windows.Forms.TextBox();
            this.texVencimiento = new System.Windows.Forms.TextBox();
            this.dataProducto = new System.Windows.Forms.DataGridView();
            this.Busqueda = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textbusqueda = new System.Windows.Forms.TextBox();
            this.radioId = new System.Windows.Forms.RadioButton();
            this.radioNombre = new System.Windows.Forms.RadioButton();
            this.radioExis = new System.Windows.Forms.RadioButton();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.errorcito = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelNombrador = new System.Windows.Forms.Panel();
            this.Nombrador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcito)).BeginInit();
            this.panelNombrador.SuspendLayout();
            this.SuspendLayout();
            // 
            // Agregar
            // 
            this.Agregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Agregar.Font = new System.Drawing.Font("Georgia", 10F);
            this.Agregar.Location = new System.Drawing.Point(46, 389);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 30);
            this.Agregar.TabIndex = 0;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = false;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Modificar
            // 
            this.Modificar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modificar.Font = new System.Drawing.Font("Georgia", 10F);
            this.Modificar.Location = new System.Drawing.Point(162, 389);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(85, 30);
            this.Modificar.TabIndex = 1;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = false;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Eliminar.Font = new System.Drawing.Font("Georgia", 10F);
            this.Eliminar.Location = new System.Drawing.Point(46, 447);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 30);
            this.Eliminar.TabIndex = 2;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID_Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Existencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha de vencimiento";
            // 
            // texId_Pro
            // 
            this.texId_Pro.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texId_Pro.Location = new System.Drawing.Point(161, 137);
            this.texId_Pro.Name = "texId_Pro";
            this.texId_Pro.Size = new System.Drawing.Size(100, 22);
            this.texId_Pro.TabIndex = 9;
            // 
            // texNombre
            // 
            this.texNombre.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texNombre.Location = new System.Drawing.Point(162, 178);
            this.texNombre.Name = "texNombre";
            this.texNombre.Size = new System.Drawing.Size(100, 22);
            this.texNombre.TabIndex = 10;
            // 
            // texDescr
            // 
            this.texDescr.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texDescr.Location = new System.Drawing.Point(162, 216);
            this.texDescr.Name = "texDescr";
            this.texDescr.Size = new System.Drawing.Size(100, 22);
            this.texDescr.TabIndex = 11;
            // 
            // texExis
            // 
            this.texExis.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texExis.Location = new System.Drawing.Point(162, 253);
            this.texExis.Name = "texExis";
            this.texExis.Size = new System.Drawing.Size(100, 22);
            this.texExis.TabIndex = 12;
            // 
            // texPrecio
            // 
            this.texPrecio.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texPrecio.Location = new System.Drawing.Point(162, 293);
            this.texPrecio.Name = "texPrecio";
            this.texPrecio.Size = new System.Drawing.Size(100, 22);
            this.texPrecio.TabIndex = 13;
            // 
            // texVencimiento
            // 
            this.texVencimiento.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texVencimiento.Location = new System.Drawing.Point(162, 336);
            this.texVencimiento.Name = "texVencimiento";
            this.texVencimiento.Size = new System.Drawing.Size(100, 22);
            this.texVencimiento.TabIndex = 14;
            // 
            // dataProducto
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProducto.Location = new System.Drawing.Point(273, 181);
            this.dataProducto.Name = "dataProducto";
            this.dataProducto.ReadOnly = true;
            this.dataProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataProducto.Size = new System.Drawing.Size(509, 238);
            this.dataProducto.TabIndex = 15;
            this.dataProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProducto_CellClick);
            this.dataProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProducto_CellContentClick);
            // 
            // Busqueda
            // 
            this.Busqueda.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Busqueda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Busqueda.Font = new System.Drawing.Font("Georgia", 10F);
            this.Busqueda.Location = new System.Drawing.Point(572, 82);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(75, 30);
            this.Busqueda.TabIndex = 16;
            this.Busqueda.Text = "Buscar";
            this.Busqueda.UseVisualStyleBackColor = false;
            this.Busqueda.Click += new System.EventHandler(this.Busqueda_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 10F);
            this.label7.Location = new System.Drawing.Point(292, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Buscar";
            // 
            // textbusqueda
            // 
            this.textbusqueda.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbusqueda.Location = new System.Drawing.Point(349, 86);
            this.textbusqueda.Name = "textbusqueda";
            this.textbusqueda.Size = new System.Drawing.Size(191, 22);
            this.textbusqueda.TabIndex = 18;
            // 
            // radioId
            // 
            this.radioId.AutoSize = true;
            this.radioId.Font = new System.Drawing.Font("Georgia", 10F);
            this.radioId.Location = new System.Drawing.Point(314, 130);
            this.radioId.Name = "radioId";
            this.radioId.Size = new System.Drawing.Size(110, 21);
            this.radioId.TabIndex = 19;
            this.radioId.TabStop = true;
            this.radioId.Text = "ID_Producto";
            this.radioId.UseVisualStyleBackColor = true;
            // 
            // radioNombre
            // 
            this.radioNombre.AutoSize = true;
            this.radioNombre.Font = new System.Drawing.Font("Georgia", 10F);
            this.radioNombre.Location = new System.Drawing.Point(473, 130);
            this.radioNombre.Name = "radioNombre";
            this.radioNombre.Size = new System.Drawing.Size(78, 21);
            this.radioNombre.TabIndex = 20;
            this.radioNombre.TabStop = true;
            this.radioNombre.Text = "Nombre";
            this.radioNombre.UseVisualStyleBackColor = true;
            // 
            // radioExis
            // 
            this.radioExis.AutoSize = true;
            this.radioExis.Font = new System.Drawing.Font("Georgia", 10F);
            this.radioExis.Location = new System.Drawing.Point(597, 130);
            this.radioExis.Name = "radioExis";
            this.radioExis.Size = new System.Drawing.Size(91, 21);
            this.radioExis.TabIndex = 21;
            this.radioExis.TabStop = true;
            this.radioExis.Text = "Existencia";
            this.radioExis.UseVisualStyleBackColor = true;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefrescar.Font = new System.Drawing.Font("Georgia", 10F);
            this.btnRefrescar.Location = new System.Drawing.Point(673, 82);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(82, 30);
            this.btnRefrescar.TabIndex = 22;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Georgia", 10F);
            this.btnLimpiar.Location = new System.Drawing.Point(162, 447);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(85, 30);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // errorcito
            // 
            this.errorcito.ContainerControl = this;
            // 
            // panelNombrador
            // 
            this.panelNombrador.BackColor = System.Drawing.Color.Bisque;
            this.panelNombrador.Controls.Add(this.Nombrador);
            this.panelNombrador.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNombrador.Location = new System.Drawing.Point(0, 0);
            this.panelNombrador.Name = "panelNombrador";
            this.panelNombrador.Size = new System.Drawing.Size(794, 60);
            this.panelNombrador.TabIndex = 24;
            // 
            // Nombrador
            // 
            this.Nombrador.AutoSize = true;
            this.Nombrador.Font = new System.Drawing.Font("Lucida Bright", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombrador.Location = new System.Drawing.Point(306, 15);
            this.Nombrador.Name = "Nombrador";
            this.Nombrador.Size = new System.Drawing.Size(200, 34);
            this.Nombrador.TabIndex = 0;
            this.Nombrador.Text = "- Inventario -";
            this.Nombrador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(794, 512);
            this.Controls.Add(this.panelNombrador);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.radioExis);
            this.Controls.Add(this.radioNombre);
            this.Controls.Add(this.radioId);
            this.Controls.Add(this.textbusqueda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Busqueda);
            this.Controls.Add(this.dataProducto);
            this.Controls.Add(this.texVencimiento);
            this.Controls.Add(this.texPrecio);
            this.Controls.Add(this.texExis);
            this.Controls.Add(this.texDescr);
            this.Controls.Add(this.texNombre);
            this.Controls.Add(this.texId_Pro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcito)).EndInit();
            this.panelNombrador.ResumeLayout(false);
            this.panelNombrador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox texId_Pro;
        private System.Windows.Forms.TextBox texNombre;
        private System.Windows.Forms.TextBox texDescr;
        private System.Windows.Forms.TextBox texExis;
        private System.Windows.Forms.TextBox texPrecio;
        private System.Windows.Forms.TextBox texVencimiento;
        private System.Windows.Forms.DataGridView dataProducto;
        private System.Windows.Forms.Button Busqueda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textbusqueda;
        private System.Windows.Forms.RadioButton radioId;
        private System.Windows.Forms.RadioButton radioNombre;
        private System.Windows.Forms.RadioButton radioExis;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ErrorProvider errorcito;
        private System.Windows.Forms.Panel panelNombrador;
        private System.Windows.Forms.Label Nombrador;
    }
}