﻿namespace Farmacia_Proyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtCerrar = new System.Windows.Forms.Button();
            this.VentaRea = new System.Windows.Forms.Button();
            this.BtnEmpleado = new System.Windows.Forms.Button();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btn_Producto = new System.Windows.Forms.Button();
            this.ContenedorLogo = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Panelcontenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ContenedorLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.Panelcontenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(156)))), ((int)(((byte)(232)))));
            this.PanelMenu.Controls.Add(this.panel1);
            this.PanelMenu.Controls.Add(this.VentaRea);
            this.PanelMenu.Controls.Add(this.BtnEmpleado);
            this.PanelMenu.Controls.Add(this.BtnCliente);
            this.PanelMenu.Controls.Add(this.btnVentas);
            this.PanelMenu.Controls.Add(this.btn_Producto);
            this.PanelMenu.Controls.Add(this.ContenedorLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(200, 512);
            this.PanelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtCerrar);
            this.panel1.Location = new System.Drawing.Point(0, 473);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 39);
            this.panel1.TabIndex = 7;
            // 
            // BtCerrar
            // 
            this.BtCerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtCerrar.FlatAppearance.BorderSize = 0;
            this.BtCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCerrar.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCerrar.Location = new System.Drawing.Point(0, 0);
            this.BtCerrar.Name = "BtCerrar";
            this.BtCerrar.Size = new System.Drawing.Size(200, 40);
            this.BtCerrar.TabIndex = 7;
            this.BtCerrar.Text = "Cerrar Programa";
            this.BtCerrar.UseVisualStyleBackColor = true;
            this.BtCerrar.Click += new System.EventHandler(this.BtCerrar_Click_1);
            // 
            // VentaRea
            // 
            this.VentaRea.Dock = System.Windows.Forms.DockStyle.Top;
            this.VentaRea.FlatAppearance.BorderSize = 0;
            this.VentaRea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VentaRea.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentaRea.Location = new System.Drawing.Point(0, 298);
            this.VentaRea.Name = "VentaRea";
            this.VentaRea.Size = new System.Drawing.Size(200, 57);
            this.VentaRea.TabIndex = 5;
            this.VentaRea.Text = "Realizar venta";
            this.VentaRea.UseVisualStyleBackColor = true;
            this.VentaRea.Click += new System.EventHandler(this.VentaRea_Click);
            // 
            // BtnEmpleado
            // 
            this.BtnEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEmpleado.FlatAppearance.BorderSize = 0;
            this.BtnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpleado.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpleado.Location = new System.Drawing.Point(0, 247);
            this.BtnEmpleado.Name = "BtnEmpleado";
            this.BtnEmpleado.Size = new System.Drawing.Size(200, 51);
            this.BtnEmpleado.TabIndex = 4;
            this.BtnEmpleado.Text = "Empleado";
            this.BtnEmpleado.UseVisualStyleBackColor = true;
            this.BtnEmpleado.Click += new System.EventHandler(this.BtnEmpleado_Click);
            // 
            // BtnCliente
            // 
            this.BtnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCliente.FlatAppearance.BorderSize = 0;
            this.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCliente.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente.Location = new System.Drawing.Point(0, 191);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(200, 56);
            this.BtnCliente.TabIndex = 3;
            this.BtnCliente.Text = "Cliente";
            this.BtnCliente.UseVisualStyleBackColor = true;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Location = new System.Drawing.Point(0, 130);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(200, 61);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "Historial de Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btn_Producto
            // 
            this.btn_Producto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Producto.FlatAppearance.BorderSize = 0;
            this.btn_Producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Producto.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Producto.Location = new System.Drawing.Point(0, 75);
            this.btn_Producto.Name = "btn_Producto";
            this.btn_Producto.Size = new System.Drawing.Size(200, 55);
            this.btn_Producto.TabIndex = 1;
            this.btn_Producto.Text = "Inventario";
            this.btn_Producto.UseVisualStyleBackColor = true;
            this.btn_Producto.Click += new System.EventHandler(this.btn_Producto_Click);
            // 
            // ContenedorLogo
            // 
            this.ContenedorLogo.Controls.Add(this.Logo);
            this.ContenedorLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContenedorLogo.Location = new System.Drawing.Point(0, 0);
            this.ContenedorLogo.Name = "ContenedorLogo";
            this.ContenedorLogo.Size = new System.Drawing.Size(200, 75);
            this.ContenedorLogo.TabIndex = 0;
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(30, 6);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(138, 66);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // Panelcontenedor
            // 
            this.Panelcontenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Panelcontenedor.Controls.Add(this.pictureBox1);
            this.Panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panelcontenedor.Location = new System.Drawing.Point(200, 0);
            this.Panelcontenedor.Name = "Panelcontenedor";
            this.Panelcontenedor.Size = new System.Drawing.Size(794, 512);
            this.Panelcontenedor.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(263, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 512);
            this.Controls.Add(this.Panelcontenedor);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Sistema de Facturacion e Inventario \"Farmacia Lolita\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ContenedorLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.Panelcontenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button btn_Producto;
        private System.Windows.Forms.Panel ContenedorLogo;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel Panelcontenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button BtnEmpleado;
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Button VentaRea;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtCerrar;
    }
}

