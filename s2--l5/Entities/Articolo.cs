using System.ComponentModel.DataAnnotations;

namespace s2__l5.Entities
{
    public class Articolo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Il nome dell'articolo è obbligatorio.")]
        public string Nome { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Il prezzo deve essere maggiore di zero.")]
        public decimal Prezzo { get; set; }

        [Required(ErrorMessage = "La descrizione dell'articolo è obbligatoria.")]
        public string Descrizione { get; set; }

        public IFormFile? ImgCopertina { get; set; }

        public IFormFile? ImgProdotto1 { get; set; }
        public IFormFile? ImgProdotto2 { get; set; }

    }
}
