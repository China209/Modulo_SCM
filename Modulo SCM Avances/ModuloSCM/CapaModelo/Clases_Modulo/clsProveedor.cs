using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo.Clases_Modulo
{
    public class clsProveedor
    {
        private int idProveedor;
        private int iIdPais;
        private string sRazon_social;
        private string sRepresentantelegal;
        private string snit_Proveedor;
        private int iEstado_proveedor;

        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public int IIdPais { get => iIdPais; set => iIdPais = value; }
        public string SRazon_social { get => sRazon_social; set => sRazon_social = value; }
        public string SRepresentantelegal { get => sRepresentantelegal; set => sRepresentantelegal = value; }
        public string Snit_Proveedor { get => snit_Proveedor; set => snit_Proveedor = value; }
        public int IEstado_proveedor { get => iEstado_proveedor; set => iEstado_proveedor = value; }
    }
}
