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
    public partial class ClienteRegistrar : Form
    {
        public ClienteRegistrar()
        {
            InitializeComponent();
        }

        private void btnRegisCliente_Click(object sender, EventArgs e)
        {
            Cliente objCliente = new Cliente();
            objCliente.tipodocumento=cmboxRegisCliente.SelectedItem.ToString();
            objCliente.identificacion=txtRegisNoDocuCliente.Text.Trim();
            objCliente.nombres=txtRegisNombresCliente.Text.Trim();  
            objCliente.apellidos=txtRegisApellidosCliente.Text.Trim();
            objCliente.correo=txtRegisCorreoCliente.Text.Trim();   
            objCliente.celular=txtRegisCelularCliente.Text.Trim();

            if (CN_Cliente.InsertarCliente(objCliente))
            {
                MessageBox.Show("Registro exitoso");
            }
            else
                MessageBox.Show("Fallo en la insercion");


        }

        private void ClienteRegistrar_Load(object sender, EventArgs e)
        {

        }

        private void cmboxRegisCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
