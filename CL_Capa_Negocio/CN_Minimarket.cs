using CL_AccesoDatos;
using CL_CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Negocio
{
    public class CN_Minimarket
    {
        public static bool InsertarMinimarket (Minimarket objMinimarket)

        {
            return DA_Minimarket.InsertarMinimarket (objMinimarket);
        }

        public static DataTable ConsutarMinimarket()
        {
            return DA_Minimarket.ConsultarMinimarket();
        }
    }
}
