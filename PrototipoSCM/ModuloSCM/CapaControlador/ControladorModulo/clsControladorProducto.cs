using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo.Clases_Modulo;
using System.Windows.Forms;

namespace CapaControlador.ControladorModulo
{
   public class clsControladorProducto
    {
        clsSentencia sentencia = new clsSentencia(); // instanciar la clase sentencia
        clsConexion conexion = new clsConexion(); // instanciar la conexion
        private DataTable tabla; // variable tipo Datatable
        private OdbcDataAdapter datos; // variable tipo OdbcDataAdapter

        // Metodo para guardar los datos ingresados
        public void insertarProducto(clsProducto producto)
        {
            try
            {
                string sComando = string.Format("INSERT INTO PRODUCTO(fk_id_linea_producto, fk_id_categoria_producto, nombre_producto, precio_producto,  medida_producto, descripcion_producto, estado_producto) VALUES ({0}, {1},'{2}',{3}, {4},'{5}',{6});", producto.ILinea_Producto, producto.ICategoria_producto, producto.Snombre_producto, producto.DPrecio_producto, producto.DMedida_producto, producto.SDescripcion_producto, producto.IEstado);
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
                string sComando = string.Format("SELECT pk_id_producto, fk_id_linea_producto, fk_id_categoria_producto, nombre_producto, precio_producto,  medida_producto, descripcion_producto FROM PRODUCTO WHERE  estado_producto=1");
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

        // Metodo para obtener los datos en el combo box  para llenarlo
        public DataTable obtenerCamposCombobox(string sCampo1, string sCampo2, string sTabla, string sEstado)
        {
            try
            {
                string sComando = string.Format("SELECT " + sCampo1 + " ," + sCampo2 + " FROM " + sTabla + " WHERE " + sEstado + "=1");
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
