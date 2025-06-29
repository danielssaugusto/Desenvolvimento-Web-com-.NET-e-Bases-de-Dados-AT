using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AgenciaTurismo.Data;
using AgenciaTurismo.Models;
using Microsoft.AspNetCore.Authorization;

namespace AgenciaTurismo.Pages_Clientes
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly AgenciaTurismoContext _context;

        public DeleteModel(AgenciaTurismoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cliente Cliente { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
                return NotFound();

            var cliente = await _context.Clientes.FirstOrDefaultAsync(m => m.Id == id);

            if (cliente == null)
                return NotFound();

            Cliente = cliente;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
                return NotFound();

            var cliente = await _context.Clientes.FindAsync(id);

            if (cliente != null)
            {
                // Exclusão lógica
                cliente.IsDeleted = true;
                _context.Attach(cliente).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
