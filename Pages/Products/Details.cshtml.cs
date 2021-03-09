using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GBclotheingEF.Data;
using GBclotheingEF.Models;

namespace GBclotheingEF.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly GBclotheingEF.Data.GBclotheingEFContext _context;

        public DetailsModel(GBclotheingEF.Data.GBclotheingEFContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Product
                .Include(p => p.Brand).FirstOrDefaultAsync(m => m.ID == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
