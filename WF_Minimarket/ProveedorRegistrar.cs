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
    public partial class ProveedorRegistrar : Form
    {
        public ProveedorRegistrar()
        {
            InitializeComponent();
        }

        private void btnRegisProveedor_Click(object sender, EventArgs e)
        {
            Proveedor objProveedor = new Proveedor();

            objProveedor.nit = txtRegisNITProveedor.Text.Trim();
            objProveedor.razonSocial = txtRegisRazonSocialProveedor.Text.Trim();
            objProveedor.telefono = txtRegisTelefonoProveedor.Text.Trim();
            objProveedor.correo= txtRegisCorreoProveedor.Text.Trim();
            objProveedor.nomenclatura= txtRegisNomenclaturaProveedor.Text.Trim();
            objProveedor.ciudad= txtRegisCiudadProveedor.Text.Trim();
            objProveedor.departamento= txtRegisDepartamentoProveedor.Text.Trim();
           

            if (CN_Proveedor.InsertarProveedor(objProveedor))
            {
                MessageBox.Show("Registro exitoso");
            }
            else
                MessageBox.Show("Fallo en la insercion");

        }

        private void gbRegistroProveedor_Enter(object sender, EventArgs e)
        {

        }

        private void ProveedorRegistrar_Load(object sender, EventArgs e)
        {

        }
    }
    
}
