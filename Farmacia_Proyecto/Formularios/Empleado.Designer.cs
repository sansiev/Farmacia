namespace Farmacia_Proyecto
{
    partial class Empleado
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
            this.dataEmp = new System.Windows.Forms.DataGridView();
            this.CombCar = new System.Windows.Forms.ComboBox();
            this.CombEsta = new System.Windows.Forms.ComboBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.agregado = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.labelid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorcito = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelNombrador = new System.Windows.Forms.Panel();
            this.Nombrador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcito)).BeginInit();
            this.panelNombrador.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataEmp
            // 
            this.dataEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmp.Location = new System.Drawing.Point(263, 146);
            this.dataEmp.Name = "dataEmp";
            this.dataEmp.ReadOnly = true;
            this.dataEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataEmp.Size = new System.Drawing.Size(484, 221);
            this.dataEmp.TabIndex = 0;
            this.dataEmp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEmp_CellClick);
            // 
            // CombCar
            // 
            this.CombCar.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CombCar.FormattingEnabled = true;
            this.CombCar.Items.AddRange(new object[] {
            "Gerente",
            "Trabajador"});
            this.CombCar.Location = new System.Drawing.Point(95, 270);
            this.CombCar.Name = "CombCar";
            this.CombCar.Size = new System.Drawing.Size(121, 26);
            this.CombCar.TabIndex = 1;
            // 
            // CombEsta
            // 
            this.CombEsta.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CombEsta.FormattingEnabled = true;
            this.CombEsta.Items.AddRange(new object[] {
            "Activo",
            "Despedido"});
            this.CombEsta.Location = new System.Drawing.Point(95, 318);
            this.CombEsta.Name = "CombEsta";
            this.CombEsta.Size = new System.Drawing.Size(121, 26);
            this.CombEsta.TabIndex = 2;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(95, 146);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(121, 25);
            this.txtNom.TabIndex = 3;
            // 
            // txtapellido
            // 
            this.txtapellido.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellido.Location = new System.Drawing.Point(95, 187);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(121, 25);
            this.txtapellido.TabIndex = 4;
            // 
            // txttelefono
            // 
            this.txttelefono.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.Location = new System.Drawing.Point(95, 229);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(121, 25);
            this.txttelefono.TabIndex = 5;
            // 
            // agregado
            // 
            this.agregado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.agregado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.agregado.Font = new System.Drawing.Font("Georgia", 10F);
            this.agregado.Location = new System.Drawing.Point(69, 369);
            this.agregado.Name = "agregado";
            this.agregado.Size = new System.Drawing.Size(120, 44);
            this.agregado.TabIndex = 6;
            this.agregado.Text = "Agregar trabajador";
            this.agregado.UseVisualStyleBackColor = false;
            this.agregado.Click += new System.EventHandler(this.agregado_Click);
            // 
            // Modificar
            // 
            this.Modificar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modificar.Font = new System.Drawing.Font("Georgia", 10F);
            this.Modificar.Location = new System.Drawing.Point(83, 432);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(95, 39);
            this.Modificar.TabIndex = 7;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = false;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.Location = new System.Drawing.Point(133, 109);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(32, 18);
            this.labelid.TabIndex = 8;
            this.labelid.Text = "----";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cargo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Estatus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID Empleado";
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
            this.panelNombrador.TabIndex = 25;
            // 
            // Nombrador
            // 
            this.Nombrador.AutoSize = true;
            this.Nombrador.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombrador.Location = new System.Drawing.Point(306, 14);
            this.Nombrador.Name = "Nombrador";
            this.Nombrador.Size = new System.Drawing.Size(153, 31);
            this.Nombrador.TabIndex = 0;
            this.Nombrador.Text = "- Personal -";
            this.Nombrador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(794, 512);
            this.Controls.Add(this.panelNombrador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.agregado);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.CombEsta);
            this.Controls.Add(this.CombCar);
            this.Controls.Add(this.dataEmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorcito)).EndInit();
            this.panelNombrador.ResumeLayout(false);
            this.panelNombrador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataEmp;
        private System.Windows.Forms.ComboBox CombCar;
        private System.Windows.Forms.ComboBox CombEsta;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Button agregado;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorcito;
        private System.Windows.Forms.Panel panelNombrador;
        private System.Windows.Forms.Label Nombrador;
    }
}