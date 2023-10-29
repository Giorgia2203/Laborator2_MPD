using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Laborator2_MPD.Data;
using Laborator2_MPD.Models;
using Laborator2_MPD.Models.ViewModels;

namespace Laborator2_MPD.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Laborator2_MPD.Data.Laborator2_MPDContext _context;

        public IndexModel(Laborator2_MPD.Data.Laborator2_MPDContext context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get; set; } = default!;

        public PublisherIndexData PublisherData { get; set; }
        public int PublisherID { get; set; }
        public int BookID { get; set; }

        public async Task OnGetAsync(int? id, int? bookID)
        {
            PublisherData = new PublisherIndexData();
            PublisherData.Publishers = await _context.Publisher.Include(i => i.Books)
                                                                .ThenInclude(c => c.Author)
                                                                .OrderBy(i => i.PublisherName)
                                                                .ToListAsync();
            if (id != null)
            {
                PublisherID = id.Value;
                Publisher publisher = PublisherData.Publishers.Where(i => i.ID == id.Value).Single();
                PublisherData.Books = publisher.Books;
            }

        }
    }
}
