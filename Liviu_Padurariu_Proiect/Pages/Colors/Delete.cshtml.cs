using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Liviu_Padurariu_Proiect.Data;
using Liviu_Padurariu_Proiect.Models;

namespace Liviu_Padurariu_Proiect.Pages.Colors
{
    public class DeleteModel : PageModel
    {
        private readonly Liviu_Padurariu_Proiect.Data.Liviu_Padurariu_ProiectContext _context;

        public DeleteModel(Liviu_Padurariu_Proiect.Data.Liviu_Padurariu_ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Color Color { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var color = await _context.Color.FirstOrDefaultAsync(m => m.ID == id);

            if (color == null)
            {
                return NotFound();
            }
            else
            {
                Color = color;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var color = await _context.Color.FindAsync(id);
            if (color != null)
            {
                Color = color;
                _context.Color.Remove(Color);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
