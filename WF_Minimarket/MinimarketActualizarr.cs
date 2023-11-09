using CL_Capa_Negocio;
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
    public partial class MinimarketActualizarr : Form
    {
        public MinimarketActualizarr()
        {
            InitializeComponent();
        }

        private void MinimarketActualizarr_Load(object sender, EventArgs e)
        {
            DataTable MiTablaDatos = new DataTable();
            MiTablaDatos = CN_Minimarket.ConsutarMinimarket();
        }
    }
}
