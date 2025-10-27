using System.Data;
using System.Text.RegularExpressions;

namespace SGC_UNAPEC.Modules.Cafeterias
{
    internal class CafeteriaService
    {
        private readonly CafeteriaRepository _repo = new CafeteriaRepository();

        public DataTable Listar() => _repo.GetAll();

        public Cafeteria? Obtener(int id)
        {
            var dt = _repo.GetById(id);
            if (dt.Rows.Count == 0) return null;
            var r = dt.Rows[0];
            return new Cafeteria
            {
                CafeteriaId = (int)r["CafeteriaId"],
                Nombre = r["Nombre"].ToString()!,
                Campus = r["Campus"].ToString()!,
                Encargado = r["Encargado"] as string,
                Telefono = r["Telefono"] as string,
                Email = r["Email"] as string,
                Estado = (bool)r["Estado"],
                FechaCreacion = (DateTime)r["FechaCreacion"],
                FechaActualizacion = r["FechaActualizacion"] == DBNull.Value ? null : (DateTime?)r["FechaActualizacion"]
            };
        }

        public int Crear(Cafeteria c)
        {
            Validar(c);
            return _repo.Insert(c);
        }

        public void Editar(Cafeteria c)
        {
            if (c.CafeteriaId <= 0) throw new Exception("Id inválido.");
            Validar(c);
            _repo.Update(c);
        }

        public void Eliminar(int id)
        {
            if (id <= 0) throw new Exception("Id inválido.");
            _repo.Delete(id);
        }

        private static void Validar(Cafeteria c)
        {
            if (string.IsNullOrWhiteSpace(c.Nombre)) throw new Exception("Nombre requerido.");
            if (string.IsNullOrWhiteSpace(c.Campus)) throw new Exception("Campus requerido.");
            if (!string.IsNullOrWhiteSpace(c.Email))
            {
                var rx = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                if (!rx.IsMatch(c.Email)) throw new Exception("Email inválido.");
            }
        }
    }
}
