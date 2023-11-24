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
    public partial class ProveedorRegistrar : Form
    {
        public Regex MiNit = new Regex("^[\\w\\W]{1,15}$");
        public Regex MiTelefonoProvee = new Regex("^\\d{1,10}$");
        public Regex MiCorreoProvee = new Regex("^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$");
        public Regex MirazonSocialProvee = new Regex("^[\\w\\W]{1,50}$");
        public Regex MiNomenclaturaProvee = new Regex("^(ca|Ca|av|Av|ma|Ma|Ka|ka)[\\w\\W]{0,48}$");
        public Regex Miciudad = new Regex("[a-zA-Z]{3,30}$");
        public Regex MiDepartamento = new Regex("[a-zA-Z]{3,50}$");

        public bool validarFormulario()
        {
            int bandera = 1;
            errorProveeRegis.Clear();

            if(!MiNit.IsMatch(txtRegisNITProveedor.Text))
            {
                errorProveeRegis.SetError(txtRegisNITProveedor, "Error en Nit");
                bandera = 0;

            }

            if (!MiTelefonoProvee.IsMatch(txtRegisTelefonoProveedor.Text))
            {
                errorProveeRegis.SetError(txtRegisTelefonoProveedor, "Error en Nit");
                bandera = 0;
            }
            if (!MiCorreoProvee.IsMatch(txtRegisCorreoProveedor.Text))
            {
                errorProveeRegis.SetError(txtRegisCorreoProveedor, "Error en Correo");
                bandera = 0;
            }

            if (!MirazonSocialProvee.IsMatch(txtRegisRazonSocialProveedor.Text))
            {
                errorProveeRegis.SetError(txtRegisRazonSocialProveedor, "Error en La Razón Social");
                bandera = 0;
            }
            if (!MiNomenclaturaProvee.IsMatch(txtRegisNomenclaturaProveedor.Text))
            {
                errorProveeRegis.SetError(txtRegisNomenclaturaProveedor, "Error en La Nomenclatura");
                bandera = 0;
            }

            if (!Miciudad.IsMatch(txtRegisCiudadProveedor.Text))
            {
                errorProveeRegis.SetError(txtRegisCiudadProveedor, "Error en La Ciudad");
                bandera = 0;
            }
            if (!MiDepartamento.IsMatch(txtRegisDepartamentoProveedor.Text))
            {
                errorProveeRegis.SetError(txtRegisDepartamentoProveedor, "Error en el Departamento");
                bandera = 0;
            }
            if (bandera == 1) return true;
            else return false;


        }
        public ProveedorRegistrar()
        {
            InitializeComponent();
        }

        private void btnRegisProveedor_Click(object sender, EventArgs e)
        {
            Proveedor objProveedor = new Proveedor();
            if (validarFormulario() == true)
            {
                objProveedor.nit = txtRegisNITProveedor.Text.Trim();
                objProveedor.razonSocial = txtRegisRazonSocialProveedor.Text.Trim();
                objProveedor.telefono = txtRegisTelefonoProveedor.Text.Trim();
                objProveedor.correo = txtRegisCorreoProveedor.Text.Trim();
                objProveedor.nomenclatura = txtRegisNomenclaturaProveedor.Text.Trim();
                objProveedor.ciudad = txtRegisCiudadProveedor.Text.Trim();
                objProveedor.departamento = txtRegisDepartamentoProveedor.Text.Trim();


                if (CN_Proveedor.InsertarProveedor(objProveedor))
                {
                    MessageBox.Show("Registro exitoso");
                }
                else
                    MessageBox.Show("Fallo en la insercion");

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
