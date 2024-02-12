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
            // 1. G�r ett call till app-lagret (service) f�r att h�mta produkter
            // 2. I service: 
            //      G�r ett call till data-lagret f�r att h�mta produkter fr�n databasen
            //      G�r om dom till ViewModels
            //      Sortera dom
            //      Skicka dom till UI-lagret


            ProductModel product = new();
        }
    }
}
