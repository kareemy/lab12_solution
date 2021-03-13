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
    public class IndexModel : PageModel
    {
        private readonly lab11_solution.Models.ProfessorContext _context;

        public IndexModel(lab11_solution.Models.ProfessorContext context)
        {
            _context = context;
        }

        public IList<Professor> Professor { get;set; }

        public async Task OnGetAsync()
        {
            Professor = await _context.Professor.ToListAsync();
        }
    }
}
