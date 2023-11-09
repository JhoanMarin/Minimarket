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
    public partial class ProveedorActualizar : Form
    {
        public ProveedorActualizar()
        {
            InitializeComponent();
        }

        private void ProveedorActualizar_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataGridViewButtonColumn dgvEditarProveedor = new DataGridViewButtonColumn();
            dgvEditarProveedor.Name = "Actualizar";
            dgvEditarProveedor.Text = "Actualizar";


            dt = CN_Proveedor.ConsultarProveedor();
            dgvConsultar.DataSource = dt;
            dgvConsultar.Columns[0].Visible = false;
            dgvConsultar.Columns.Add(dgvEditarProveedor);
        }

        private void dgvConsultar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvConsultar.Columns[e.ColumnIndex].Name == "Actualizar")
            {

                txtAcNitProveedor.Text = (dgvConsultar.CurrentRow.Cells[2].Value.ToString());
                txtAcRazonSocialProveedor.Text = (dgvConsultar.CurrentRow.Cells[3].Value.ToString());
                txtAcNomenclaturaProveedor.Text = (dgvConsultar.CurrentRow.Cells[4].Value.ToString());
                txtAcTelefonoProveedor.Text = (dgvConsultar.CurrentRow.Cells[5].Value.ToString());
                txtAcCorreoProveedor.Text = (dgvConsultar.CurrentRow.Cells[6].Value.ToString());
                txtAcCiudadProveedor.Text = (dgvConsultar.CurrentRow.Cells[7].Value.ToString());
                txtAcDepartamentoProveedor.Text = (dgvConsultar.CurrentRow.Cells[8].Value.ToString());
            }
        }

        private void BtnActualizarProveedor_Click(object sender, EventArgs e)
        {
            Proveedor objProveedor = new Proveedor();

            objProveedor.nit = txtAcNitProveedor.Text.Trim();
            objProveedor.razonSocial = txtAcRazonSocialProveedor.Text.Trim();
            objProveedor.nomenclatura = txtAcNomenclaturaProveedor.Text.Trim();
            objProveedor.departamento = txtAcCiudadProveedor.Text.Trim();
            objProveedor.ciudad = txtAcDepartamentoProveedor.Text.Trim();
            objProveedor.telefono = txtAcTelefonoProveedor.Text.Trim();
            objProveedor.correo = txtAcCorreoProveedor.Text.Trim();
            

            if (CN_Proveedor.ActualizarDatosProveedor(objProveedor))
            {
                MessageBox.Show("Actualizacion exitosa");
            }
            else
            {
                MessageBox.Show("Fallo en la actualización");
            }
            DataTable dt = new DataTable();
            dt = CN_Proveedor.ConsultarProveedor();
            dgvConsultar.DataSource = dt;
        }

        private void txtAcCiudadProveedor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
