using Microsoft.Data.SqlClient;
using System.Data;

namespace SGC_UNAPEC.Modules.Campus
{
    internal class CampusRepository
    {
        public DataTable GetAll()
        {
            using var con = DBConnection.GetOpen();
            using var cmd = new SqlCommand("dbo.Campus_GetAll", con) { CommandType = CommandType.StoredProcedure };
            using var da = new SqlDataAdapter(cmd);
            var dt = new DataTable(); da.Fill(dt); return dt;
        }

        public DataTable GetById(int id)
        {
            using var con = DBConnection.GetOpen();
            using var cmd = new SqlCommand("dbo.Campus_GetById", con) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@CampusId", id);
            using var da = new SqlDataAdapter(cmd);
            var dt = new DataTable(); da.Fill(dt); return dt;
        }

        public int Insert(CampusEntity c)
        {
            using var con = DBConnection.GetOpen();
            using var cmd = new SqlCommand("dbo.Campus_Insert", con) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@Descripcion", c.Descripcion);
            cmd.Parameters.AddWithValue("@Estado", c.Estado);
            object? res = cmd.ExecuteScalar();
            return (res == null || res == DBNull.Value) ? 0 : Convert.ToInt32(res);
        }

        public void Update(CampusEntity c)
        {
            using var con = DBConnection.GetOpen();
            using var cmd = new SqlCommand("dbo.Campus_Update", con) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@CampusId", c.CampusId);
            cmd.Parameters.AddWithValue("@Descripcion", c.Descripcion);
            cmd.Parameters.AddWithValue("@Estado", c.Estado);
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var con = DBConnection.GetOpen();
            using var cmd = new SqlCommand("dbo.Campus_Delete", con) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@CampusId", id);
            cmd.ExecuteNonQuery();
        }
    }
}
