using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using lab11_solution.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace lab11_solution.Pages
{
    public class AddCourseModel : PageModel
    {
        private readonly ILogger<AddCourseModel> _logger;
        private readonly ProfessorContext _context; // Professor Database context
        [BindProperty]
        public Course Course {get; set;}
        public SelectList ProfessorsDropDown {get; set;}

        public AddCourseModel(ProfessorContext context, ILogger<AddCourseModel> logger)
        {
            // Bring in Database context and logger using dependency injection
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            ProfessorsDropDown = new SelectList(_context.Professor.ToList(), "ProfessorId", "FirstName");
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Course.Add(Course);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}