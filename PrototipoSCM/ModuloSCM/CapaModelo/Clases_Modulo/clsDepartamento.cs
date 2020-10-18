using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo.Clases_Modulo
{
    public class clsDepartamento
    {
        private int iIDeparmeto;
        private string sNombre;
        private string sDescripcion;
        private int iEstado;

        public int IIDeparmeto { get => iIDeparmeto; set => iIDeparmeto = value; }
        public string SNombre { get => sNombre; set => sNombre = value; }
        public string SDescripcion { get => sDescripcion; set => sDescripcion = value; }
        public int IEstado { get => iEstado; set => iEstado = value; }
    }
}
