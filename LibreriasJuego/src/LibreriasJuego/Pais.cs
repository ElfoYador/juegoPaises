namespace LibreriasJuego
{
    public class Pais: IPais
    {
        public Pais(string nombre, string capital,IContinente continente) {
            this.nombre = nombre;
            this.capital = capital;
            this.continente = continente;
        }
        public string nombre { get; }
        public string capital { get; }

        public IContinente continente { get; }

    }
}