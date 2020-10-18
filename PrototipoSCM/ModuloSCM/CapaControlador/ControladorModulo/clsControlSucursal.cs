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

   public class clsControlSucursal
    {

        clsSentencia sentencia = new clsSentencia();
        clsConexion conexion = new clsConexion();
        DataTable tabla;
        OdbcDataAdapter datos;

        public void insertarSucursal(clsSucursal sucursal)
        {
            try
            {
                string sComando = string.Format("INSERT INTO SUCURSAL(pk_id_sucursal,fk_id_municipio,nombre_sucursal,direccion_sucursal,telefono_sucursal,descripcion_sucursal,estado_sucursal) VALUES ({0},{1},'{2}','{3}',{4},'{5}',{6});", sucursal.IIDSucursal, sucursal.IMunicipio, sucursal.SNombre, sucursal.Sdireccion, sucursal.ITelefono, sucursal.SDescripcion, sucursal.IEstado);
                this.sentencia.ejecutarQuery(sComando);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ingresar ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }
        public DataTable obtenerTodo()
        {

            try
            {
                string sComando = string.Format("SELECT * FROM SUCURSAL where estado_sucursal = 1");
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



        public DataTable obtenerCamposCombobox()
        {
            try
            {
                string sComando = string.Format("SELECT pk_id_municipio, nombre_municipio FROM MUNICIPIO WHERE estado_municipio=1");
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