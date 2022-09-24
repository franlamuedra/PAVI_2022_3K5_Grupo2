namespace TPI.dominio
{
    public class Tipo_Herramienta
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Tipo_Herramienta(int cod, string nom, string des)
        {
            Codigo = cod;
            Nombre = nom;
            Descripcion = des;
        }
    }
}