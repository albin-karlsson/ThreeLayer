using Microsoft.AspNetCore.Mvc.RazorPages;
using ThreeLayer.Data.Models;

namespace ThreeLayer.UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            // 1. Gör ett call till app-lagret (service) för att hämta produkter
            // 2. I service: 
            //      Gör ett call till data-lagret för att hämta produkter från databasen
            //      Gör om dom till ViewModels
            //      Sortera dom
            //      Skicka dom till UI-lagret


            ProductModel product = new();
        }
    }
}
