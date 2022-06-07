namespace WebApiKalum.Entities
{
    public class ResultadoExamenAdmision
    {
        public string NoExpediente { get; set; }
        public string Anio { get; set; }
        public string Descricion { get; set; }
        public string Nota { get; set; }
        public virtual List<Aspirante> Aspirante { get; set; }

    }
}