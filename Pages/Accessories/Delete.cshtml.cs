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
    public class DeleteModel : PageModel
    {
        private readonly GBclotheingEF.Data.GBclotheingEFContext _context;

        public DeleteModel(GBclotheingEF.Data.GBclotheingEFContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Accessorie = await _context.Accessorie.FindAsync(id);

            if (Accessorie != null)
            {
                _context.Accessorie.Remove(Accessorie);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
