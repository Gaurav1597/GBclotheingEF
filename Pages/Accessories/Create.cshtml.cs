using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GBclotheingEF.Data;
using GBclotheingEF.Models;

namespace GBclotheingEF.Pages.Accessories
{
    public class CreateModel : PageModel
    {
        private readonly GBclotheingEF.Data.GBclotheingEFContext _context;

        public CreateModel(GBclotheingEF.Data.GBclotheingEFContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Accessorie Accessorie { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Accessorie.Add(Accessorie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
