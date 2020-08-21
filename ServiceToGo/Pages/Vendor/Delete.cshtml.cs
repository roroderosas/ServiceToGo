using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ServiceToGo.Data;
using ServiceToGo.Models;

namespace ServiceToGo.Pages.Vendor
{
    public class DeleteModel : PageModel
    {
        private readonly ServiceToGo.Data.ServiceToGoContext _context;

        public DeleteModel(ServiceToGo.Data.ServiceToGoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Vendors Vendors { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vendors = await _context.Vendors.FirstOrDefaultAsync(m => m.ID == id);

            if (Vendors == null)
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

            Vendors = await _context.Vendors.FindAsync(id);

            if (Vendors != null)
            {
                _context.Vendors.Remove(Vendors);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
