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
    public class CN_Proveedor
    {
        public static bool InsertarProveedor(Proveedor objProveedor)

        {
            return Da_Proveedor.InsertarProveedor(objProveedor);
        }

        public static DataTable ConsultarProveedor()
        {
            return Da_Proveedor.ConsultarProveedor();
        }

        public static bool ActualizarDatosProveedor(Proveedor objProveedor)
        {
            return Da_Proveedor.ActualizarDatosProveedor(objProveedor);
        }
    }
}
