using CapaModelo;
using CapaModelo.Clases_Modulo;
using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaControlador.ControladorModulo
{
    public class clsControlDepartamento
    {
        
        clsSentencia sentencia = new clsSentencia();
        clsConexion conexion = new clsConexion();
        private DataTable tabla;
        private OdbcDataAdapter datos;

        public void insertarDepartamento(clsDepartamento departamento)
        {
            try
            {
                string sComando = string.Format("INSERT INTO DEPARTAMENTO(pk_id_departamento, nombre_departamento, descripcion_departamento, estado_departamento) VALUES ({0},'{1}','{2}',{3});", departamento.IIDeparmeto, departamento.SNombre, departamento.SDescripcion, departamento.IEstado);
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
                string sComando = string.Format("SELECT * FROM DEPARTAMENTO where estado_departamento = 1;");
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
