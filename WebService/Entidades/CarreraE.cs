using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Entidades
{
    public class CarreraE
    {
        #region Miembros
        private int caId;
        private string caDenominacion;
        private string caCodigo;
        #endregion

        #region Propiedades
        public int CaId { get => caId; set => caId = value; }
        public string CaDenominacion { get => caDenominacion; set => caDenominacion = value; }
        public string CaCodigo { get => caCodigo; set => caCodigo = value; }

        #endregion
    }
}