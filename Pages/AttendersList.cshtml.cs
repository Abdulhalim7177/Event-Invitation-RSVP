using GetTogether.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GetTogether.Pages
{
    public class AttendersListModel : PageModel
    {
        public List<Attenders> AttendersList = new();
      
        public void OnGet()
        {
            Attenders attenders = new();

            AttendersList = attenders.getAttendersData();
        }
    }
}
