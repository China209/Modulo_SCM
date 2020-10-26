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
    public class clsControlRuta
    {
        
        clsSentencia sentencia = new clsSentencia();
        clsConexion conexion = new clsConexion();
        private DataTable tabla;
        private OdbcDataAdapter datos;

        public void insertarRuta(clsRuta ruta)
        {
            try
            {

                string sComando = string.Format("INSERT INTO RUTA(pk_id_ruta, origen_ruta, destino_ruta, descripcion_ruta, estado_ruta) VALUES ({0},'{1}','{2}','{3}', {4});", ruta.IIRuta, ruta.SOrigen, ruta.SDestino, ruta.SDescripcion, ruta.IEstado);
                this.sentencia.ejecutarQuery(sComando);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }


        public DataTable obtenerTodo()
        {

            try
            {
                string sComando = string.Format("SELECT * FROM RUTA where estado_ruta = 1;");
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

