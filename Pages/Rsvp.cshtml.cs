using Microsoft.AspNetCore.Mvc.RazorPages;
using GetTogether.Models;

namespace GetTogether.Pages
{
    public class RsvpModel : PageModel
    {
        public string FullName;
        public string PhoneNumber;

        public string errorMessage;
        public void Onpost()
        {
          
            FullName = Request.Form["FullName"];
            PhoneNumber = Request.Form["PhoneNumber"];

            RSVP Rsvp = new();
            errorMessage = Rsvp.SaveData(FullName, PhoneNumber);

            string url = "./Thanks?FullName=" + FullName;
            Response.Redirect(url);

        }
        
    }
}

