﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceToGo.Data;
using ServiceToGo.Models;

namespace ServiceToGo.Pages.Vendor
{
    public class CreateModel : PageModel
    {
        private readonly ServiceToGo.Data.ServiceToGoContext _context;

        public CreateModel(ServiceToGo.Data.ServiceToGoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Vendors Vendors { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Vendors.Add(Vendors);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}