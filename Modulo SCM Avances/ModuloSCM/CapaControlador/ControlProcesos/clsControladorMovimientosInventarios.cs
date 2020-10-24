using CapaModelo;
using CapaModelo.ClasesProcesos;
using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaControlador.ControlProcesos
{
    public class clsControladorMovimientosInventarios
    {
        private clsSentencia sentencia = new clsSentencia(); // instanciar la clase sentencia
        private clsConexion conexion = new clsConexion(); // instanciar la clase conexion 
        private DataTable tabla; // variable tipo DataTable 
        private OdbcDataAdapter datos; // Variable OdbcDataAdapter

        public DataTable obtenerTodosDatos()
        {
            try
            {
                string sComando = "SELECT t.nombre_tipo_movimiento as 'Tipo de Movimiento', m.fecha_movimiento_inventario as 'Fecha', p.nombre_producto as 'Producto', d.cantidad as 'Cantidad', d.origen as 'Origen', d.destino as 'Destino' from tipo_movimiento t inner join movimiento_inventario m on t.pk_id_tipo_movimiento=m.fk_id_tipo_movimiento inner join"+
                                   " movimiento_inventario_detalle d on d.fk_id_movimiento_inventario = m.pk_id_movimiento_inventario inner join productoscm p on d.fk_id_producto = p.pk_id_producto where p.estado_producto = 1; ";
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

        public DataTable obtenerCamposCombobox(string sCampo1, string sCampo2, string sTabla, string sEstado)
        {
            try
            {
                if (sEstado.Length==0)
                {

                    string sComando = string.Format("SELECT " + sCampo1 + " ," + sCampo2 + " FROM " + sTabla);
                    datos = new OdbcDataAdapter(sComando, conexion.conexion());
                    tabla = new DataTable();
                    datos.Fill(tabla);
                    return tabla;
                }
                else if(sEstado.Length!=0)
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
