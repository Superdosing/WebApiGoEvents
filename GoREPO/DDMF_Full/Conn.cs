﻿using System.Data.SqlClient;

namespace GoRepo
{
    public static class Conn
    {
        /// <summary>
        /// Metoden indeholder formindelsesindstillinger til databaen
        /// </summary>
        /// <returns>Retunere en MS SQL connection string</returns>
        public static SqlConnection GetCon()
        {
            SqlConnection con = new SqlConnection("server=194.255.108.50;database=dbaforum;uid=aForum;pwd=eGeIYTd3;MultipleActiveResultSets=True");
            return con;
        }

        /// <summary>
        /// Metoden retunere en åben forbindelse til databasen der er defineret i GetCon()
        /// </summary>
        /// <returns>Retunere en åben forbindelse til databasen</returns>
        public static SqlConnection CreateConnection()
        {
            var cn = GetCon();
            cn.Open();
            return cn;
        }
    }
}