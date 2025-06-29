using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AgenciaTurismo.Pages
{
    public class ReservaTotalModel : PageModel
    {
        [BindProperty]
        public int NumeroDiarias { get; set; }

        [BindProperty]
        public decimal ValorDiaria { get; set; }

        public decimal TotalReserva { get; set; }

        public void OnPost()
        {
            // Func que calcula total: (numeroDiarias * valorDiaria)
            Func<int, decimal, decimal> calculaTotal = (dias, valor) => dias * valor;

            TotalReserva = calculaTotal(NumeroDiarias, ValorDiaria);
        }
    }
}
