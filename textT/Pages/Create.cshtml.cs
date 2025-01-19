using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using textT.Data;
using textT.Models;

namespace textT.Pages
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string Content { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (string.IsNullOrWhiteSpace(Content))
            {
                return Page();
            }

            var paste = new Paste
            {
                Content = Content,
                CreatedAt = DateTime.UtcNow
            };

            _context.Pastes.Add(paste);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Index");
        }
    }
}
