namespace SGC_UNAPEC.Modules.Cafeterias
{
    public class Cafeteria
    {
        public int CafeteriaId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Campus { get; set; } = string.Empty;
        public string? Encargado { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public bool Estado { get; set; } = true;
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}