using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GBclotheingEF.Data;
using GBclotheingEF.Models;

namespace GBclotheingEF.Pages.Brands
{
    public class IndexModel : PageModel
    {
        private readonly GBclotheingEF.Data.GBclotheingEFContext _context;

        public IndexModel(GBclotheingEF.Data.GBclotheingEFContext context)
        {
            _context = context;
        }

        public IList<Brand> Brand { get;set; }

        public async Task OnGetAsync()
        {
            Brand = await _context.Brand.ToListAsync();
        }
    }
}
