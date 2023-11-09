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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void minimarketToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MinimarketRegistrar objFrm = new MinimarketRegistrar();

            objFrm.MdiParent = this;
            objFrm.Show();
            objFrm.WindowState = FormWindowState.Maximized;
        }

        private void registrarcategoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            categoriaRegistrar objFrm = new categoriaRegistrar();

            objFrm.MdiParent = this;
            objFrm.Show();
            objFrm.WindowState = FormWindowState.Maximized;

        }

        private void registrarProveedorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ProveedorRegistrar objprovee=new ProveedorRegistrar();

            objprovee.MdiParent = this;
            objprovee.Show();
            objprovee.WindowState = FormWindowState.Maximized;

        }

        private void registrarClienteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ClienteRegistrar objCliente=new ClienteRegistrar();

            objCliente.MdiParent = this;
            objCliente.Show();
            objCliente.WindowState = FormWindowState.Maximized;
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MinimarketActualizarr objFrm = new MinimarketActualizarr();

            objFrm.MdiParent = this;
            objFrm.Show();
            objFrm.WindowState = FormWindowState.Maximized;
        }

        private void actualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CategoriaActualizar categoria = new CategoriaActualizar();
            categoria.MdiParent = this;

            categoria.Show();
            categoria.WindowState = FormWindowState.Maximized;
        }

        private void actualizarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ProveedorActualizar ObjFrmProoAc = new ProveedorActualizar();
            ObjFrmProoAc.MdiParent = this;

            ObjFrmProoAc.Show();
            ObjFrmProoAc.WindowState = FormWindowState.Maximized;
        }

        private void actualizarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ClienteActualizar cliente = new ClienteActualizar();
            cliente.MdiParent = this;

            cliente.Show();
            cliente.WindowState = FormWindowState.Maximized;
        }
    }
}
