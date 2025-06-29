using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgenciaTurismo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AgenciaTurismo.Pages
{
    public class TestCapacityModel : PageModel
    {
        private const string TempDataKey = "PacoteJson";

        public string MensagemEvento { get; set; } = "";

        [BindProperty]
        public PacoteTuristico Pacote { get; set; } = new PacoteTuristico();

        public void OnGet()
        {
            if (TempData.ContainsKey(TempDataKey))
            {
                var json = TempData[TempDataKey] as string;
                if (!string.IsNullOrEmpty(json))
                {
                    Pacote = JsonConvert.DeserializeObject<PacoteTuristico>(json) ?? new PacoteTuristico();
                }
            }
            else
            {
                Pacote = new PacoteTuristico
                {
                    Id = 1,
                    Titulo = "Pacote Teste Capacidade",
                    CapacidadeMaxima = 2,
                    Reservas = new List<Reserva>()
                };
            }

            Pacote.CapacityReached -= OnCapacityReached;
            Pacote.CapacityReached += OnCapacityReached;
        }

        public IActionResult OnPostAddReserva()
        {
            if (TempData.ContainsKey(TempDataKey))
            {
                var json = TempData[TempDataKey] as string;
                if (!string.IsNullOrEmpty(json))
                {
                    Pacote = JsonConvert.DeserializeObject<PacoteTuristico>(json) ?? new PacoteTuristico();
                }
            }
            else
            {
                Pacote = new PacoteTuristico
                {
                    Id = 1,
                    Titulo = "Pacote Teste Capacidade",
                    CapacidadeMaxima = 2,
                    Reservas = new List<Reserva>()
                };
            }

            Pacote.CapacityReached -= OnCapacityReached;
            Pacote.CapacityReached += OnCapacityReached;

            Pacote.AdicionarReserva(new Reserva
            {
                Id = Pacote.Reservas.Count + 1,
                ClienteId = Pacote.Reservas.Count + 1,
                PacoteTuristicoId = Pacote.Id,
                DataReserva = DateTime.Now
            });

            TempData[TempDataKey] = JsonConvert.SerializeObject(Pacote);

            return Page();
        }

        private void OnCapacityReached(object? sender, EventArgs e)
        {
            if (sender is PacoteTuristico pacote)
            {
                string msg = $"Capacidade máxima atingida para o pacote {pacote.Titulo}!";
                Console.WriteLine(msg);
                MensagemEvento = msg;
            }
        }
    }
}
