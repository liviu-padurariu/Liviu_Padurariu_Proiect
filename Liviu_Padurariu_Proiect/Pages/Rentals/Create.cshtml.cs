using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Liviu_Padurariu_Proiect.Data;
using Liviu_Padurariu_Proiect.Models;
using Microsoft.EntityFrameworkCore;

namespace Liviu_Padurariu_Proiect.Pages.Rentals
{
    public class CreateModel : PageModel
    {
        private readonly Liviu_Padurariu_Proiect.Data.Liviu_Padurariu_ProiectContext _context;

        public CreateModel(Liviu_Padurariu_Proiect.Data.Liviu_Padurariu_ProiectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            var carMakers = _context.Car
                .Include(m => m.CarMaker)
                .Select(x => new {x.ID, CarMakerName = x.CarMaker.Name });

            ViewData["CarID"] = new SelectList(carMakers, "ID", "CarMakerName");
            ViewData["LocationID"] = new SelectList(_context.Location, "ID", "Name");
            ViewData["UserID"] = new SelectList(_context.Set<User>(), "ID", "FullName");
            return Page();
        }

        [BindProperty]
        public Rental Rental { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Rental.Add(Rental);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
