﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class clsConexionDB
    {
        /// <summary>
        /// COMPRUEBA LA CONEXION CON LA DB 
        /// </summary>
        /// <returns>OBJETO SqlConnection</returns>
        public static SqlConnection getConexion()
        {
            SqlConnection miConexion = new SqlConnection();

            try
            {
                miConexion.ConnectionString = "server=nruiz-nervion.database.windows.net;database=nruizDB ;uid=usuario;pwd=LaCampana123;trustServerCertificate = true;";
                miConexion.Open();

            }
            catch (Exception ex)
            {
                throw;
            }

            return miConexion;
        }


    }

}