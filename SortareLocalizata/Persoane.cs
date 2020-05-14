namespace SortareLocalizata
{
    internal class Persoane
    {
        public string nume { get; set; }
        public string prenume { get; set; } 
        public Persoane(string nume, string prenume)
        {
            this.nume = nume;
            this.prenume = prenume;
        }
        public static string Capital(string capital)
        {
            capital.ToUpper();
            return capital;
        }
    }
}