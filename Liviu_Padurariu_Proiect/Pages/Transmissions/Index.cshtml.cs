﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Liviu_Padurariu_Proiect.Data;
using Liviu_Padurariu_Proiect.Models;

namespace Liviu_Padurariu_Proiect.Pages.Transmissions
{
    public class IndexModel : PageModel
    {
        private readonly Liviu_Padurariu_Proiect.Data.Liviu_Padurariu_ProiectContext _context;

        public IndexModel(Liviu_Padurariu_Proiect.Data.Liviu_Padurariu_ProiectContext context)
        {
            _context = context;
        }

        public IList<Transmission> Transmission { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Transmission = await _context.Transmission.ToListAsync();
        }
    }
}
