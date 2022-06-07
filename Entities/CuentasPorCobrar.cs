namespace WebApiKalum.Entities
{
    public class CuentasPorCobrar
    {
        public string Correlativo { get; set; }
        public string Anio { get; set; }
        public string Carne { get; set; }
        public string CargoId { get; set; }
        public string Descricion { get; set; }
        public DateTime FechaCargo { get; set; }
        public DateTime FechaAplica { get; set; }
        public string Monto { get; set; }
        public string Mora { get; set; }
        public string Descuento { get; set; }
        public virtual List<Alumno> Alumno {get; set;}
        public Cargo cargo { get; set; }

    }
}