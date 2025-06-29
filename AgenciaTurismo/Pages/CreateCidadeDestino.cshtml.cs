using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgenciaTurismo.Models;

namespace AgenciaTurismo.Pages
{
    public class CreateCidadeDestinoModel : PageModel
    {
        [BindProperty]
        public CidadeDestino Cidade { get; set; } = new CidadeDestino();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Console.WriteLine($"Cidade cadastrada: {Cidade.Nome}");

            TempData["Mensagem"] = "Cidade cadastrada com sucesso!";
            return RedirectToPage("CreateCidadeDestino");
        }
    }
}
