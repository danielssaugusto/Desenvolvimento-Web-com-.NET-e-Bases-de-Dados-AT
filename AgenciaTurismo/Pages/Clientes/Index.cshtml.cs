using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AgenciaTurismo.Data;
using AgenciaTurismo.Models;
using Microsoft.AspNetCore.Authorization;

namespace AgenciaTurismo.Pages_Clientes
{
    [Authorize] // Aplica prote��o por autentica��o
    public class IndexModel : PageModel
    {
        private readonly AgenciaTurismoContext _context;

        public IndexModel(AgenciaTurismoContext context)
        {
            _context = context;
        }

        public IList<Cliente> Cliente { get; set; } = new List<Cliente>();

        public async Task OnGetAsync()
        {
            // Gra�as Deus e ao filtro global no DbContext, j� vir�o apenas os clientes n�o exclu�dos
            Cliente = await _context.Clientes.ToListAsync();
        }
    }
}
