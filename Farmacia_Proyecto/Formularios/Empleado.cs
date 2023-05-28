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
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }

        //SqlConnection conexion = new SqlConnection("Server=DESKTOP-1LQHI27;database=Proyecto_Farmaci;integrated security=true");
        // SqlConnection conexion = new SqlConnection("Server=SANDERSUWU;database=Proyecto_Farmaci;integrated security=true");
        SqlConnection conexion = new SqlConnection("Data Source=SQL5054.site4now.net;Initial Catalog=db_a9a08f_pruebafarmacia;User Id=db_a9a08f_pruebafarmacia_admin;Password=lolita08");

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
                errorcito.SetError(txttelefono, "Ingresar telefono");
            }

            return ok;
        }
        public void borrarerror()
        {
            errorcito.SetError(txtNom, "");
            errorcito.SetError(txtapellido, "");
            errorcito.SetError(txttelefono, "");
        }
        public void Limpieza()
        {
            labelid.Text = "";
            txtNom.Clear();
            txtapellido.Clear();
            txttelefono.Clear();
            CombCar.Text = string.Empty;
            CombEsta.Text= string.Empty;
            txtNom.Focus();

        }
        public void llenar_tabla()
        {
            string consulta = "select * from Empleado";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataEmp.DataSource = dt;
        }
        public void repetidos()
        {
            string consulta = "with c as(select ID_Empleado = '" + dataEmp.SelectedCells[0] + "', Nombre= '" + dataEmp.SelectedCells[1] + "', Apellido= '" + dataEmp.SelectedCells[2] + "', telefono= '" + dataEmp.SelectedCells[3] + "', cargo= '" + dataEmp.SelectedCells[4] + "', Estado= '" + dataEmp.SelectedCells[5] + "',row_number() OVER(partition by Nombre, Apellido, telefono, cargo order by ID_Empleado)  AS Duplicado from DBO.Empleado) delete from c where Duplicado > 1";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            llenar_tabla();
          
        }

        private void dataEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelid.Text = dataEmp.SelectedCells[0].Value.ToString();
            txtNom.Text = dataEmp.SelectedCells[1].Value.ToString();
            txtapellido.Text= dataEmp.SelectedCells[2].Value.ToString();
            txttelefono.Text = dataEmp.SelectedCells[3].Value.ToString();
            CombCar.SelectedItem = dataEmp.SelectedCells[4].Value.ToString();
            CombEsta.SelectedItem = dataEmp.SelectedCells[5].Value.ToString();
        }

        private void agregado_Click(object sender, EventArgs e)
        {
            borrarerror();
            if (confirmacion())
            {
                string consulta = "INSERT INTO Empleado (Nombre,Apellido,telefono,cargo,Estado) values(@nombre,@apellido,@telefono,@cargo,@estado)";
                conexion.Open();
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@nombre", txtNom.Text);
                comando.Parameters.AddWithValue("@apellido", txtapellido.Text);
                comando.Parameters.AddWithValue("@telefono", txttelefono.Text);
                comando.Parameters.AddWithValue("@cargo", CombCar.SelectedItem);
                comando.Parameters.AddWithValue("@estado", CombEsta.SelectedItem);
                comando.ExecuteNonQuery();
                MessageBox.Show("Reguistro agregado");
                llenar_tabla();
                Limpieza();
                repetidos();
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
                string consulta = "UPDATE Empleado  SET Estado =@estado  WHERE ID_Empleado=@id";
                conexion.Open();
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@id", labelid.Text);
                comando.Parameters.AddWithValue("@estado", CombEsta.SelectedItem);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro actualizado");
                llenar_tabla();
                Limpieza();
                conexion.Close();
            }
            else
            {
                MessageBox.Show("Seleccione un trabajador");
            }
        }
    }
}
