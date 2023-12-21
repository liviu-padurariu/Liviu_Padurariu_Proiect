using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Liviu_Padurariu_Proiect.Data;
using Liviu_Padurariu_Proiect.Models;

namespace Liviu_Padurariu_Proiect.Pages.Rentals
{
    public class EditModel : PageModel
    {
        private readonly Liviu_Padurariu_Proiect.Data.Liviu_Padurariu_ProiectContext _context;

        public EditModel(Liviu_Padurariu_Proiect.Data.Liviu_Padurariu_ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Rental Rental { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rental =  await _context.Rental
                .Include(c => c.User)
                .Include(c => c.Location)
                .FirstOrDefaultAsync(m => m.ID == id);

            var carMakers = _context.Car
                .Include(m => m.CarMaker)
                .Select(x => new { x.ID, CarMakerName = x.CarMaker.Name });

            if (rental == null)
            {
                return NotFound();
            }
            Rental = rental;
           ViewData["CarID"] = new SelectList(carMakers, "ID", "CarMakerName");
           ViewData["LocationID"] = new SelectList(_context.Location, "ID", "Name");
           ViewData["UserID"] = new SelectList(_context.Set<User>(), "ID", "FullName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Rental).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RentalExists(Rental.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RentalExists(int id)
        {
            return _context.Rental.Any(e => e.ID == id);
        }
    }
}
