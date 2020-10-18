using CapaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using CapaModelo.Clases_Modulo;
using System.Windows.Forms;

namespace CapaControlador.ControladorModulo
{
    public class clsControladorVehiculo
    {

        clsSentencia sentencia = new clsSentencia(); // instanciar la clase sentencia
        clsConexion conexion = new clsConexion(); // instanciar la conexion
        private DataTable tabla; // variable tipo Datatable
        private OdbcDataAdapter datos; // variable tipo OdbcDataAdapter

        // Metodo para guardar los datos ingresados
        public void insertarVehiculo(clsVehiculo vehiculo)
        {
            try
            {
                string sComando = string.Format("INSERT INTO VEHICULO(fk_id_marca, placa_vehiculo, modelo_vehiculo, color_vehiculo, anio_vehiculo, tipo_combustible_vehiculo,  estado_vehiculo) VALUES ({0},'{1}','{2}','{3}', '{4}','{5}',{6});", vehiculo.IdMarca, vehiculo.SPlaca_vehiculo, vehiculo.SModelo_vehiculo, vehiculo.SColor_vehiculo, vehiculo.SAnio_vehiculo, vehiculo.STpo_Combustible_vehiculo, vehiculo.IEstado_vehiculo);
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
                string sComando = string.Format("SELECT fk_id_marca, placa_vehiculo, modelo_vehiculo, color_vehiculo, anio_vehiculo, tipo_combustible_vehiculo  FROM VEHICULO WHERE  estado_vehiculo=1");
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
