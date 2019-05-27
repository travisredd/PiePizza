using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PiePizza.Models;

namespace PiePizza.Pages
{
    public class IndexModel : PageModel
    {
        public Enum Pies { get; set; }

        [BindProperty]
        public Pie Pie { get; set; }

        public IPieRepository pieRepository { get; set; }

        public IndexModel(IPieRepository pieRepository)
        {
            this.pieRepository = pieRepository;
        }

        public Enum OnGetAsync()
        {
            var newPie = pieRepository.GetAllPies();

            return Pies;
        }


        public async Task<IActionResult> OnPostAsync()
        {
            
            
            return RedirectToPage("/Index");
        }
    }
}