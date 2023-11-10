using CL_Capa_Negocio;
using CL_CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Minimarket
{
    public partial class ProductoRegistrar : Form
    {
        public DataTable MiTablaDatos = new DataTable();

        public ProductoRegistrar()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegisProducto_Click(object sender, EventArgs e)
        {
            Producto objProducto = new Producto();
            objProducto.nombre= txtRegisNombreProducto.Text.Trim();
            objProducto.marca= txtRegisMarcaProducto.Text.Trim();
            objProducto.Stock = int.Parse(txtRegisStockProducto.Text.Trim());
            objProducto.pvp= Decimal.Parse(txtRegisPrecioProducto.Text.Trim());
            objProducto.descripcion= txtRegisDescripcionProducto.Text.Trim();
            objProducto.unidadMedida= cmBoxUniMedi.SelectedItem.ToString();
            objProducto.idcategoria= (int)cmBoxCaProducto.SelectedValue;

            //SACAMOS EL VALOR DEL 'idcategoria' y lo convertimos a INT
            //porque estamos recibiendo un String del combobox de la siguiente forma
            //(int)cmBoxCaProducto.SelectedValue;




        }

        private void ProductoRegistrar_Load(object sender, EventArgs e)
        {
          
           MiTablaDatos=CN_Categoria.ConsultarCategoria();
            cmBoxCaProducto.DataSource = MiTablaDatos;
            cmBoxCaProducto.DisplayMember = "nombre ";
            cmBoxCaProducto.ValueMember = "idcategoria ";
            
                


            





        }

    }
}
