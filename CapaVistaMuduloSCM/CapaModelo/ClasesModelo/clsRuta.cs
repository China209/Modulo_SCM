using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo.ClasesModelo
{
    public class clsRuta
    {

        private int iIRuta;
        private string sOrigen;
        private string sDestino;
        private string sDescripcion;
        private int iEstado;

        public int IIRuta { get => iIRuta; set => iIRuta = value; }
        public string SOrigen { get => sOrigen; set => sOrigen = value; }
        public string SDestino { get => sDestino; set => sDestino = value; }
        public string SDescripcion { get => sDescripcion; set => sDescripcion = value; }
        public int IEstado { get => iEstado; set => iEstado = value; }
    }
}
