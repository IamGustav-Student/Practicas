using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebService.Entidades;



namespace WebService
{
    /// <summary>
    /// Descripción breve de WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        private string CadenaDeConexion = "Server=GUSTAV-PC;Database=Instituto;Trusted_Connection=True;TrustServerCertificate=True";

        [WebMethod] // <--Hacerlo accesible desde la web
        public DataSet Carreras_GetAll() // <--Declaracion del método
        {
            // --- Lógica del método ---
            string _query = "SELECT * FROM Carreras";
            var ds = new DataSet();

            using (var connection = new SqlConnection(CadenaDeConexion))
            using (var cmd = new SqlCommand(_query,connection ))
            using (var adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(ds);
            }
            return ds;


        }

        [WebMethod] 
        public DataSet Roles_GetAll() 
        {

            string _query = "SELECT * FROM Roles";
            var ds = new DataSet();

            using (var connection = new SqlConnection(CadenaDeConexion))
            using (var cmd = new SqlCommand(_query, connection))
            using (var adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(ds);
            }
            return ds;
        }
        [WebMethod] 
        public DataSet Materias_GetAll() 
        {

            string _query = "SELECT * FROM Materias";
            var ds = new DataSet();

            using (var connection = new SqlConnection(CadenaDeConexion))
            using (var cmd = new SqlCommand(_query, connection))
            using (var adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(ds);
            }
            return ds;
        }
        [WebMethod] 
        public DataSet MateriasGetByCarrera() 
        {

            string _query = "SELECT * FROM Carreras_Materias";
            var ds = new DataSet();

            using (var connection = new SqlConnection(CadenaDeConexion))
            using (var cmd = new SqlCommand(_query, connection))
            using (var adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(ds);
            }
            return ds;
        }
    }
}
