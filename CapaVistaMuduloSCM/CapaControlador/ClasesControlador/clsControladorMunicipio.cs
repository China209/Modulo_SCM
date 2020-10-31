using CapaModelo;
using CapaModelo.ClasesModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaControlador.ClasesControlador
{
  public  class clsControlMunicipio
    {



        clsSentencia sentencia = new clsSentencia();
        clsConexion conexion = new clsConexion();
        DataTable tabla;
        OdbcDataAdapter datos;

        public void insertarMunicipio(clsMunicipio municipio)
        {
            try
            {
                string sComando = string.Format("INSERT INTO MUNICIPIO(pk_id_municipio,fk_id_departamento, nombre_municipio, descripcion_municipio, estado_municipio) VALUES ({0},{1},'{2}','{3}',{4});", municipio.IIDMunicipio, municipio.IDepartamento, municipio.SNombre, municipio.SDescripcion, municipio.IEstado);
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
                string sComando = string.Format("SELECT * FROM MUNICIPIO where estado_municipio = 1");
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
                string sComando = string.Format("SELECT pk_id_departamento, nombre_departamento FROM departamento WHERE estado_departamento=1");
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



       /* public DataTable obtenerCamposCombobox(string sCampo1, string sCampo2, string sCampo3,string sCampo4, string sTabla, string sEstado)
        {
            try
            {
                string sComando = string.Format("SELECT " + sCampo1 + "," + sCampo2 + sCampo3 +sCampo4 + " FROM " + sTabla + " WHERE " + sEstado + "=1");
                datos = new OdbcDataAdapter(sComando, conexion.conexion());
                tabla = new DataTable();
                datos.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos del Combo");
                Console.WriteLine(ex.Message);
                return null;
            }
        }*/
    }
}

