using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Entidades
{
    public class RolE
    {
        #region Miembros
        private int roId;
        private string roDescripcion;
        #endregion

        #region Propiedades
        public int RoId { get => roId; set => roId = value; }
        public string RoDescripcion { get => roDescripcion; set => roDescripcion = value; }
        #endregion
    }
}