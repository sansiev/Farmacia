using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaUsuari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("Data Source=SQL5054.site4now.net;Initial Catalog=db_a9a08f_pruebafarmacia;User Id=db_a9a08f_pruebafarmacia_admin;Password=lolita08");
        private void dgvproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtdescripcion.Text =dgtPro.SelectedCells[2].Value.ToString();
            txtprecio.Text = dgtPro.SelectedCells[4].Value.ToString();
        }

        public void llenar_tabla()
        {
            string consulta = "select * from FacturasClientes";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgtpro2.DataSource = dt;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            borrarerror();
            if (confirmacion())
            {
                string consulta = "INSERT INTO FacturasClientes (Nombrepro,NombreCliente,precio,Fecha,descripcion,cantidad) values(@nombrepro,@nombrecli,@prec,@fecha,@descripcion,@cantidad)";
                conexion.Open();
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@nombrePro", TxtNombre.Text);
                comando.Parameters.AddWithValue("@nombrecli", txtdocumento.Text);
                comando.Parameters.AddWithValue("@prec", txtprecio.Text);
                comando.Parameters.AddWithValue("@fecha", SqlDbType.Date);
                comando.Parameters.AddWithValue("@descripcion", txtdescripcion.Text);
                comando.Parameters.AddWithValue("@cantidad", txtcantidad.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Reguistro agregado");
                llenar_tabla();
                Limpieza();
                conexion.Close();

            }
            else
                MessageBox.Show("Ingrese valores");




            //int indice_fila = dtgPro.Rows.Add();
            //DataGridViewRow row = dtgPro.Rows[indice_fila];

            //row.Cells["Cantidad"].Value = txtcantidad.Text;
            //row.Cells["Descripcion"].Value = txtdescripcion.Text;
            //row.Cells["PrecioUnitario"].Value = txtprecio.Text;
            //row.Cells["Importe"].Value = decimal.Parse(txtcantidad.Text) * decimal.Parse(txtprecio.Text);


        }
        public void Limpieza()
        {
            TxtNombre.Clear();
            txtdescripcion.Clear();
            txtcantidad.Clear();
            txtprecio.Clear();
       
            txtdocumento.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime f = DateTime.Today;
            labelF.Text = f.ToShortDateString();

            string consulta = "select * from FacturasClientes";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgtpro2.DataSource = dt;
        }

        private void btndescargar_Click(object sender, EventArgs e)
        {

        }

        private void labelF_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BuscarPro_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "SELECT * FROM Producto WHERE Nombre ='" + TxtNombre.Text + "'";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dgtPro.DataSource = dt;
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            conexion.Close();

            


        }
        public bool confirmacion()
        {
            bool ok = true;

            if (TxtNombre.Text == "")
            {
                ok = false;
                Error.SetError(TxtNombre, "Ingresar ID");
            }   

            if (txtprecio.Text == "")
            {
                ok = false;
                Error.SetError(txtprecio, "Ingresar ID");
            }

            if (txtdescripcion.Text == "")
            {
                ok = false;
                Error.SetError(txtdescripcion, "Ingresar ID");
            }

           

            if (txtcantidad.Text == "")
            {
                ok = false;
                Error.SetError(txtcantidad, "Ingrese la cantidad a comprar");
            }

            return ok;

        }
        public void borrarerror()
        {
            Error.SetError(txtcantidad, "");
            Error.SetError(txtdescripcion, "");
            Error.SetError(txtprecio, "");
            Error.SetError(TxtNombre, "");
            Error.SetError(txtcantidad, "");
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
