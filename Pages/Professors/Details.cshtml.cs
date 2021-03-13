using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lab11_solution.Models;

namespace lab11_solution.Pages.Professors
{
    public class DetailsModel : PageModel
    {
        private readonly lab11_solution.Models.ProfessorContext _context;

        public DetailsModel(lab11_solution.Models.ProfessorContext context)
        {
            _context = context;
        }

        public Professor Professor { get; set; }
        
        [BindProperty]
        public int CourseIdToDelete {get; set;}

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Round 3: Add .Include() to bring in courses
            Professor = await _context.Professor.Include(p => p.Courses).FirstOrDefaultAsync(m => m.ProfessorId == id);
            
            if (Professor == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPostDeleteCourse(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Find the Course in the database
            Course Course = _context.Course.FirstOrDefault(c => c.CourseId == CourseIdToDelete);
            
            if (Course != null)
            {
                _context.Remove(Course); // Delete the Course
                _context.SaveChanges();
            }

            Professor = _context.Professor.Include(p => p.Courses).FirstOrDefault(p => p.ProfessorId == id);

            return Page();
        } 
    }
}
