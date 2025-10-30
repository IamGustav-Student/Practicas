using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using WebService.Entidades;

namespace WebService.AccesoDatos
{
    public class SqlDataProvider 
    {
        //string query = "";
        ////string connectionString = "Server=MUCHI\\MSSQLSERVER01;Database=DbMercado;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True";
        //SqlConnection connection = new SqlConnection("Server=GUSTAV-PC;Database=Instituto;Trusted_Connection=True;TrustServerCertificate=True");

        private string connectionString = "Server=GUSTAV-PC;Database=Instituto;Trusted_Connection=True;TrustServerCertificate=True";

        public DataSet Carreras_GetAll()
        {
            
            string query = "SELECT * FROM Carreras";
            var ds = new DataSet();


            using (var connection = new SqlConnection (connectionString))
            using (var cmd = new SqlCommand(query, connection))
            using (var adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(ds);
            }


            return ds;
        }
    }
}