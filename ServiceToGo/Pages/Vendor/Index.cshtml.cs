using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ServiceToGo.Data;
using ServiceToGo.Models;

namespace ServiceToGo.Pages.Vendor
{
    public class IndexModel : PageModel
    {
        private readonly ServiceToGo.Data.ServiceToGoContext _context;

        public IndexModel(ServiceToGo.Data.ServiceToGoContext context)
        {
            _context = context;
        }

        public IList<Vendors> Vendors { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList CompName { get; set; }
        [BindProperty(SupportsGet = true)]
        public string CompNames { get; set; }
        public async Task OnGetAsync()
        {
            var vendorss = from m in _context.Vendors
                          select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                vendorss = vendorss.Where(s => s.CompanyName.Contains(SearchString));
            }

            Vendors = await _context.Vendors.ToListAsync();
        }
    }
}
