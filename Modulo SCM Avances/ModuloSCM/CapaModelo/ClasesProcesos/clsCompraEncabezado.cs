using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo.ClasesProcesos
{
    public class clsCompraEncabezado
    {
        private int idCompra;
        private int idProveedor;
        private DateTime FechaCompra;
        private double totalCompra;
        private int Estado;

        public int IdCompra { get => idCompra; set => idCompra = value; }
        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public DateTime FechaCompra1 { get => FechaCompra; set => FechaCompra = value; }
        public double TotalCompra { get => totalCompra; set => totalCompra = value; }
        public int Estado1 { get => Estado; set => Estado = value; }
    }
}
