using api_showPackageStatus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

namespace api_showPackageStatus.Context
{
    public class showStatusPackageCommands : DBContex
    {
        public static Reply mostrar_Status_Paquete(NumGuia guia_paquete)
        {
            PackageStatus oStatus = new PackageStatus();
            Reply oReply=new Reply();   
            string connectionString = $"server ={GetRDSConections().Reader}; {Data_base}";
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {

                MySqlCommand cmd = new MySqlCommand("muestra_estatus_paqPorGuia_sp", conexion);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@paqguia", guia_paquete.Number_Guide);
                try
                {

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                      
                           
                            while (dr.Read())
                            {
                                oStatus = new PackageStatus()
                                {
                                    Reception_Date = Convert.ToDateTime(dr["paq_fecharecepcion"].ToString()),

                                    Customer_information = dr["cli_razonsocial"].ToString(),

                                    Name_Addressee = dr["Nombre Destinatario"].ToString(),

                                    Name_Store = dr["bod_nombre"].ToString(),

                                    Status = dr["epa_descripcion"].ToString()
                                };
                            }


                    }
                    oReply.package_Status = oStatus;
                    oReply.Result = 200;
                    oReply.Message = "Ok successful";
                    return oReply;
                }
                catch (Exception ex)
                {
                    oReply.package_Status = oStatus;
                    oReply.Result = 400;
                    oReply.Message = ex.Message.ToString();
                    return oReply;
                }


            }
        }
    }
}