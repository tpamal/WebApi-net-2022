namespace WebApiKalum.Entities
{
    public class ExamenAdmision
    {
        public string ExamenId { get; set; }
        public DateTime FechaExamen { get; set;}

        public virtual List<Aspirante> Aspirante {get; set;}
    }
}