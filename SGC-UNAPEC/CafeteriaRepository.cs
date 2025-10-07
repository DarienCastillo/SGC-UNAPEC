using Microsoft.Data.SqlClient;
using System.Data;

namespace SGC_UNAPEC.Modules.Cafeterias
{
    internal class CafeteriaRepository
    {
        public DataTable GetAll()
        {
            using var con = DBConnection.GetOpen();
            using var cmd = new SqlCommand("dbo.Cafeteria_GetAll", con) { CommandType = CommandType.StoredProcedure };
            using var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable GetById(int id)
        {
            using var con = DBConnection.GetOpen();
            using var cmd = new SqlCommand("dbo.Cafeteria_GetById", con) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@CafeteriaId", id);
            using var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int Insert(Cafeteria c)
        {
            using var con = DBConnection.GetOpen();
            using var cmd = new SqlCommand("dbo.Cafeteria_Insert", con) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@Nombre", c.Nombre);
            cmd.Parameters.AddWithValue("@Campus", c.Campus);
            cmd.Parameters.AddWithValue("@Encargado", (object?)c.Encargado ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Telefono", (object?)c.Telefono ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Email", (object?)c.Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Estado", c.Estado);

            object? res = cmd.ExecuteScalar();
            return (res == null || res == DBNull.Value) ? 0 : Convert.ToInt32(res);
        }

        public void Update(Cafeteria c)
        {
            using var con = DBConnection.GetOpen();
            using var cmd = new SqlCommand("dbo.Cafeteria_Update", con) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@CafeteriaId", c.CafeteriaId);
            cmd.Parameters.AddWithValue("@Nombre", c.Nombre);
            cmd.Parameters.AddWithValue("@Campus", c.Campus);
            cmd.Parameters.AddWithValue("@Encargado", (object?)c.Encargado ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Telefono", (object?)c.Telefono ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Email", (object?)c.Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Estado", c.Estado);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var con = DBConnection.GetOpen();
            using var cmd = new SqlCommand("dbo.Cafeteria_Delete", con) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@CafeteriaId", id);
            cmd.ExecuteNonQuery();
        }
    }
}
