using System.Data;

namespace SGC_UNAPEC.Modules.Proveedores
{
    internal class ProveedorService
    {
        private readonly ProveedorRepository _repo = new();

        public DataTable Listar()
        {
            return _repo.GetAll();
        }

        public DataTable ObtenerPorId(int id)
        {
            return _repo.GetById(id);
        }

        public int Crear(Proveedor p)
        {
            if (string.IsNullOrWhiteSpace(p.Nombre))
                throw new Exception("El nombre del proveedor es obligatorio.");

            return _repo.Insert(p);
        }

        public void Actualizar(Proveedor p)
        {
            if (p.ProveedorId <= 0)
                throw new Exception("ID inválido.");

            if (string.IsNullOrWhiteSpace(p.Nombre))
                throw new Exception("El nombre del proveedor es obligatorio.");

            _repo.Update(p);
        }

        public void Eliminar(int id)
        {
            if (id <= 0)
                throw new Exception("ID inválido.");

            _repo.Delete(id);
        }
    }
}
