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
    public partial class VentasR : Form
    {
        //SqlConnection conexion = new SqlConnection("Server=DESKTOP-1LQHI27;database=Proyecto_Farmaci;integrated security=true");
        SqlConnection conexion = new SqlConnection("Server=SANDERSUWU;database=Proyecto_Farmaci;integrated security=true");
        public VentasR()
        {
            InitializeComponent();
        }
        public bool confirmacion()
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
                errorcito.SetError(texNombre, "Ingresar ID");
            }

            if (texDescr.Text == "")
            {
                ok = false;
                errorcito.SetError(texDescr, "Ingresar ID");
            }

            if (texPrecio.Text == "")
            {
                ok = false;
                errorcito.SetError(texPrecio, "Ingresar ID");
            }

            if (TBCantidad.Text == "")
            {
                ok = false;
                errorcito.SetError(TBCantidad, "Ingrese la cantidad a comprar");
            }

            return ok;

        }
        public void limpieza()
        {
            TBCantidad.Text="";
            texId_Pro.Text = "";
            texDescr.Text = "";
            texNombre.Text = "";
            texPrecio.Text = "";
            TBCantidad.Text = "";
            
        }
        public void borrarerror()
        {
            errorcito.SetError(texId_Pro, "");
            errorcito.SetError(texNombre, "");
            errorcito.SetError(texDescr, "");
            errorcito.SetError(TBCantidad, "");
        }
        public void ventas()
        {
            string consulta = ("exec sp_Ventas '',@id_prod='" + texId_Pro.Text + "', @cantidadc=" + TBCantidad.Text + ",@fechav='"+labelF.Text+"'");
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
       
        private void BAgregarCarrito_Click(object sender, EventArgs e)
        {
            borrarerror();
            bool ok = true;
            if (texId_Pro.Text == "")
            {
                ok = false;
                errorcito.SetError(texId_Pro, "Ingresar ID");
            }
            else
            {
                conexion.Open();
                string consulta = "SELECT * FROM Producto WHERE ID_Prod='" + texId_Pro.Text + "'";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    texNombre.Text = registro["Nombre"].ToString();
                    texDescr.Text = registro["Descripcion"].ToString();
                    texPrecio.Text = registro["Precio"].ToString();
                }
                conexion.Close();
            }
           
        }
        public void num()
        {
            string consulta = ("select(select distinct top 1 numfact from Factura order by numfact desc) + 1 as Numfactura");
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            
        }


        private void VentasR_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyecto_FarmaciDataSet.Producto' Puede moverla o quitarla según sea necesario.
            DateTime f = DateTime.Today;
            labelF.Text = f.ToShortDateString();

           
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void Agregado_Click(object sender, EventArgs e)
        {
            borrarerror();
            bool ok = true; 
            if (TBCantidad.Text == "")
            {
                ok = false;
                errorcito.SetError(TBCantidad, "Ingrese la cantidad a comprar");
            }
            else 
            {
               
                double n;
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dataFactura);
                fila.Cells[0].Value = texId_Pro.Text;
                fila.Cells[1].Value = texNombre.Text;
                fila.Cells[2].Value = texDescr.Text;
                fila.Cells[3].Value = TBCantidad.Text;
                fila.Cells[4].Value = double.Parse(texPrecio.Text) * double.Parse(TBCantidad.Text);
                dataFactura.Rows.Add(fila);
                SumaColumna();
                
            }
            limpieza();
        }

        public void SumaColumna()
        {
            Double total = 0,iva = 0, suma = 0;

            foreach ( DataGridViewRow row in dataFactura.Rows)
            {
                total += Convert.ToDouble(row.Cells["Precio"].Value);
               
            }
            
            TbSubTotal.Text = total.ToString();
            iva = double.Parse(TbSubTotal.Text) * 0.15;
            TBIVa.Text = iva.ToString();
            suma = double.Parse(TbSubTotal.Text) + double.Parse(TBIVa.Text);
            TBTotal.Text = suma.ToString();

        }

        private void BFacturar_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("sp_Ventas", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id_Venta", ""));
                cmd.Parameters.Add(new SqlParameter("@id_Prod", SqlDbType.VarChar, 50));
                cmd.Parameters.Add(new SqlParameter("@cantidadc", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@fechaV", SqlDbType.Date));
                conexion.Open();

                foreach (DataGridViewRow row in dataFactura.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        cmd.Parameters["@id_Prod"].Value = row.Cells[0].Value;
                        cmd.Parameters["@CantidadC"].Value = row.Cells[3].Value;

                    }

                }
                cmd.Parameters["@Fechav"].Value = labelF.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datos facturados con Exito. ", "Informacion");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos NO Facturados", "Informacion");
            }

        }

        private void TBCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            dataFactura.Rows.Clear();
            TBIVa.Clear();
            TbSubTotal.Clear();
            TBTotal.Clear();
            limpieza();
        }

        private void BBorrar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
