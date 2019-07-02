using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageFormChallenge.Models;

namespace RazorPageFormChallenge.Pages
{
    public class SignUpModel : PageModel
    {
        // This allows you to specify the value of Mode as a query parameter
        // Ex) https://alsdfd.com/SignUp?Mode=Dark
        [BindProperty(SupportsGet = true)]
        public string Mode { get; set; } = "Light";

        [BindProperty]
        public SignUpDataModel SignUpData { get; set; } = new SignUpDataModel();

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid == false)
            {
                return Page();
            }

            return RedirectToPage("./ThankYou", new { id = 15 });
        }
    }
}