using CapaModelo;
using CapaModelo.Clases_Modulo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaControlador.ControladorModulo
{
   public class clsControlMarca
    {
        clsSentencia sentencia = new clsSentencia();
        clsConexion conexion = new clsConexion();
        private DataTable tabla;
        private OdbcDataAdapter datos;

        public void insertarMarca(clsMarca marca)
        {
            try
            {
                string sComando = string.Format("INSERT INTO MARCA(pk_id_marca, descripcion_marca, estado_marca) VALUES ({0},'{1}', {2});", marca.IIMarca, marca.SDescripcion, marca.IEstado);
                this.sentencia.ejecutarQuery(sComando);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        public DataTable obtenerDatos(int iMarca)
        {
            try
            {
                string sComando = string.Format("SELECT pk_id_marca FROM MARCA WHERE estado_marca=1 AND pk_id_modulo={0};", iMarca.ToString());
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

        public DataTable obtenerTodo()
        {

            try
            {
                string sComando = string.Format("SELECT * FROM MARCA where estado_marca = 1;");
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
