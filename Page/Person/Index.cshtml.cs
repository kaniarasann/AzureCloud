using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AzureSQL.Data;
using AzureSQL.Model;

namespace AzureSQL.Page_Person
{
    public class IndexModel : PageModel
    {
        private readonly AzureSQL.Data.AzureDBContext _context;

        public IndexModel(AzureSQL.Data.AzureDBContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Persons != null)
            {
                Person = await _context.Persons.ToListAsync();
            }
        }
    }
}
