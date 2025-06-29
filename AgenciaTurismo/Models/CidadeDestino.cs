using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaTurismo.Models
{
    public class CidadeDestino
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; } = string.Empty;

        [ForeignKey("PaisDestino")]
        public int PaisDestinoId { get; set; }
        public PaisDestino? PaisDestino { get; set; }

        public List<PacoteTuristico> PacotesTuristicos { get; set; } = new(); // Muitos para muitos
    }
}
