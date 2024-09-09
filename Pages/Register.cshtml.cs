using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;


namespace Site.Pages
{
    public class Register : PageModel
    {
        [BindProperty]
        public User User { get; set; }

        public string Message { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Registration logic goes here (e.g., save the user to a database)

            Message = "Registration successful!";
            return Page();
        }
    }
}
