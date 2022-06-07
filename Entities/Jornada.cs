namespace WebApiKalum.Entities
{
    public class Jornada
    {
        public string JornadaId { get; set; }
        public string NombreCorto { get; set; }
        public string Descricion { get; set; }

        public virtual List<Aspirante> Aspirante { get; set; }
    }
}