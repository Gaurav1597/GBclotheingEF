using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GBclotheingEF.Data;
using GBclotheingEF.Models;

namespace GBclotheingEF.Pages.Accessories
{
    public class DetailsModel : PageModel
    {
        private readonly GBclotheingEF.Data.GBclotheingEFContext _context;

        public DetailsModel(GBclotheingEF.Data.GBclotheingEFContext context)
        {
            _context = context;
        }

        public Accessorie Accessorie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Accessorie = await _context.Accessorie.FirstOrDefaultAsync(m => m.ID == id);

            if (Accessorie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
