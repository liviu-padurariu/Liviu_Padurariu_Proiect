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
    public class IndexModel : PageModel
    {
        private readonly Liviu_Padurariu_Proiect.Data.Liviu_Padurariu_ProiectContext _context;

        public IndexModel(Liviu_Padurariu_Proiect.Data.Liviu_Padurariu_ProiectContext context)
        {
            _context = context;
        }

        public IList<Color> Color { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Color = await _context.Color.ToListAsync();
        }
    }
}
