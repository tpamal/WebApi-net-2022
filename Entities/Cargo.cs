namespace WebApiKalum.Entities
{
    public class Cargo
    {
        public string CargoId { get; set; }
        public string Descricion { get; set; }
        public string Prejifo { get; set; }
        public string Monto { get; set; }
        public bool GeneraMora { get; set; }
        public int PorCentajeMora { get; set; }
        public virtual List<CuentasPorCobrar> AspiCuentasPorCobrarrante { get; set; }
 
    }
}