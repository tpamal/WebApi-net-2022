namespace WebApiKalum.Entities
{
    public class InvesionCarreraTecnica
    {
        public string Inversion { get; set; }
        public string CarreraId { get; set; }
        public string MontoIncripcion { get; set; }
        public string NumeroPagos { get; set; }
        public string MontoPagos { get; set; }
        
        public Aspirante aspirante { get; set; }

    }
}