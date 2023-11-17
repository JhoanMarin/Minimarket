using CL_CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_AccesoDatos
{
    public class DA_Producto : DA_Base
    {
        public static bool InsertarProducto(Producto objProducto)
        {
            String strSQL = "Insert into producto " +
                    "(nombre ,marca,Stock,pvp,descripcion,unidadMedida,idcategoria   ) VALUES (";
            strSQL += "'" + objProducto.nombre + "',";
            strSQL += "'" + objProducto.marca + "',";
            strSQL += "" + objProducto.Stock + ",";
            strSQL += "" + objProducto.pvp + ",";
            strSQL += "'" + objProducto.descripcion + "',";
            strSQL += "'" + objProducto.unidadMedida + "',";
            strSQL += "'" + objProducto.idcategoria + ");";
            

            return RealizarTransaccion(strSQL);


        }

    }
}
