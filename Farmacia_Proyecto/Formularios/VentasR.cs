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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Printing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace Farmacia_Proyecto


{
    public partial class VentasR : Form
    {
        //SqlConnection conexion = new SqlConnection("Server=DESKTOP-1LQHI27;database=Proyecto_Farmaci;integrated security=true");
        //SqlConnection conexion = new SqlConnection("Server=SANDERSUWU;database=Proyecto_Farmaci;integrated security=true");
        SqlConnection conexion = new SqlConnection("Data Source=SQL5054.site4now.net;Initial Catalog=db_a9a08f_pruebafarmacia;User Id=db_a9a08f_pruebafarmacia_admin;Password=lolita08");

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

            dataFactura.Columns.Add("Id Producto", "Id Producto");
            dataFactura.Columns.Add("Nombre", "Nombre");
            dataFactura.Columns.Add("Descripcion", "Descripcion");
            dataFactura.Columns.Add("Cantidad", "Cantidad");
            dataFactura.Columns.Add("Precio", "Precio");
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

                int indice_fila = dataFactura.Rows.Add();
                DataGridViewRow row = dataFactura.Rows[indice_fila];
                row.Cells["Id producto"].Value = texId_Pro.Text;
                row.Cells["Nombre"].Value = texNombre.Text;
                row.Cells["Descripcion"].Value = texDescr.Text;
                row.Cells["Cantidad"].Value = TBCantidad.Text;
                row.Cells["Precio"].Value = double.Parse(texPrecio.Text) * double.Parse(TBCantidad.Text);
                
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
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));

            string PaginaHTML_Texto = Properties.Resources.plantilla.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", TBCliente.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@IdFactura", labelNum.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));


                
            string filas = string.Empty;
         
            foreach (DataGridViewRow row in dataFactura.Rows)
            {
                filas += "<tr>"; 
                filas += "<td>" + row.Cells["Nombre"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Descripcion"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Precio"].Value.ToString() + "</td>";
            
                filas += "</tr>";
               
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", TBTotal.Text.ToString());

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));




                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }
             
            }

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
            TBCliente.Clear();
            dataFactura.Rows.Clear();
            TBIVa.Clear();
            TbSubTotal.Clear();
            TBTotal.Clear();
            limpieza();
        }

        private void BBorrar_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        

        private void dataFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
