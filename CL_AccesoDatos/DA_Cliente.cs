using CL_CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_AccesoDatos
{
    public class DA_Cliente: DA_Base
    {
        public static bool InsertarCliente(Cliente objCliente)
        {
            String strSQL = "Insert into cliente " +
                    "(tipodoc,identificacion,nombre,apellido,correo_Electronico,celular) VALUES (";
            strSQL += "'" + objCliente.tipodocumento + "',";
            strSQL += "'" + objCliente.identificacion + "',";
            strSQL += "'" + objCliente.nombres + "',";
            strSQL += "'" + objCliente.apellidos + "',";
            strSQL += "'" + objCliente.correo + "',";
            strSQL += "'" + objCliente.celular + "');";

            return RealizarTransaccion(strSQL);



        }

        public static DataTable consultarClientes()
        {
            DataTable dt = new DataTable();
            string strSql = "Select * from cliente;";
            return ConsultarDatos(strSql);
        }
        public static bool actualizarClientes(Cliente cliente)
        {
            string strSQL = "Update cliente set ";

            strSQL += "tipoDocumento = '" + cliente.tipodocumento + "',";
            strSQL += "identificacion = '" + cliente.identificacion + "',";
            strSQL += "nombres ='" + cliente.nombres + "',";
            strSQL += "apellidos ='" + cliente.apellidos + "',";
            strSQL += "correo ='" + cliente.correo + "',";
            strSQL += "telefono ='" + cliente.celular + "'WHERE idCliente = '" + cliente.idCliente + "';";

            return RealizarTransaccion(strSQL);
        }
    }
}
