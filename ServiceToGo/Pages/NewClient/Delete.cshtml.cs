using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ServiceToGo.Data;
using ServiceToGo.Models;

namespace ServiceToGo.Pages.NewClient
{
    public class DeleteModel : PageModel
    {
        private readonly ServiceToGo.Data.ServiceToGoContext _context;

        public DeleteModel(ServiceToGo.Data.ServiceToGoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public NewClients NewClients { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            NewClients = await _context.NewClients.FirstOrDefaultAsync(m => m.ID == id);

            if (NewClients == null)
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

            NewClients = await _context.NewClients.FindAsync(id);

            if (NewClients != null)
            {
                _context.NewClients.Remove(NewClients);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
