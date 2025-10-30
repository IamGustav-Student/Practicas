using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebService.AccesoDatos;

namespace WebService.Negocio
{
    public class CarreraN
    {
        SqlDataProvider oSqlDataProvider = new SqlDataProvider();
        public DataSet CarreraN_GetAll()
        {
            return oSqlDataProvider.Carreras_GetAll();
        }


    }

}
