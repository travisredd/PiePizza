using System;
using System.Collections;
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
        

        [BindProperty]
        public Pie Pie { get; set; }

        public IPieRepository pieRepository { get; set; }


        public IndexModel(IPieRepository pieRepository)
        {
            
            this.pieRepository = pieRepository;
            
        }

        public void OnGet()
        {
            var Pies = pieRepository.GetAllPies();
            Pie = (Pie)Pies;
        }


        public void OnPost()
        {
            
            
            
        }
    }
}