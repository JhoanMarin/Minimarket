using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CL_AccesoDatos
{
    public class DA_Base
    {
        public static String CadenaConexion = "SERVER=localhost; DATABASE=minimarket; UID=root; PASSWORD=";

        //Sentencias insert, update, y delete
        public static bool RealizarTransaccion(String strSQL)
        {

            bool resultado = false;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(CadenaConexion))

                {

                    conn.Open();
                    using (MySqlTransaction tr = conn.BeginTransaction())
                    {

                        try
                        {

                            using (MySqlCommand cmd = new MySqlCommand (strSQL, conn))

                            {

                                cmd.Transaction = tr;
                                cmd.ExecuteNonQuery();

                            }
                            tr.Commit();
                            resultado = true;
                        }


                         catch (Exception)
                        {
                            tr.Rollback();
                            resultado = false;
                            throw;


                        }

                    }
                }
            }
            catch (Exception)
            {
                resultado = false;
                throw;

            }
            return resultado;
        }
        // CONSULTA DE DATOS - SENTENCIA SELECT
        public static DataTable ConsultarDatos(String strSQL)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(CadenaConexion))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(strSQL, conn))
                    {

                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            return dt;
                        }
                    }
                }

            }
       
            catch(Exception)
            {
                throw;
            }
        }
    }

 }