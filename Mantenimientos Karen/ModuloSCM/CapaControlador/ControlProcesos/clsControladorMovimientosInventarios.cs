/*
 Clase Controlador de Movimientos de Inventario
 */
using CapaModeloModuloSCM;
using CapaModeloModuloSCM.ClasesProcesos;
using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaControladorModuloSCM.ControlProcesos
{
    public class clsControladorMovimientosInventarios
    {
        private clsSentencia sentencia = new clsSentencia(); // instanciar la clase sentencia
        private clsConexion conexion = new clsConexion(); // instanciar la clase conexion 
        private DataTable tabla; // variable tipo DataTable 
        private OdbcDataAdapter datos; // Variable OdbcDataAdapter

        
        //Obtener Datos con los que han de visualizar los combobox
        public DataTable obtenerCamposCombobox(string sCampo1, string sCampo2, string sTabla, string sEstado)
        {
            try
            {
                if (sEstado.Length==0)//Si no llega a recibir un estado como campo
                {
                    string sComando = string.Format("SELECT " + sCampo1 + " ," + sCampo2 + " FROM " + sTabla);
                    datos = new OdbcDataAdapter(sComando, conexion.conexion());
                    tabla = new DataTable();
                    datos.Fill(tabla);
                    return tabla;
                }
                else if(sEstado.Length!=0)//Si existe el campo estado
                {
                    string sComando = string.Format("SELECT " + sCampo1 + " ," + sCampo2 + " FROM " + sTabla + " WHERE " + sEstado + "=1");
                    datos = new OdbcDataAdapter(sComando, conexion.conexion());
                    tabla = new DataTable();
                    datos.Fill(tabla);
                    return tabla;
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos");
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        //Obtener el destino y ruta que sean iguales al id que se ingreso, se realiza la respectiva busqueda
        public string[] obtenerCamposRuta(int iID)
        {
            string[] datos=new string[2];
            try
            {
                string sComando = "select origen_ruta, destino_ruta from ruta where pk_id_ruta =" + iID;
                OdbcCommand comando = new OdbcCommand(sComando, conexion.conexion());
                OdbcDataReader registro = comando.ExecuteReader();

                int iPiv = 0;
                while (registro.Read() && iPiv<datos.Length)
                {
                    datos[iPiv] = registro["origen_ruta"].ToString();
                    iPiv++;
                    datos[iPiv] = registro["destino_ruta"].ToString();
                }
                return datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos de reportes");
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        //Se generan ID automatico
        public int generarID(string sTabla, string sCampo)
        {
            OdbcConnection con = conexion.conexion();
            OdbcCommand comando = con.CreateCommand();
            int iIdNuevo;
            try
            {
                comando.CommandText = "SELECT max(" + sCampo + ") from " + sTabla + ";";
                int.TryParse(comando.ExecuteScalar().ToString(), out iIdNuevo);
                return (iIdNuevo+1);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                MessageBox.Show("Error al Generar el Id Nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        //Insertar datos a tablas
        public void insertarMovimientos(clsMantenimientoInventario movimiento)
        {
            OdbcConnection con = conexion.conexion();
            OdbcCommand comando = con.CreateCommand();
            OdbcTransaction transaction;
            transaction = con.BeginTransaction();
            comando.Connection = con;
            comando.Transaction = transaction;
            try
            {
                comando.CommandText = "INSERT INTO movimiento_inventario (pk_id_movimiento_inventario, fecha_movimiento_inventario, fk_id_tipo_movimiento) VALUES (?,?,?);";
                MessageBox.Show(movimiento.IdMovimiento.ToString());
                comando.Parameters.Add("pk_id_movimiento_inventario", OdbcType.Int).Value = movimiento.IdMovimiento;
                comando.Parameters.Add("fecha_movimiento_inventario", OdbcType.DateTime).Value = movimiento.DtFecha;
                comando.Parameters.Add("fk_id_tipo_movimiento", OdbcType.Int).Value = movimiento.IdTipoMovimiento;
                comando.ExecuteNonQuery();
                transaction.Commit();
                conexion.desconexion(con);
                Console.WriteLine("Transaccion Exitosa Tabla 1");
                try
                {
                    con = conexion.conexion();
                    comando = con.CreateCommand();
                    transaction = con.BeginTransaction();
                    comando.Connection = con;
                    comando.Transaction = transaction;
                    comando.CommandText = "INSERT INTO movimiento_inventario_detalle (pk_id_movimiento_inventario_detalle, fk_id_movimiento_inventario, fk_id_producto, cantidad, origen, destino) VALUES (?,?,?,?,?,?);";
                    MessageBox.Show(movimiento.IdMovimiento.ToString());
                    comando.Parameters.Add("pk_id_movimiento_inventario_detalle", OdbcType.Int).Value = movimiento.IdMovimientoDetalle;
                    comando.Parameters.Add("fk_id_movimiento_inventario", OdbcType.Int).Value = movimiento.IdMovimiento;
                    comando.Parameters.Add("fk_id_producto", OdbcType.Int).Value = movimiento.IdProducto;
                    comando.Parameters.Add("cantidad", OdbcType.Int).Value = movimiento.ICantidad;
                    comando.Parameters.Add("origen", OdbcType.Int).Value = movimiento.SOrigen;
                    comando.Parameters.Add("destino", OdbcType.Int).Value = movimiento.SDestino;
                    comando.ExecuteNonQuery();
                    transaction.Commit();
                    Console.WriteLine("Transaccion Exitosa Tabla 2");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine(ex.Message);
                }
                
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Error al Ingresar Datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }
    }
}
