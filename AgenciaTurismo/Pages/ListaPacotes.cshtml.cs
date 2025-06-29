using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgenciaTurismo.Models;
using System.Collections.Generic;
using System.Linq;

namespace AgenciaTurismo.Pages 
{
    public class ListaPacotesModel : PageModel
    {
        public List<PacoteTuristico> Pacotes { get; set; } = new List<PacoteTuristico>();

        private static List<PacoteTuristico> PacotesFake = new()
        {
            new PacoteTuristico { Id = 1, Titulo = "Pacote Timbo", DataInicio = DateTime.Now.AddDays(19), CapacidadeMaxima = 20, Preco = 1500 },
            new PacoteTuristico { Id = 2, Titulo = "Pacote Europa", DataInicio = DateTime.Now.AddDays(20), CapacidadeMaxima = 15, Preco = 3500 }
        };

        public void OnGet()
        {
            Pacotes = PacotesFake;
        }
    }
}