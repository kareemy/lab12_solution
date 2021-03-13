using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using lab11_solution.Models;

namespace lab11_solution.Pages
{
    public class ProfessorModel : PageModel
    {
        private readonly ProfessorContext _context;
        private readonly ILogger<ProfessorModel> _logger;
        public List<Professor> Professors {get; set;}
        public SelectList ProfessorDropDown {get; set;}

        // Extra Credit Step 1: We need a professor property
        // User will select which professor they want, so this must use BindProperty
        [BindProperty]
        public Professor Professor {get; set;}

        public ProfessorModel(ProfessorContext context, ILogger<ProfessorModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            Professors = _context.Professor.ToList();
            ProfessorDropDown = new SelectList(Professors, "ProfessorId", "FirstName");
        }

        public void OnPost()
        {
            // Extra Credit Step 2: OnPost() is called when user hits submit
            // Refresh SelectList and find selected professor in database
            Professor = _context.Professor.Find(Professor.ProfessorId);
            Professors = _context.Professor.ToList();
            ProfessorDropDown = new SelectList(Professors, "ProfessorId", "FirstName");
        }
    }
}