using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace azure_app_eduerp_vs.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _configuration;
        public IndexModel(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public void OnGet()
        {
            ViewData["Greetings"] = _configuration["Greetings"];
        }
    }
}
