using CL_Capa_Negocio;
using CL_CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; 


namespace WF_Minimarket
{
    public partial class categoriaRegistrar : Form
    {
        public Regex nombreCate = new Regex("^[a-zA-Z]{3,15}$");
        public Regex DescripcionCate = new Regex("^[\\w\\W]{1,200}$");

        public bool validarFormulario()

        {
            int bandera = 1;
            errorCateRegis.Clear();

            if(!nombreCate.IsMatch(txtRegisNombreCategoria.Text))

            {
                errorCateRegis.SetError(txtRegisNombreCategoria, "Error de digitación en Nombre Categoría");
                bandera = 0;
            }

            if(!DescripcionCate.IsMatch(txtRegisDescripCategoria.Text))
            {
                errorCateRegis.SetError(txtRegisDescripCategoria, "Error de Digitación en Descripcion de Ctegoría");
                bandera = 0;
            }



            if (bandera == 1) return true;
            else return false;
        }



        public categoriaRegistrar()
        {
            InitializeComponent();
        }

        private void btnRegistrarCategoria_Click(object sender, EventArgs e)
        {
            Categoria objCategoria = new Categoria();

            if (validarFormulario() == true)
            {



                objCategoria.nombre = txtRegisNombreCategoria.Text.Trim();
                objCategoria.descripcion = txtRegisDescripCategoria.Text.Trim();






                if (CN_Categoria.InsertarCategoria(objCategoria))
                {
                    MessageBox.Show("Registro exitoso");
                }
                else
                    MessageBox.Show("Fallo en la insercion");
            }

            else
                MessageBox.Show("Fallo en la insercion");
        }
         


           

        private void categoriaRegistrar_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.LightSalmon;
            DataTable MiTablaDatos= new DataTable();
            MiTablaDatos = CN_Categoria.ConsultarCategoria();

            
        }
    }
}
