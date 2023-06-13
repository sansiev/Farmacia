using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Farmacia_Proyecto
{
    public partial class HistorialVentas : Form
    {
        //SqlConnection conexion = new SqlConnection("Server=DESKTOP-1LQHI27;database=Proyecto_Farmaci;integrated security=true");
        //SqlConnection conexion = new SqlConnection("Server=SANDERSUWU;database=Proyecto_Farmaci;integrated security=true");
        SqlConnection conexion = new SqlConnection("Data Source=SQL5054.site4now.net;Initial Catalog=db_a9a08f_pruebafarmacia;User Id=db_a9a08f_pruebafarmacia_admin;Password=lolita08");


        public HistorialVentas()
        {
            InitializeComponent();
        }
        public void llenar_tabla()
        {
            string consulta = "select * from Ventas";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataVentas.DataSource = dt;
        }
        private void Ventas_Load(object sender, EventArgs e)
        {
            llenar_tabla();

        }

        private void Busqueda_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (Radioid.Checked == false && Radioarti.Checked == false)
            {
                MessageBox.Show("Escoja un metodo de busqueda");
            }
            else
            {
                if (Radioid.Checked == true)
                {
                    string consulta = "SELECT * FROM Ventas WHERE ID_Ventas  =" + texBusqueda.Text + "";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataVentas.DataSource = dt;
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    SqlDataReader lector;
                    lector = comando.ExecuteReader();


                }
                if (Radioarti.Checked == true)
                {
                    string consulta = "SELECT * FROM Ventas WHERE ID_Produc = '" + texBusqueda.Text + "'";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataVentas.DataSource = dt;
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    SqlDataReader lector;
                    lector = comando.ExecuteReader();

                }
            }
            conexion.Close();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            llenar_tabla();
            Radioarti.Checked = false;
            Radioid.Checked = false;
            texBusqueda.Clear();
        }

        private void panelNombrador_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
