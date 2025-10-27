using Microsoft.Data.SqlClient;
using System.Data;

namespace SGC_UNAPEC.Modules.Proveedores
{
    internal class ProveedorRepository
    {
        public DataTable GetAll()
        {
            using var con = DBConnection.GetOpen();
            using var cmd = new SqlCommand("dbo.Proveedor_GetAll", con)
            {
                CommandType = CommandType.StoredProcedure
            };

            using var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable GetById(int id)
        {
            using var con = DBConnection.GetOpen();
            using var cmd = new SqlCommand("dbo.Proveedor_GetById", con)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@ProveedorId", id);

            using var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int Insert(Proveedor p)
        {
            using var con = DBConnection.GetOpen();
            using var cmd = new SqlCommand("dbo.Proveedor_Insert", con)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
            cmd.Parameters.AddWithValue("@RNC", (object?)p.RNC ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Telefono", (object?)p.Telefono ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Email", (object?)p.Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Direccion", (object?)p.Direccion ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Estado", p.Estado);

            object? res = cmd.ExecuteScalar();
            return (res == null || res == DBNull.Value) ? 0 : Convert.ToInt32(res);
        }

        public void Update(Proveedor p)
        {
            using var con = DBConnection.GetOpen();
            using var cmd = new SqlCommand("dbo.Proveedor_Update", con)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@ProveedorId", p.ProveedorId);
            cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
            cmd.Parameters.AddWithValue("@RNC", (object?)p.RNC ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Telefono", (object?)p.Telefono ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Email", (object?)p.Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Direccion", (object?)p.Direccion ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Estado", p.Estado);

            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var con = DBConnection.GetOpen();
            using var cmd = new SqlCommand("dbo.Proveedor_Delete", con)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@ProveedorId", id);

            cmd.ExecuteNonQuery();
        }
    }
}
