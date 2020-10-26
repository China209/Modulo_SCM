using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo.ClasesProcesos
{
    public class clsMantenimientoInventario
    {
        private int idMovimiento;
        private int idTipoMovimiento;
        private int idMovimientoDetalle;
        private int idProducto;
        private int iCantidad;
        private string sOrigen;
        private string sDestino;
        private DateTime dtFecha;

        public int IdMovimiento { get => idMovimiento; set => idMovimiento = value; }
        public int IdTipoMovimiento { get => idTipoMovimiento; set => idTipoMovimiento = value; }
        public int IdMovimientoDetalle { get => idMovimientoDetalle; set => idMovimientoDetalle = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int ICantidad { get => iCantidad; set => iCantidad = value; }
        public string SOrigen { get => sOrigen; set => sOrigen = value; }
        public string SDestino { get => sDestino; set => sDestino = value; }
        public DateTime DtFecha { get => dtFecha; set => dtFecha = value; }
    }
}
