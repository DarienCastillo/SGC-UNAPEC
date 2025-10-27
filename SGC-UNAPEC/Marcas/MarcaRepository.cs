using Microsoft.Data.SqlClient;
using System.Data;

namespace SGC_UNAPEC.Modules.Marcas
{
    internal class MarcaRepository
    {
        public DataTable GetAll()
        {
            using var con = DBConnection.GetOpen();
            using var cmd = new SqlCommand("dbo.Marca_GetAll", con)
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
            using var cmd = new SqlCommand("dbo.Marca_GetById", con)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@MarcaId", id);

            using var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int Insert(Marca m)
        {
            using var con = DBConnection.GetOpen();
            using var cmd = new SqlCommand("dbo.Marca_Insert", con)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@Descripcion", m.Descripcion);
            cmd.Parameters.AddWithValue("@Estado", m.Estado);

            object? res = cmd.ExecuteScalar();
            return (res == null || res == DBNull.Value)
                ? 0
                : Convert.ToInt32(res);
        }

        public void Update(Marca m)
        {
            using var con = DBConnection.GetOpen();
            using var cmd = new SqlCommand("dbo.Marca_Update", con)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@MarcaId", m.MarcaId);
            cmd.Parameters.AddWithValue("@Descripcion", m.Descripcion);
            cmd.Parameters.AddWithValue("@Estado", m.Estado);

            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var con = DBConnection.GetOpen();
            using var cmd = new SqlCommand("dbo.Marca_Delete", con)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@MarcaId", id);

            cmd.ExecuteNonQuery();
        }
    }
}
