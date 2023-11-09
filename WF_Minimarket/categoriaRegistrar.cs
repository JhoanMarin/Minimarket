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


namespace WF_Minimarket
{
    public partial class categoriaRegistrar : Form
    {
        public categoriaRegistrar()
        {
            InitializeComponent();
        }

        private void btnRegistrarCategoria_Click(object sender, EventArgs e)
        {

            Categoria objCategoria = new Categoria();
            objCategoria.nombre=txtRegisNombreCategoria.Text.Trim();
            objCategoria.descripcion=txtRegisDescripCategoria.Text.Trim();

            if (CN_Categoria.InsertarCategoria(objCategoria))
            {
                MessageBox.Show("Registro exitoso");
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
