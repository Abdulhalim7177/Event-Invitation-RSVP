using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GetTogether.Models;

namespace GetTogether.Pages
{
    public class ThanksModel : PageModel
    {
        public string FullName;
        public void OnGet()
        {
            FullName = Request.Query["FullName"];
           
        }
    }
}
