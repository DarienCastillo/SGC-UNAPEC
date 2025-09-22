using System;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace SGC_UNAPEC
{
    public partial class TableroForm : Form
    {
        public TableroForm()
        {
            InitializeComponent();
            CargarVentasHoy();
            CargarPedidosPendientes();
            ProductosStockCritico();
            CargarIngresosEsteMes();
            ProductosFueraStock();
            CargarClientesNuevosHoy();
            CargarClientesAtendidosHoy();
        }

        DBConnection dbConnection = new DBConnection();
        //Cargar datos en las tarjetas del tablero
        private void CargarVentasHoy()
        {
            string query = "SELECT ISNULL(SUM(monto_articulo), 0) FROM facturacion_articulos WHERE CONVERT(date, fecha_venta) = CONVERT(date, GETDATE()) AND estado = 1";
            int ventasHoy = dbConnection.ExecuteScalarQuery(query);
            ventasDataLbl.Content = ventasHoy.ToString();
        }

        private void CargarPedidosPendientes() 
        {
            string query = "SELECT COUNT(*) FROM facturacion_articulos WHERE estado = 1;";
            int pedidosPendientes = dbConnection.ExecuteScalarQuery(query);
            pedidosPendientesDataLbl.Content = pedidosPendientes.ToString(); 
        }

        private void ProductosStockCritico()
        {
            string query = "SELECT COUNT(*) FROM articulos WHERE existencia <= 5 AND estado = 1;";
            int productosStockCritico = dbConnection.ExecuteScalarQuery(query);
            productosStockCriticoDataLbl.Content = productosStockCritico.ToString();
        }

        private void CargarIngresosEsteMes()
        {
            string query = "SELECT ISNULL(SUM(monto_articulo), 0) FROM facturacion_articulos WHERE MONTH(fecha_venta) = MONTH(GETDATE()) AND YEAR(fecha_venta) = YEAR(GETDATE()) AND estado = 1;";
            int ingresosEsteMes = dbConnection.ExecuteScalarQuery(query);
            ingresosDataLbl.Content = ingresosEsteMes.ToString();
        }
        private void ProductosFueraStock()
        {
            string query = "SELECT COUNT(*) FROM articulos WHERE existencia = 0 AND estado = 1;";
            int productosFueraStock = dbConnection.ExecuteScalarQuery(query);
            productosFueraStockDataLbl.Content = productosFueraStock.ToString();
        }

        private void CargarClientesNuevosHoy() 
        {
            string query = "SELECT COUNT(*) FROM usuarios WHERE CONVERT(date, fecha_registro) = CONVERT(date, GETDATE()) AND estado = 1;";
            int clientesNuevosHoy = dbConnection.ExecuteScalarQuery(query);
            clientesNuevosHoyDataLbl.Content = clientesNuevosHoy.ToString();
        }

        private void CargarClientesAtendidosHoy()
        {
            string query = "SELECT COUNT(DISTINCT usuario_id) FROM facturacion_articulos WHERE CONVERT(date, fecha_venta) = CONVERT(date, GETDATE()) AND estado = 1;";
            int clientesAtendidosHoy = dbConnection.ExecuteScalarQuery(query);
            clientesAtendidosHoyDataLbl.Content = clientesAtendidosHoy.ToString();
        }

    }
}
