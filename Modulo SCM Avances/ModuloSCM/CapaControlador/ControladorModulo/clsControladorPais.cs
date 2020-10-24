using System;
using System.Data;
using System.Data.Odbc;
using CapaModelo;
using CapaModelo.Clases_Modulo;
using System.Windows.Forms;

namespace CapaControlador.ControladorModulo
{
    public class clsControladorPais
    {
        clsSentencia sentencia = new clsSentencia(); // instanciar la clase sentencia
        clsConexion conexion = new clsConexion(); // instanciar la conexion
        private DataTable tabla; // variable tipo Datatable
        private OdbcDataAdapter datos; // variable tipo OdbcDataAdapter

        // Metodo para guardar los datos ingresados
        public void insertarPais(clsPais pais)
        {
            try
            {
                string sComando = string.Format("INSERT INTO PAIS( nombre_pais, capital_pais, estado_pais) VALUES ('{0}','{1}',{2});", pais.SNombre_pais, pais.SCapital_pais, pais.IEstado_pais);
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
                string sComando = string.Format("SELECT pk_id_pais,  nombre_pais, capital_pais FROM  PAIS WHERE  estado_pais=1");
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
