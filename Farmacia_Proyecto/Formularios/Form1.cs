using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia_Proyecto
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
private void abrirformhijo(object formhijo)
        {
            if (this.Panelcontenedor.Controls.Count > 0)
                this.Panelcontenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Panelcontenedor.Controls.Add(fh);
            this.Panelcontenedor.Tag=fh;
            fh.Show();
        }

        private void btn_Producto_Click(object sender, EventArgs e)
        {
            abrirformhijo(new Productos());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            abrirformhijo(new Ventas());
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            abrirformhijo(new Cliente());
        }

        private void BtnEmpleado_Click(object sender, EventArgs e)
        {
            abrirformhijo(new Empleado());
        }

        private void Logo_Click(object sender, EventArgs e)
        {
           
        }

        private void VentaRea_Click(object sender, EventArgs e)
        {
            abrirformhijo(new VentasR());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        

            
        }
    }
}
