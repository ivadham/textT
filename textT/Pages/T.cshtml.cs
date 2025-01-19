using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using textT.Data;
using textT.Models;
using Microsoft.EntityFrameworkCore;

namespace textT.Pages
{
    public class TModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public TModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Paste Paste { get; set; }

        public async Task<IActionResult> OnGetAsync(string uniqueIdentifier)
        {
            if (string.IsNullOrWhiteSpace(uniqueIdentifier))
            {
                return NotFound();
            }

            Paste = await _context.Pastes.FirstOrDefaultAsync(p => p.UniqueIdentifier == uniqueIdentifier);

            if (Paste == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
