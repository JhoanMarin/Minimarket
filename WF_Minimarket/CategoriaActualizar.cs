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
    public partial class CategoriaActualizar : Form
    {
        public CategoriaActualizar()
        {
            InitializeComponent();
        }

        private void dgvConsultarCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultarCategoria.Columns[e.ColumnIndex].Name == "Actualizar")
            {
                txtIdCatAc.Text = (dgvConsultarCategoria.CurrentRow.Cells[1].Value.ToString());
                txtNombreCatAc.Text = (dgvConsultarCategoria.CurrentRow.Cells[2].Value.ToString());
                txtDescripciónCategoriaAc.Text = (dgvConsultarCategoria.CurrentRow.Cells[3].Value.ToString());

            }
        }

        private void BtnGuardarCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();

            categoria.idCategoria = int.Parse(txtIdCatAc.Text.Trim());
            categoria.nombre = txtNombreCatAc.Text.Trim();
            categoria.descripcion = txtDescripciónCategoriaAc.Text.Trim();

            if (CN_Categoria.ActualizarDatosCategorias(categoria))
            {
                MessageBox.Show("Actualizacion exitosa");
            }
            else
            {
                MessageBox.Show("Fallo en la actualización");
            }

            DataTable dt = new DataTable();
            dt = CN_Categoria.ConsultarCategoria();
            dgvConsultarCategoria.DataSource = dt;
        }
       

        private void CategoriaActualizar_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataGridViewButtonColumn dgvEditarCategorias = new DataGridViewButtonColumn();
            dgvEditarCategorias.Name = "Actualizar";
            dgvEditarCategorias.Text = "Actualizar";


            dt = CN_Categoria.ConsultarCategoria();
            dgvConsultarCategoria.DataSource = dt;
            dgvConsultarCategoria.Columns[0].Visible = false;
            dgvConsultarCategoria.Columns.Add(dgvEditarCategorias);

        }
    }
}
