using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using CapaModelo;
using CapaModelo.Clases_Modulo;
using System.Windows.Forms;

namespace CapaControlador.ControladorModulo
{
    public class clsControladorCategoriaProducto
    {
        clsSentencia sentencia = new clsSentencia(); // instanciar la clase sentencia
        clsConexion conexion = new clsConexion(); // instanciar la conexion
        private DataTable tabla; // variable tipo Datatable
        private OdbcDataAdapter datos; // variable tipo OdbcDataAdapter


        // Metodo para guardar los datos ingresados
        public void insertarCategoria(clsCategoriaProducto categoria)
        {
            try
            {
                string sComando = string.Format("INSERT INTO CATEGORIA_PRODUCTO(descripcion_categoria_producto,  estado_categoria_producto) VALUES ('{0}',{1});", categoria.SDescripcion_Categoria_producto, categoria.IEstado_Categoria_producto);
                this.sentencia.ejecutarQuery(sComando);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        // Metodo para obtener los datos en el Datagriv
        public DataTable obtenerTodo()
        {

            try
            {
                string sComando = string.Format("SELECT pk_id_categoria_producto, descripcion_categoria_producto FROM CATEGORIA_PRODUCTO WHERE  estado_categoria_producto=1");
                datos = new OdbcDataAdapter(sComando, conexion.conexion());
                tabla = new DataTable();
                datos.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos");
                Console.WriteLine(ex.Message);
                return null;
            }
        }

    }
}
