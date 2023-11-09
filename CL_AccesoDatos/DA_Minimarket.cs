using CL_CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_AccesoDatos
{
    public class DA_Minimarket : DA_Base
    {
        public static bool InsertarMinimarket(Minimarket objMiniMarket) 
        {
            String strSQL = "Insert into minimarket " +
                    "(nit,razon_social,telefono,nomenclatura,ciudad,departamento,correo_Electronico,sitio_Web,facebook,whatsapp) VALUES (";
            strSQL += "'" + objMiniMarket.nit + "',";
            strSQL += "'" + objMiniMarket.razonsocial + "',";
            strSQL += "'" + objMiniMarket.telefono   + "',";
            strSQL += "'" + objMiniMarket.nomenclatura  + "',";
            strSQL += "'" + objMiniMarket.ciudad  + "',";
            strSQL += "'" + objMiniMarket.departamento  + "',";
            strSQL += "'" + objMiniMarket.correo  + "',";
            strSQL += "'" + objMiniMarket.sitioWeb  + "',";
            strSQL += "'" + objMiniMarket.facebook  + "',";
            strSQL += "'" + objMiniMarket.whatsaap  + "');";

            return RealizarTransaccion(strSQL);










        }

        public static DataTable ConsultarMinimarket()
        {
            DataTable dt = new DataTable();

            String strSQL = "Select * from minimarket WHERE idminimarket=3 ; ";


            return ConsultarDatos(strSQL);
        }
    }
}
