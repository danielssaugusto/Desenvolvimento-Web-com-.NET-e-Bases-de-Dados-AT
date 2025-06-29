using Microsoft.AspNetCore.Mvc.RazorPages;
using AgenciaTurismo.Delegates;
using AgenciaTurismo.Models;
using Microsoft.AspNetCore.Mvc;
using AgenciaTurismo.Services;

namespace AgenciaTurismo.Pages
{
    public class DiscountModel : PageModel
    {
        [BindProperty]
        public decimal PrecoOriginal { get; set; }

        public decimal PrecoComDesconto { get; set; }

        public void OnPost()
        {
            // Aplica o desconto usando o delegate personalizado
            CalculateDelegate desconto = CalculadoraDesconto.AplicarDesconto10;
            PrecoComDesconto = desconto(PrecoOriginal);

            Action<string> log = LoggerService.LogToConsole;
            log += LoggerService.LogToFile;
            log += LoggerService.LogToMemory;

            log($"Desconto aplicado sobre R$ {PrecoOriginal:F2}. Valor final: R$ {PrecoComDesconto:F2}");
        }
    }
}
