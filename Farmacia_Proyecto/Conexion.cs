using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Farmacia_Proyecto
{
    public class Conexion
    {
        private SqlConnection connection;
        private string ConnectionString;

        public void Open()
        {
            try
            {
                ConnectionString = "Server = SANDERSUWU; database = Proyecto_Farmaci; integrated security = true";
                connection = new SqlConnection(ConnectionString);
                connection.Open();
                MessageBox.Show("Conexion Establecida");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error en la conexion",ex.Message);
            }
        }
        public void Close()
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
