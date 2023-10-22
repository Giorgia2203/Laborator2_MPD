using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Laborator2_MPD.Data;
using Laborator2_MPD.Models;

namespace Laborator2_MPD.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Laborator2_MPD.Data.Laborator2_MPDContext _context;

        public DetailsModel(Laborator2_MPD.Data.Laborator2_MPDContext context)
        {
            _context = context;
        }

      public Category Category { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);
            if (category == null)
            {
                return NotFound();
            }
            else 
            {
                Category = category;
            }
            return Page();
        }
    }
}
