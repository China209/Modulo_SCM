using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo.Clases_Modulo
{
    public class clsSucursal
    {
        private int iIDSucursal;
        private int iMunicipio;
        private string sNombre;
        private string sdireccion;
        private int iTelefono;
        private string sDescripcion;
        private int iEstado;

        public int IIDSucursal { get => iIDSucursal; set => iIDSucursal = value; }
        public int IMunicipio { get => iMunicipio; set => iMunicipio = value; }
        public string SNombre { get => sNombre; set => sNombre = value; }
        public string Sdireccion { get => sdireccion; set => sdireccion = value; }
        public int ITelefono { get => iTelefono; set => iTelefono = value; }
        public string SDescripcion { get => sDescripcion; set => sDescripcion = value; }
        public int IEstado { get => iEstado; set => iEstado = value; }
    }
}
