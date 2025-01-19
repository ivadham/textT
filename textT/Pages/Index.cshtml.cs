using Microsoft.AspNetCore.Mvc.RazorPages;
using textT.Data;
using textT.Models;
using System.Collections.Generic;
using System.Linq;

namespace textT.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Paste> Pastes { get; set; }

        public void OnGet()
        {
            Pastes = _context.Pastes.OrderByDescending(p => p.CreatedAt).ToList();
        }
    }
}
