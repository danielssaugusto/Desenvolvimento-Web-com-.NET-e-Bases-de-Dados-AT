using System.ComponentModel.DataAnnotations;

namespace AgenciaTurismo.Models
{
    public class PacoteTuristico
    {
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; } = string.Empty;

        [Required]
        public DateTime DataInicio { get; set; }

        [Required]
        public int CapacidadeMaxima { get; set; }

        [Required]
        public decimal Preco { get; set; }

        public List<CidadeDestino> CidadesDestino { get; set; } = new();

        public List<Reserva> Reservas { get; set; } = new();

        // Evento para quando a capacidade for atingida
        public event EventHandler? CapacityReached;

        // Método para adicionar reserva e acionar o evento
        public void AdicionarReserva(Reserva reserva)
        {
            if (Reservas.Count >= CapacidadeMaxima)
            {
                CapacityReached?.Invoke(this, EventArgs.Empty);
                return;
            }

            Reservas.Add(reserva);
        }
    }
}
