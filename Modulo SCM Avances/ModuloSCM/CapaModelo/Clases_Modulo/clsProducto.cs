using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo.Clases_Modulo
{
    // Metodo para enviar y obtener los datos de Producto
    public class clsProducto
    {
        private int idProducto;
        private int iLinea_Producto;
        private int iCategoria_producto;
        private string snombre_producto;
        private double dPrecio_producto;
        private double dMedida_producto;
        private string sDescripcion_producto;
        private int iEstado;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int ILinea_Producto { get => iLinea_Producto; set => iLinea_Producto = value; }
        public int ICategoria_producto { get => iCategoria_producto; set => iCategoria_producto = value; }
        public string Snombre_producto { get => snombre_producto; set => snombre_producto = value; }
        public double DPrecio_producto { get => dPrecio_producto; set => dPrecio_producto = value; }
        public double DMedida_producto { get => dMedida_producto; set => dMedida_producto = value; }
        public string SDescripcion_producto { get => sDescripcion_producto; set => sDescripcion_producto = value; }
        public int IEstado { get => iEstado; set => iEstado = value; }
    }
}
