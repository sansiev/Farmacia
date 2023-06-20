using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Farmacia_Proyecto
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }
        //SqlConnection conexion = new SqlConnection("Server = DESKTOP-1LQHI27;database=Proyecto_Farmaci;integrated security=true");
        //SqlConnection conexion = new SqlConnection("Server=SANDERSUWU;database=Proyecto_Farmaci;integrated security=true");
        SqlConnection conexion = new SqlConnection("Data Source=SQL5054.site4now.net;Initial Catalog=db_a9a08f_pruebafarmacia;User Id=db_a9a08f_pruebafarmacia_admin;Password=lolita08");

        bool confirmacion()
        {
            bool ok = true;

            if (texId_Pro.Text == "")
            {
                ok = false;
                errorcito.SetError(texId_Pro, "Ingresar ID");
            }
              
            if (texNombre.Text == "")
            {
                ok = false;
                errorcito.SetError(texNombre, "Ingresar Nombre");
            }
        
            if (texDescr.Text == "")
            {
                ok = false;
                errorcito.SetError(texDescr, "Ingresar descripcion");
            }
                        
            if (texExis.Text == "")
            {
                ok = false;
                errorcito.SetError(texExis, "Ingresar existencia");
            }
            
            if (texPrecio.Text == "")
            {
                ok = false;
                errorcito.SetError(texPrecio, "Ingresar precio");
            }
           
            if (texVencimiento.Text == "")
            {
                ok = false;
                errorcito.SetError(texVencimiento, "Ingresar vencimiento");
            }
           
            return ok;

        }
        
        public void borrarerror()
        {
            errorcito.SetError(texId_Pro,"");
            errorcito.SetError(texNombre, "");
            errorcito.SetError(texDescr, "");
            errorcito.SetError(texExis, "");
            errorcito.SetError(texPrecio, "");
            errorcito.SetError(texVencimiento, "");
        }
        
        public void llenar_tabla()
        {
            string consulta = "select * from Producto";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataProducto.DataSource = dt;
        }
        public void Limpieza()
        {
            texId_Pro.Clear();
            texNombre.Clear();
            texDescr.Clear();
            texExis.Clear();
            texPrecio.Clear();
            texVencimiento.Clear();
            texId_Pro.Focus();
        }
        
        private void Productos_Load(object sender, EventArgs e)
        {
            string consulta = "select * from Producto";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta,conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataProducto.DataSource = dt;
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            borrarerror();
            if (confirmacion())
            {
                string consulta = "INSERT INTO Producto (ID_Prod,Nombre,Descripcion,Existencia,Precio,FechaVenci) values(@id,@nombre,@descripcion,@existencia,@precio,@fechaVen)";
                conexion.Open();
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@id", texId_Pro.Text);
                comando.Parameters.AddWithValue("@nombre", texNombre.Text);
                comando.Parameters.AddWithValue("@descripcion", texDescr.Text);
                comando.Parameters.AddWithValue("@existencia", texExis.Text);
                comando.Parameters.AddWithValue("@precio", texPrecio.Text);
                comando.Parameters.AddWithValue("@fechaVen", texVencimiento.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Reguistro agregado");
                llenar_tabla();
                Limpieza();
                conexion.Close();

            }
            else
                MessageBox.Show("Ingrese valores");
           
        }

        private void dataProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            texId_Pro.Text = dataProducto.SelectedCells[0].Value.ToString();
            texNombre.Text = dataProducto.SelectedCells[1].Value.ToString();
            texDescr.Text = dataProducto.SelectedCells[2].Value.ToString();
            texExis.Text = dataProducto.SelectedCells[3].Value.ToString();
            texPrecio.Text = dataProducto.SelectedCells[4].Value.ToString();
            texVencimiento.Text = dataProducto.SelectedCells[5].Value.ToString();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            bool ok = true;
            borrarerror();
            if (texId_Pro.Text == "")
            {
                ok = false;
                errorcito.SetError(texId_Pro, "Ingresar ID");
            }
            else
            {
                conexion.Open();
                string consulta = "DELETE FROM Producto WHERE ID_Prod = @Id ";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Id", texId_Pro.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Reguistro eleminado");
                llenar_tabla();
                Limpieza();
                conexion.Close();

            }
          
        }

        private void Modificar_Click(object sender, EventArgs e)
        {

            bool ok = true;
            borrarerror();
            if (texId_Pro.Text == "")
            {
                ok = false;
                errorcito.SetError(texId_Pro, "Ingresar ID");
            }
            else
            {
                string consulta = "UPDATE Producto SET Nombre = @nombre ,Descripcion= @descripcion,Existencia= @existencia,Precio= @precio,FechaVenci= @fechaVen WHERE ID_Prod=@id";
                conexion.Open();
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@id", texId_Pro.Text);
                comando.Parameters.AddWithValue("@nombre", texNombre.Text);
                comando.Parameters.AddWithValue("@descripcion", texDescr.Text);
                comando.Parameters.AddWithValue("@existencia", texExis.Text);
                comando.Parameters.AddWithValue("@precio", texPrecio.Text);
                comando.Parameters.AddWithValue("@fechaVen", texVencimiento.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro actualizado");
                llenar_tabla();
                Limpieza();
                conexion.Close();
            }
           
        }

        private void Busqueda_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if(radioNombre.Checked==false && radioId.Checked==false && radioExis.Checked==false)
            {
                MessageBox.Show("Escoja un metodo de busqueda");
            }
            else { 
            if (radioId.Checked == true)
            {   
                string consulta = "SELECT * FROM Producto WHERE ID_Prod='" + textbusqueda.Text + "'";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataProducto.DataSource = dt;
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader lector;
                lector = comando.ExecuteReader();
               
            }
            if (radioNombre.Checked == true)
            {
                string consulta = "SELECT * FROM Producto WHERE Nombre = '" + textbusqueda.Text + "'";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataProducto.DataSource = dt;
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader lector;
                lector = comando.ExecuteReader();

            }
            if (radioExis.Checked == true)
            {
                string consulta = "SELECT * FROM Producto WHERE Existencia= '" + textbusqueda.Text + "'";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataProducto.DataSource = dt;
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader lector;
                lector = comando.ExecuteReader();

            }
            }
            conexion.Close();

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            llenar_tabla();
            radioId.Checked = false;
            radioNombre.Checked = false;
            radioExis.Checked = false;
            textbusqueda.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            texId_Pro.Clear();
            texNombre.Clear();
            texDescr.Clear();
            texExis.Clear();
            texPrecio.Clear();

           
        }

        private void dataProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
