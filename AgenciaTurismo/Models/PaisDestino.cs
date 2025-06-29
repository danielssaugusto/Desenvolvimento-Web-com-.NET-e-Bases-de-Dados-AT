using System.ComponentModel.DataAnnotations;

namespace AgenciaTurismo.Models
{
    public class PaisDestino
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; } = string.Empty;

        public List<CidadeDestino> Cidades { get; set; } = new();
    }
}
