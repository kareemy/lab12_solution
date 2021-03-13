using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using lab11_solution.Models;

namespace lab11_solution.Pages.Professors
{
    public class EditModel : PageModel
    {
        private readonly lab11_solution.Models.ProfessorContext _context;

        public EditModel(lab11_solution.Models.ProfessorContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Professor Professor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Professor = await _context.Professor.FirstOrDefaultAsync(m => m.ProfessorId == id);

            if (Professor == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Professor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfessorExists(Professor.ProfessorId))
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

        private bool ProfessorExists(int id)
        {
            return _context.Professor.Any(e => e.ProfessorId == id);
        }
    }
}
