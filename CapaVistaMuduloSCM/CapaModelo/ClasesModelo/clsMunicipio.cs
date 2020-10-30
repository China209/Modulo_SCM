using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo.ClasesModelo
{
    public class clsMunicipio
    {
        private int iIDMunicipio;
        private int iDepartamento;
        private string sNombre;
        private string sDescripcion;
        private int iEstado;

        public int IIDMunicipio { get => iIDMunicipio; set => iIDMunicipio = value; }
        public int IDepartamento { get => iDepartamento; set => iDepartamento = value; }
        public string SNombre { get => sNombre; set => sNombre = value; }
        public string SDescripcion { get => sDescripcion; set => sDescripcion = value; }
        public int IEstado { get => iEstado; set => iEstado = value; }
    }
}
