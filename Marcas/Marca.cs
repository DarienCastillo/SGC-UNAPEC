namespace SGC_UNAPEC.Modules.Marcas
{
    public class Marca
    {
        public int MarcaId { get; set; }                  
        public string Descripcion { get; set; } = "";     
        public bool Estado { get; set; } = true;          
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
    }
}
