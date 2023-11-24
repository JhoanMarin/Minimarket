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
using System.Text.RegularExpressions;

namespace WF_Minimarket
{
    public partial class ProductoRegistrar : Form
    {
        public DataTable MiTablaDatos = new DataTable();
        public Regex miExpresionRegularNombres = new Regex("^[\\w\\s]{5,15}$");
        public Regex miExpresionRegularDescripcion = new Regex("^[\\w\\s]{5,200}$");
        public Regex ExpresionStock = new Regex("^(?:0|[1-9]\\d{0,3})$");
        public Regex Expresionprecio = new Regex("^\\d+(\\.\\d{2})?$");





        public bool validarFormulario()
        {
            int bandera = 1;
            errorProRegisProducto.Clear();

            if (!miExpresionRegularNombres.IsMatch(txtRegisNombreProducto.Text))
            { 

            errorProRegisProducto.SetError(txtRegisNombreProducto, "Error en el nombre");
            bandera = 0;
            }

            if (!miExpresionRegularNombres.IsMatch(txtRegisMarcaProducto.Text))
            {

                errorProRegisProducto.SetError(txtRegisMarcaProducto, "Error en la marca");
                bandera = 0;
            }


            if (!miExpresionRegularDescripcion.IsMatch(txtRegisDescripcionProducto.Text))
            {

                errorProRegisProducto.SetError(txtRegisDescripcionProducto, "Error en la Descripción");
                bandera = 0;
            }


            if (!ExpresionStock.IsMatch(txtRegisStockProducto.Text))
            {

                errorProRegisProducto.SetError(txtRegisStockProducto, "Error en el Stock");
                bandera = 0;
            }


            if (!Expresionprecio.IsMatch(txtRegisPrecioProducto.Text))
            {

                errorProRegisProducto.SetError(txtRegisPrecioProducto, "Error en el Precio");
                bandera = 0;
            }


            if (bandera == 1) return true;
            else return false;

        }

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

            if (validarFormulario() == true) { 

            objProducto.nombre= txtRegisNombreProducto.Text.Trim();
            objProducto.marca= txtRegisMarcaProducto.Text.Trim();
            objProducto.Stock = int.Parse(txtRegisStockProducto.Text.Trim());
            objProducto.pvp= Decimal.Parse(txtRegisPrecioProducto.Text.Trim());
            objProducto.descripcion= txtRegisDescripcionProducto.Text.Trim();
            objProducto.unidadMedida= cmBoxUniMedi.SelectedItem.ToString();
            objProducto.idcategoria= (int)cmBoxCaProducto.SelectedValue;

            }

            //SACAMOS EL VALOR DEL 'idcategoria' y lo convertimos a INT
            //porque estamos recibiendo un String del combobox de la siguiente forma
            //(int)cmBoxCaProducto.SelectedValue;

            if (CN_Producto.InsertarProducto(objProducto)) 
            {
                MessageBox.Show("RegistroExitoso");

            }
            else
                MessageBox.Show("Fallo en el Regitro");



        }
       

        private void ProductoRegistrar_Load(object sender, EventArgs e)
        {
          
           MiTablaDatos=CN_Categoria.ConsultarCategoria();
            cmBoxCaProducto.DataSource = MiTablaDatos;
            cmBoxCaProducto.DisplayMember = "nombre";
            cmBoxCaProducto.ValueMember = "idcategoria";
            
                


            





        }

        private void cmBoxCaProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
