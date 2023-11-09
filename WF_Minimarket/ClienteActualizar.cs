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
    public partial class ClienteActualizar : Form
    {
        public ClienteActualizar()
        {
            InitializeComponent();
        }

        private void dgvConsultarCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultarCliente.Columns[e.ColumnIndex].Name == "Actualizar")

            {
                txtIdClienteAc.Text = (dgvConsultarCliente.CurrentRow.Cells[1].Value.ToString());
                txtIdentificacionClienteAc.Text = (dgvConsultarCliente.CurrentRow.Cells[2].Value.ToString());
                cbTipoDocumentoAcCliente.Text = (dgvConsultarCliente.CurrentRow.Cells[3].Value.ToString());
                txtNombreClienteAc.Text = (dgvConsultarCliente.CurrentRow.Cells[4].Value.ToString());
                txtApellidoClienteAc.Text = (dgvConsultarCliente.CurrentRow.Cells[5].Value.ToString());
                txtCorreoClienteAc.Text = (dgvConsultarCliente.CurrentRow.Cells[6].Value.ToString());
               
                txtTelefonoClienteAc.Text = (dgvConsultarCliente.CurrentRow.Cells[8].Value.ToString());
            }
        }

        private void BtnActualizarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.idCliente = int.Parse(txtIdClienteAc.Text.Trim());
            cliente.identificacion = txtIdentificacionClienteAc.Text.Trim();
            cliente.tipodocumento = cbTipoDocumentoAcCliente.Text.Trim();
            cliente.nombres = txtNombreClienteAc.Text.Trim();
            cliente.apellidos = txtApellidoClienteAc.Text.Trim();
            cliente.correo = txtCorreoClienteAc.Text.Trim();
          
            cliente.celular = txtTelefonoClienteAc.Text.Trim();

            if (CN_Cliente.actualizarClientes(cliente))
            {
                MessageBox.Show("Actualizaciósn exitosa");
            }
            else
            {
                MessageBox.Show("Fallo en la actualización");
            }

            DataTable dt = new DataTable();
            dt = CN_Cliente.consultarClientes();
            dgvConsultarCliente.DataSource = dt;
        }
       

        private void ClienteActualizar_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataGridViewButtonColumn dgvEditarProveedor = new DataGridViewButtonColumn();
            dgvEditarProveedor.Name = "Actualizar";
            dgvEditarProveedor.Text = "Actualizar";


            dt = CN_Cliente.consultarClientes();
            dgvConsultarCliente.DataSource = dt;
            dgvConsultarCliente.Columns[0].Visible = false;
            dgvConsultarCliente.Columns.Add(dgvEditarProveedor);

        }
    }
}
