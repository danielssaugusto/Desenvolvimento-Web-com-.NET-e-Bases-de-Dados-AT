using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AgenciaTurismo.Data;
using AgenciaTurismo.Models;
using Microsoft.AspNetCore.Authorization;

namespace AgenciaTurismo.Pages_Clientes
{
    [Authorize] // Aplica proteção por autenticação
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
            // Graças Deus e ao filtro global no DbContext, já virão apenas os clientes não excluídos
            Cliente = await _context.Clientes.ToListAsync();
        }
    }
}
