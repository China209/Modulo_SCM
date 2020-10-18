using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo.Clases_Modulo
{
   public class clsMarca
    {
        private int iIMarca;
        private string sDescripcion;
        private int iEstado;

        public int IIMarca { get => iIMarca; set => iIMarca = value; }
        public string SDescripcion { get => sDescripcion; set => sDescripcion = value; }
        public int IEstado { get => iEstado; set => iEstado = value; }
    }
}
