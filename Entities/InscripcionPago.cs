namespace WebApiKalum.Entities
{
    public class InscripcionPago
    {
        public string BoletaPago { get; set; }
        public string NoExpediente { get; set; }
        public string Anio { get; set; }
        public string FechaPago { get; set; }
        public string Monto { get; set; }
        public virtual List<Aspirante> Aspirante { get; set; }

    }
}