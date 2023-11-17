using CL_AccesoDatos;
using CL_CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Negocio
{
    public class CN_Producto
    {

        public static bool InsertarProducto(Producto objProducto)

        {
            return DA_Producto.InsertarProducto(objProducto);
        }
    }
}
