namespace Examen_1
{
    public class Moneda
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Simbolo { get; set; }

        public Moneda(string codigo, string nombre, string simbolo)
        {
            Codigo = codigo;
            Nombre = nombre;
            Simbolo = simbolo;
        }
    }
}
