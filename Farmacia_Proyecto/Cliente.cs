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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }
        // SqlConnection conexion = new SqlConnection("Server=DESKTOP-1LQHI27;database=Proyecto_Farmaci;integrated security=true");
        SqlConnection conexion = new SqlConnection("Server=SANDERSUWU;database=Proyecto_Farmaci;integrated security=true");
        public bool confirmacion()
        {
            bool ok = true;

            if (txtNom.Text == "")
            {
                ok = false;
                errorcito.SetError(txtNom, "Ingresar Nombre");
            }

            if (txtapellido.Text == "")
            {
                ok = false;
                errorcito.SetError(txtapellido, "Ingresar apellido");
            }

            if (txttelefono.Text == "")
            {
                ok = false;
                errorcito.SetError(txttelefono, "Ingresar Telefono");
            }
            if (textDirec.Text == "")
            {
                ok = false;
                errorcito.SetError(textDirec, "Ingresar Direccion");
            }

            return ok;

        }
        public void limpieza()
        {
            txtNom.Clear();
            txtapellido.Clear();
            txttelefono.Clear();
            textDirec.Clear();
        }
        public void borrarerror()
        {
            errorcito.SetError(txtNom, "");
            errorcito.SetError(txtapellido, "");
            errorcito.SetError(txttelefono, "");
            errorcito.SetError(textDirec, "");
        }
        public void llenar_tabla()
        {
            string consulta = "select * from Cliente";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataClie.DataSource = dt;
        }


        private void Cliente_Load(object sender, EventArgs e)
        {
            llenar_tabla();

        }

        private void dataEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelid.Text = dataClie.SelectedCells[0].Value.ToString();
            txtNom.Text = dataClie.SelectedCells[1].Value.ToString();
            txtapellido.Text = dataClie.SelectedCells[2].Value.ToString();
            textDirec.Text = dataClie.SelectedCells[3].Value.ToString();
            txttelefono.Text = dataClie.SelectedCells[4].Value.ToString();
        }

        private void agregado_Click(object sender, EventArgs e)
        {
            borrarerror();
            if (confirmacion())
            {
                string consulta = "INSERT INTO Cliente (Nombre,Apellido,direccion,telefono) values(@nombre,@apellido,@Direccion,@Telefono)";
                conexion.Open();
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@nombre", txtNom.Text);
                comando.Parameters.AddWithValue("@apellido", txtapellido.Text);
                comando.Parameters.AddWithValue("@Direccion", textDirec.Text);
                comando.Parameters.AddWithValue("@Telefono", txttelefono.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Reguistro agregado");
                llenar_tabla();
                limpieza();
                conexion.Close();
            }
            else
            {
                MessageBox.Show("Ingrese valores");
            }
           
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            borrarerror();
            if (confirmacion())
            {
                string consulta = "Update Cliente  set Nombre = @Nombre, apellido = @Apellido, direccion = @Direccion, telefono = @Telefono where id_cliente = @Id_cliente";
                conexion.Open();
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@id_cliente", labelid.Text);
                comando.Parameters.AddWithValue("@nombre", txtNom.Text);
                comando.Parameters.AddWithValue("@apellido", txtapellido.Text);
                comando.Parameters.AddWithValue("@Direccion", textDirec.Text);
                comando.Parameters.AddWithValue("@Telefono", txttelefono.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro actualizado");
                llenar_tabla();
                limpieza();
                conexion.Close();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente");
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelid.Text = "";
            txtapellido.Clear();
            txtNom.Clear();
            txttelefono.Clear();
            textDirec.Clear();
        }

        private void Busqueda_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (Radioid.Checked == false &&  RadioNom.Checked == false)
            {
                MessageBox.Show("Escoja un metodo de busqueda");
            }
            else
            {
                if (Radioid.Checked == true)
                {
                    string consulta = "SELECT * FROM cliente WHERE ID_Cliente =" +texBusqueda.Text+ "";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataClie.DataSource = dt;
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    SqlDataReader lector;
                    lector = comando.ExecuteReader();
                    

                }
                if (RadioNom.Checked == true)
                {
                    string consulta = "SELECT * FROM cliente WHERE Nombre = '" +texBusqueda.Text+ "'";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dataClie.DataSource = dt;
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    SqlDataReader lector;
                    lector = comando.ExecuteReader();

                }
                
            }
            conexion.Close();
        }

        private void Refresf_Click(object sender, EventArgs e)
        {
            llenar_tabla();
            Radioid.Checked = false;
            RadioNom.Checked = false;  
            texBusqueda.Clear();    
        }
    }
}
