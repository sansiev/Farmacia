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

namespace Farmacia_Proyecto
{
    public partial class inicio : Form
    {
        //SqlConnection conexion = new SqlConnection("Server=DESKTOP-1LQHI27;database=Proyecto_Farmaci;integrated security=true");
        SqlConnection conexion = new SqlConnection("Server=SANDERSUWU;database=Proyecto_Farmaci;integrated security=true");
       
        
        public inicio()
        {
            InitializeComponent();
        }
        public bool confirmacion()
        {
            bool ok = true;

            if (texID.Text == "")
            {
                ok = false;
                errorcito.SetError(texID, "Ingresar ID");
            }

            if (texcontra.Text == "")
            {
                ok = false;
                errorcito.SetError(texcontra, "Ingresar Contraseña");
            }
        
            return ok;
        }
        public void borrarerror()
        {
            errorcito.SetError(texID, "");
            errorcito.SetError(texcontra, "");
            
        }
        public void login1()
        {
            Form1 principal = new Form1();
            //try
            //{
            //    conexion.Open();
            //    string consulta = "select * from Empleado where ID_Empleado=" + texID.Text + " and contraseña ='" + texcontra.Text + "'";
            //    SqlCommand comando = new SqlCommand(consulta, conexion);
            //    SqlDataReader lector;
            //    lector = comando.ExecuteReader();
            //    if (lector.HasRows)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("campos invalidos");
            //    return false;
            //}

            try
            {
                string estatus;
                conexion.Open();
                string consulta = "select Nombre,cargo from Empleado where ID_Empleado=" + texID.Text + " and contraseña ='" + texcontra.Text + "'";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataAdapter sda =new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count ==1)
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "Gerente")
                    {
                       
                        principal.Show();
                        this.Hide();
                        estatus = "Gerente";
                    }else if (dt.Rows[0][1].ToString() == "Trabajador")
                    {
                       
                        principal.Show();
                        this.Hide();
                        estatus ="Trabajador";
                    }
                }
                else
                {
                    MessageBox.Show("El usuario o la contraseña son incorrectos");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            finally
            {
                conexion.Close();
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            borrarerror();
            if (confirmacion())
            {
                login1();
                //if (login())
                //{
                //    Form1 principal = new Form1();
                //    principal.Show();
                //    this.Hide();
                //    conexion.Close();
                //}
                //else
                //{
                //    MessageBox.Show("El usuario o la contraseña son incorrectos");
                //    conexion.Close();
                //}
            }
          else
                MessageBox.Show("Ingrese valores validos");
            conexion.Close();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
