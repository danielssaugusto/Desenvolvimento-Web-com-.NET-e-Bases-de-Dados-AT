using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AgenciaTurismo.Models;

namespace AgenciaTurismo.Pages
{
    public class CreatePacoteTuristicoModel : PageModel
    {
        [BindProperty]
        public PacoteTuristico Pacote { get; set; } = new PacoteTuristico();

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Console.WriteLine($"Pacote criado: {Pacote.Titulo} em {Pacote.DataInicio:dd/MM/yyyy}");

            TempData["Mensagem"] = "Pacote cadastrado com sucesso!";
            return RedirectToPage("CreatePacoteTuristico");

        }
    }
}
