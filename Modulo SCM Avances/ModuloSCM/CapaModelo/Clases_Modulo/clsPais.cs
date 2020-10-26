using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo.Clases_Modulo
{
    // Metodo para enviar y obtener los datos de Pais
    public class clsPais
    {

        private int idPais;
        private string sNombre_pais;
        private string sCapital_pais;
        private int iEstado_pais;

        public int IdPais { get => idPais; set => idPais = value; }
        public string SNombre_pais { get => sNombre_pais; set => sNombre_pais = value; }
        public string SCapital_pais { get => sCapital_pais; set => sCapital_pais = value; }
        public int IEstado_pais { get => iEstado_pais; set => iEstado_pais = value; }
    }
}
