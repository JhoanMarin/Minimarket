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
    public partial class MinimarketRegistrar : Form
    {
        public MinimarketRegistrar()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnRegisMinimarket_Click(object sender, EventArgs e)
        {
            Minimarket objMiniMarket = new Minimarket();

            objMiniMarket.nit= txtNIT.Text.Trim();
            objMiniMarket.razonsocial= txtRazonSocial.Text.Trim();
            objMiniMarket.telefono= txtTelefono.Text.Trim();
            objMiniMarket.nomenclatura= txtNomenclaturaMiniMarket.Text.Trim();
            objMiniMarket.ciudad= txtCiudadMiniMarket.Text.Trim();
            objMiniMarket.departamento= txtDepartamentoMiniMarket.Text.Trim();
            objMiniMarket.correo= txtCorreo.Text.Trim();
            objMiniMarket.sitioWeb= txtSitioWeb.Text.Trim();
            objMiniMarket.facebook= txtFacebook.Text.Trim();
            objMiniMarket.whatsaap= txtWhatsapp.Text.Trim();

            if (CN_Minimarket.InsertarMinimarket(objMiniMarket))
            {
                MessageBox.Show("Registro exitoso");
            }
            else
                MessageBox.Show("Fallo en la insercion");

        }
    }
}
