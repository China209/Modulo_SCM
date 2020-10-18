using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo.Clases_Modulo
{
    // Metodo para enviar y obtener los datos de Categoria
    public class clsCategoriaProducto
    {

        private int idCategoriaProducto;
        private string sDescripcion_Categoria_producto;
        private int iEstado_Categoria_producto;

        public int IdCategoriaProducto { get => idCategoriaProducto; set => idCategoriaProducto = value; }
        public string SDescripcion_Categoria_producto { get => sDescripcion_Categoria_producto; set => sDescripcion_Categoria_producto = value; }
        public int IEstado_Categoria_producto { get => iEstado_Categoria_producto; set => iEstado_Categoria_producto = value; }
    }
}
