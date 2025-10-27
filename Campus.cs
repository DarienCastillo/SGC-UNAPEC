namespace SGC_UNAPEC.Modules.Campus
{
    public class CampusEntity
    {
        public int CampusId { get; set; }               // Identificador
        public string Descripcion { get; set; } = "";   // Descripción
        public bool Estado { get; set; } = true;        // Estado
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
