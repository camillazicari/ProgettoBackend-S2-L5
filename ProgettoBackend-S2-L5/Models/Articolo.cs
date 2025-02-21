namespace ProgettoBackend_S2_L5.Models
{
    public class Articolo
    {
        public Guid Id = Guid.NewGuid();
        public string Nome { get; set; }
        public decimal Prezzo { get; set; }
        public string Descrizione { get; set; }
        public string Copertina { get; set; }
        public string Immagine2 { get; set; }
        public string Immagine3 { get; set; }

    }
}
