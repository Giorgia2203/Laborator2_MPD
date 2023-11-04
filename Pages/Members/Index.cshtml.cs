using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Laborator2_MPD.Data;
using Laborator2_MPD.Models;

namespace Laborator2_MPD.Pages.Members
{
    public class IndexModel : PageModel
    {
        private readonly Laborator2_MPD.Data.Laborator2_MPDContext _context;

        public IndexModel(Laborator2_MPD.Data.Laborator2_MPDContext context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Member != null)
            {
                Member = await _context.Member.ToListAsync();
            }
        }
    }
}
