﻿using CapaModelo;
using CapaModelo.ClasesProcesos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaControlador.ControlProcesos
{
    public class clsControladorGestionCompraPedido
    {
        private clsSentencia sentencia = new clsSentencia(); // instanciar la clase sentencia
        private clsConexion conexion = new clsConexion(); // instanciar la clase conexion 
        private DataTable tabla; // variable tipo DataTable 
        private OdbcDataAdapter datos; // Variable OdbcDataAdapter


        public void InsertarFactura(clsCompraEncabezado compraEncabezado)
        {
            OdbcConnection con = conexion.conexion();

            OdbcCommand comando = con.CreateCommand();
            OdbcTransaction transaccion;

            transaccion = con.BeginTransaction();

            comando.Connection = con;
            comando.Transaction = transaccion;
            try
            {
                //Inserta en encabezado de compra
                comando.CommandText = "INSERT INTO compra_encabezado(pk_id_compra_encabezado, fk_id_proveedor, fec_compra_encabezado_compra, total_compra_encabezado_compra, estado_encabezado_compra) VALUES (?,?,?,?,?);";
                comando.Parameters.Add("pk_id_compra_encabezado", OdbcType.Int).Value = compraEncabezado.IdCompra;
                comando.Parameters.Add("fk_id_proveedor", OdbcType.Int).Value = compraEncabezado.IdProveedor;
                comando.Parameters.Add("fec_compra_encabezado_compra", OdbcType.DateTime).Value = compraEncabezado.FechaCompra1;
                comando.Parameters.Add("total_compra_encabezado_compra", OdbcType.Double).Value = compraEncabezado.TotalCompra;
                comando.Parameters.Add("estado_encabezado_compra", OdbcType.Int).Value = compraEncabezado.Estado1;
                comando.ExecuteNonQuery();

                transaccion.Commit();
                Console.WriteLine("Transaccion Exitosa");
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                Console.WriteLine(ex.Message);
                Console.WriteLine("Trasaccion Fallida");
                MessageBox.Show("Error transaccion compras encabezado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void InsertarPedidoE(clsPedidoEncabezado pedidoEncabezado)
        {
            OdbcConnection con = conexion.conexion();

            OdbcCommand comando = con.CreateCommand();
            OdbcTransaction transaccion;

            transaccion = con.BeginTransaction();

            comando.Connection = con;
            comando.Transaction = transaccion;
            try
            {
                //Inserta en encabezado de compra
                comando.CommandText = "INSERT INTO pedido_encabezado(pk_id_pedido_encabezado, fk_id_fabrica, fec_pedido_pedido_encabezado, total_pedido_encabezado, estado_pedido_encabezado) VALUES (?,?,?,?,?);";
                comando.Parameters.Add("pk_id_pedido_encabezado", OdbcType.Int).Value = pedidoEncabezado.IdPedido;
                comando.Parameters.Add("fk_id_fabrica", OdbcType.Int).Value = pedidoEncabezado.IdFabrica;
                comando.Parameters.Add("fec_pedido_pedido_encabezado", OdbcType.DateTime).Value = pedidoEncabezado.FechaPedido1;
                comando.Parameters.Add("total_pedido_encabezado", OdbcType.Double).Value = pedidoEncabezado.TotalPedido;
                comando.Parameters.Add("estado_pedido_encabezado", OdbcType.Int).Value = pedidoEncabezado.Estado1;
                comando.ExecuteNonQuery();

                transaccion.Commit();
                Console.WriteLine("Transaccion Exitosa");
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                Console.WriteLine(ex.Message);
                Console.WriteLine("Trasaccion Fallida");
                MessageBox.Show("Error transaccion pedido encabezado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                return (iIdNuevo + 1);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                MessageBox.Show("Error al Generar el Id Nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public void InsertarDetallePedido(clsPedidoDetalle pedidoDetalle)
        {
            OdbcConnection con = conexion.conexion();

            OdbcCommand comando = con.CreateCommand();
            OdbcTransaction transaccion;

            transaccion = con.BeginTransaction();

            comando.Connection = con;
            comando.Transaction = transaccion;
            try
            {
                //Inserta en detalle de compra
                comando.CommandText = "INSERT INTO pedido_detalle(fk_id_pedido_encabezado, cod_linea_pedido_detalle, fk_id_producto, cantidad_pedido_detalle, precio_unitario_pedido_detalle, subtotal_pedido_detalle, estado_pedido_detalle) VALUES (?,?,?,?,?,?,?);";
                comando.Parameters.Add("fk_id_pedido_encabezado", OdbcType.Int).Value = pedidoDetalle.IdPedido;
                comando.Parameters.Add("cod_linea_pedido_detalle", OdbcType.Int).Value = pedidoDetalle.CodLinea;
                comando.Parameters.Add("fk_id_producto", OdbcType.Int).Value = pedidoDetalle.IdProducto;
                comando.Parameters.Add("cantidad_pedido_detalle", OdbcType.Double).Value = pedidoDetalle.Cantidad1;
                comando.Parameters.Add("precio_unitario_pedido_detalle", OdbcType.Double).Value = pedidoDetalle.PrecioUnitario;
                comando.Parameters.Add("subtotal_pedido_detalle", OdbcType.Double).Value = pedidoDetalle.SubTotal;
                comando.Parameters.Add("estado_pedido_detalle", OdbcType.Int).Value = pedidoDetalle.Estado1;
                comando.ExecuteNonQuery();

                transaccion.Commit();
                Console.WriteLine("Transaccion Exitosa");
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                Console.WriteLine(ex.Message);
                Console.WriteLine("Trasaccion Fallida");
                MessageBox.Show("Error transaccion pedido detalle", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void InsertarDetalleFactura(clsCompraDetalle compraDetalle)
        {
            OdbcConnection con = conexion.conexion();

            OdbcCommand comando = con.CreateCommand();
            OdbcTransaction transaccion;

            transaccion = con.BeginTransaction();

            comando.Connection = con;
            comando.Transaction = transaccion;
            try
            {
                //Inserta en detalle de compra
                comando.CommandText = "INSERT INTO compra_detalle(fk_id_compra_encabezado, cod_linea_compra_detalle, fk_id_producto, cantidad_compra_detalle, precio_unitario_compra_detalle, subtotal_compra_detalle, estado_compra_detalle) VALUES (?,?,?,?,?,?,?);";
                comando.Parameters.Add("fk_id_compra_encabezado", OdbcType.Int).Value = compraDetalle.IdCompra;
                comando.Parameters.Add("cod_linea_compra_detalle", OdbcType.Int).Value = compraDetalle.CodLinea;
                comando.Parameters.Add("fk_id_producto", OdbcType.Int).Value = compraDetalle.IdProducto;
                comando.Parameters.Add("cantidad_compra_detalle", OdbcType.Double).Value = compraDetalle.Cantidad1;
                comando.Parameters.Add("precio_unitario_compra_detalle", OdbcType.Double).Value = compraDetalle.PrecioUnitario;
                comando.Parameters.Add("subtotal_compra_detalle", OdbcType.Double).Value = compraDetalle.SubTotal;
                comando.Parameters.Add("estado_compra_detalle", OdbcType.Int).Value = compraDetalle.Estado1;
                comando.ExecuteNonQuery();

                transaccion.Commit();
                Console.WriteLine("Transaccion Exitosa");
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                Console.WriteLine(ex.Message);
                Console.WriteLine("Trasaccion Fallida");
                MessageBox.Show("Error transaccion compras detalle", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public DataTable obtenerDatos(string Campo1, string Campo2, string Tabla, string Estado)
        {
            try
            {
                string sComando = "select " + Campo1 + " , " + Campo2 + " from " + Tabla + " where " + Estado + "=1;";
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