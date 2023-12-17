﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Liviu_Padurariu_Proiect.Data;
using Liviu_Padurariu_Proiect.Models;

namespace Liviu_Padurariu_Proiect.Pages.Roles
{
    public class DeleteModel : PageModel
    {
        private readonly Liviu_Padurariu_Proiect.Data.Liviu_Padurariu_ProiectContext _context;

        public DeleteModel(Liviu_Padurariu_Proiect.Data.Liviu_Padurariu_ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Role Role { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var role = await _context.Role.FirstOrDefaultAsync(m => m.ID == id);

            if (role == null)
            {
                return NotFound();
            }
            else
            {
                Role = role;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var role = await _context.Role.FindAsync(id);
            if (role != null)
            {
                Role = role;
                _context.Role.Remove(Role);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
