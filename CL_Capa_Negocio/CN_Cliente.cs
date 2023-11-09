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
    public class CN_Cliente
    {
        public static bool InsertarCliente(Cliente objCliente)

        {
            return DA_Cliente.InsertarCliente(objCliente);
        }
        public static DataTable consultarClientes()
        {
            return DA_Cliente.consultarClientes();
        }
        public static bool actualizarClientes(Cliente cliente)
        {
            return DA_Cliente.actualizarClientes(cliente);
        }
    }
   
}

