using System.Data;

namespace SGC_UNAPEC.Modules.Marcas
{
    internal class MarcaService
    {
        private readonly MarcaRepository _repo = new MarcaRepository();

        public DataTable Listar()
        {
            return _repo.GetAll();
        }

        public Marca? Obtener(int id)
        {
            var dt = _repo.GetById(id);
            if (dt.Rows.Count == 0) return null;

            var r = dt.Rows[0];

            return new Marca
            {
                MarcaId = (int)r["MarcaId"],
                Descripcion = r["Descripcion"].ToString()!,
                Estado = (bool)r["Estado"],
                FechaCreacion = (DateTime)r["FechaCreacion"],
                FechaActualizacion = r["FechaActualizacion"] == DBNull.Value
                    ? null
                    : (DateTime?)r["FechaActualizacion"]
            };
        }

        public int Crear(Marca m)
        {
            Validar(m);
            return _repo.Insert(m);
        }

        public void Editar(Marca m)
        {
            if (m.MarcaId <= 0)
                throw new Exception("Id inválido.");
            Validar(m);
            _repo.Update(m);
        }

        public void Eliminar(int id)
        {
            if (id <= 0)
                throw new Exception("Id inválido.");
            _repo.Delete(id);
        }

        private static void Validar(Marca m)
        {
            if (string.IsNullOrWhiteSpace(m.Descripcion))
                throw new Exception("Descripción requerida.");

            if (m.Descripcion.Length > 150)
                throw new Exception("Descripción demasiado larga (máx. 150).");
        }
    }
}
