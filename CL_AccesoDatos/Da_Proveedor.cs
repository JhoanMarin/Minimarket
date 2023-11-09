using CL_CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_AccesoDatos
{
    public class Da_Proveedor: DA_Base
    {
        public static bool InsertarProveedor(Proveedor objProveedor)
        {
            String strSQL = "Insert into proveedor " +
                    "(nit,razon_social,telefono,correo_Electronico,nomenclatura,ciudad,departamento) VALUES (";
            strSQL += "'" + objProveedor.nit + "',";
            strSQL += "'" + objProveedor.razonSocial + "',";
            strSQL += "'" + objProveedor.telefono + "',";
            strSQL += "'" + objProveedor.correo + "',";
            strSQL += "'" + objProveedor.nomenclatura + "',";
            strSQL += "'" + objProveedor.ciudad + "',";
            strSQL += "'" + objProveedor.departamento + "');";

            return RealizarTransaccion(strSQL);



        }
        public static DataTable ConsultarProveedor()
        {
            DataTable dt = new DataTable();
            String strSQL = "Select * from proveedor; ";


            return ConsultarDatos(strSQL);
        }

        public static bool ActualizarDatosProveedor(Proveedor objProveedor)
        {
            string strSQL = "Update proveedor set ";

            strSQL += "razonSocial = '" + objProveedor.razonSocial + "',";
            strSQL += "nomenclatura = '" + objProveedor.nomenclatura + "',";
            strSQL += "ciudad = '" + objProveedor.ciudad + "',";
            strSQL += "departamento = '" + objProveedor.departamento + "',";
            strSQL += "telefono ='" + objProveedor.telefono + "',";
            strSQL += "correo ='" + objProveedor.correo + "',";
            strSQL += "ciudad ='" + objProveedor.ciudad + "'WHERE nit = '" + objProveedor.nit + "';";

            return RealizarTransaccion(strSQL);
        }

    }
}

