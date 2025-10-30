using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Entidades
{
    public class MateriaE
    {
        #region Miembros
        private int maId;
        private string maDenominacion;
        #endregion


        #region Propiedades
        public int MaId { get => maId; set => maId = value; }
        public string MaDenominacion { get => maDenominacion; set => maDenominacion = value; }
        #endregion
    }
}