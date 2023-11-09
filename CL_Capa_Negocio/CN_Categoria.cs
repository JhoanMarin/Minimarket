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
    public class CN_Categoria
    {

        public static bool InsertarCategoria(Categoria objCategoria)

        {
            return DA_Categoria.InsertarCategoria(objCategoria);
        }
        public static DataTable ConsultarCategoria()
        {
            return DA_Categoria.ConsultarCategoria();
        }

        public static bool ActualizarDatosCategorias(Categoria categoria)
        {
            return DA_Categoria.ActualizarDatosCategorias(categoria);
        }
    }
}
