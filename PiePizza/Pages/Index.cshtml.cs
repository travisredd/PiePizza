using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PiePizza.Pages
{
    //use as controller
    public class IndexModel : PageModel
    {
        [HttpGet]
        public void OnGet()
        {

        }
    }
}