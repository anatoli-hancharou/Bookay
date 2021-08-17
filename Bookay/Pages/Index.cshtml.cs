using Bookay.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookay.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BookayDbContext _dbContext;
        private readonly ILogger<IndexModel> _logger;
        public List<Hotel> Hotels { private set; get; }

        public IndexModel(BookayDbContext dbContextm, ILogger<IndexModel> logger)
        {
            _dbContext = dbContextm;
            _logger = logger;
        }

        public void OnGet()
        {
            this.Hotels = _dbContext.Hotels.ToList();
        }
    }
}
