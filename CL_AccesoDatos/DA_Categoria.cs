using CL_CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_AccesoDatos
{
    public class DA_Categoria : DA_Base
    {
        public static bool InsertarCategoria(Categoria objCategoria)
        {
            String strSQL = "Insert into categoria " +
                    "(nombre,descripcion) VALUES (";
            strSQL += "'" + objCategoria.nombre + "',";
            strSQL += "'" + objCategoria.descripcion + "');";

            return RealizarTransaccion(strSQL);










        }

        public static DataTable ConsultarCategoria()
        {
            DataTable dt = new DataTable();
            String strSQL = "Select * from categoria; ";
           

            return ConsultarDatos(strSQL);
        }

        public static bool ActualizarDatosCategorias(Categoria categoria)
        {
            string strSQL = "Update categoria set ";

            strSQL += "nombre = '" + categoria.nombre + "',";
            strSQL += "descripcion ='" + categoria.descripcion + "'WHERE idCategoria = '" + categoria.idCategoria + "';";

            return RealizarTransaccion(strSQL);
        }


    }
}
