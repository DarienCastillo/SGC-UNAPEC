using System.Data;
using System.Text.RegularExpressions;

namespace SGC_UNAPEC.Modules.Campus
{
    internal class CampusService
    {
        private readonly CampusRepository _repo = new CampusRepository();

        public DataTable Listar() => _repo.GetAll();

        public CampusEntity? Obtener(int id)
        {
            var dt = _repo.GetById(id);
            if (dt.Rows.Count == 0) return null;
            var r = dt.Rows[0];
            return new CampusEntity
            {
                CampusId = (int)r["CampusId"],
                Descripcion = r["Descripcion"].ToString()!,
                Estado = (bool)r["Estado"],
                FechaCreacion = (DateTime)r["FechaCreacion"],
                FechaActualizacion = r["FechaActualizacion"] == DBNull.Value ? null : (DateTime?)r["FechaActualizacion"]
            };
        }

        public int Crear(CampusEntity c)
        {
            Validar(c);
            return _repo.Insert(c);
        }

        public void Editar(CampusEntity c)
        {
            if (c.CampusId <= 0) throw new Exception("Id inválido.");
            Validar(c);
            _repo.Update(c);
        }

        public void Eliminar(int id)
        {
            if (id <= 0) throw new Exception("Id inválido.");
            _repo.Delete(id);
        }

        private static void Validar(CampusEntity c)
        {
            if (string.IsNullOrWhiteSpace(c.Descripcion))
                throw new Exception("Descripción requerida.");
            if (c.Descripcion.Length > 150)
                throw new Exception("Descripción demasiado larga (máx. 150).");
        }
    }
}
