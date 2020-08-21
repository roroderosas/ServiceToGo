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
    public class IndexModel : PageModel
    {
        private readonly ServiceToGo.Data.ServiceToGoContext _context;

        public IndexModel(ServiceToGo.Data.ServiceToGoContext context)
        {
            _context = context;
        }

        public IList<NewClients> NewClients { get;set; }

        public async Task OnGetAsync()
        {
            NewClients = await _context.NewClients.ToListAsync();
        }
    }
}
