using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgenciaTurismo.Models
{
    public class Reserva
    {
        public int Id { get; set; }

        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        [ForeignKey("PacoteTuristico")]
        public int PacoteTuristicoId { get; set; }
        public PacoteTuristico? PacoteTuristico { get; set; }

        public DateTime DataReserva { get; set; }
    }
}
