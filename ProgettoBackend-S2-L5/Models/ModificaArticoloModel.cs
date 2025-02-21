using System.ComponentModel.DataAnnotations;

namespace ProgettoBackend_S2_L5.Models
{
    public class ModificaArticoloModel
    {
    public Guid Id { get; set; }

    [Display(Name = "Nome")]
    [Required(ErrorMessage = "Il nome dell'articolo è obbligatorio!")]
    [StringLength(20, ErrorMessage = "Il nome deve essere compreso tra 5 e 20 caratteri", MinimumLength = 5)]
    public string? Nome { get; set; }

    [Display(Name = "Descrizione")]
    [Required(ErrorMessage = "La descrizione dell'articolo è obbligatoria!")]
    [StringLength(1000, ErrorMessage = "La descrizione deve essere compresa tra 10 e 1000 caratteri", MinimumLength = 10)]
    public string? Descrizione { get; set; }

        [Display(Name = "Prezzo")]
        [Required(ErrorMessage = "Il prezzo è obbligatorio")]
        [Range(0.01, 9999.99, ErrorMessage = "Il prezzo deve essere tra 0.01 e 9999.99")]
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true)]
        public decimal Prezzo { get; set; }

    [Display(Name = "Copertina")]
    [Required(ErrorMessage = "L'URL per l'immagine di copertina è obbligatorio!")]
    public string Copertina { get; set; }

    [Display(Name = "Immagine2")]
    [Required(ErrorMessage = "L'URL per la seconda è obbligatorio!")]
    public string Immagine2 { get; set; }

    [Display(Name = "Immagine3")]
    [Required(ErrorMessage = "L'URL per la terza immagine è obbligatorio!")]
    public string Immagine3 { get; set; }
}
}
