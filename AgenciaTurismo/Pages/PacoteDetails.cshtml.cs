using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgenciaTurismo.Models;
using AgenciaTurismo.Data;
using Microsoft.EntityFrameworkCore;

namespace AgenciaTurismo.Pages
{
    public class PacoteDetailsModel : PageModel
    {
        public PacoteTuristico? Pacote { get; set; }

        // Simulando dados em memória
        private static List<PacoteTuristico> PacotesFake = new()
        {
            new PacoteTuristico { Id = 1, Titulo = "Pacote Timbo", DataInicio = DateTime.Now.AddDays(19), CapacidadeMaxima = 20, Preco = 1500 },
            new PacoteTuristico { Id = 2, Titulo = "Pacote Europa", DataInicio = DateTime.Now.AddDays(20), CapacidadeMaxima = 15, Preco = 3500 }
        };

        public IActionResult OnGet(int id)
        {
            Pacote = PacotesFake.FirstOrDefault(p => p.Id == id);

            if (Pacote == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
