
namespace WebApiKalum.Entities
{
    public class Aspirante
    {
        public string NoExpediente { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set;}
        public string Telefono { get; set; }
        public string Email { get; set;}
        public string Estatus { get; set; }
        public string ExamenId { get; set; }
        public CarreraTecnica carreraTecnica { get; set; }
        public Jornada jornada { get; set; }
        public virtual ExamenAdmision ExamenAdmision { get; set; }

        }
}
