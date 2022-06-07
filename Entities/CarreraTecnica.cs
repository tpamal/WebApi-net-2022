namespace WebApiKalum.Entities
{
    public class CarreraTecnica
    {
        public string CarreraI { get; set; }

        public string Nombre { get; set; }
        public virtual List<Aspirante> Aspirante { get; set; }
        public virtual List<Inscripcion> Inscripcion { get; set; }
        public virtual List<InvesionCarreraTecnica> InversionCarreraTecnica { get; set; }
        public InvesionCarreraTecnica invesionCarreraTecnica { get; set; }


    }
}
