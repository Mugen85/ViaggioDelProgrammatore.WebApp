using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ViaggioDelProgrammatore.WebApp.Pages.blog
{
    public class IndexModel : PageModel
    {
        public string? PageTitle { get; set; }
        public string? PageDescription { get; set; }
        public string? PageCanonicalUrl { get; set; }
        public string? PageRobots { get; set; }

        public void OnGet()
        {
            PageTitle = "Blog - Il Viaggio del Programmatore";
            PageDescription = "Un blog per chi vuole crescere come sviluppatore: mindset, strategie, sviluppo software, C# e molto altro. Parti da qui per cambiare carriera.";
            PageCanonicalUrl = "https://www.ilviaggiodelprogrammatore.com/blog"; // Aggiorna se il dominio cambia o per la pagina specifica
            PageRobots = "index, follow";

            // ViewData può essere usato direttamente nel .cshtml, ma avere proprietà è più pulito
            ViewData["Title"] = PageTitle;
            ViewData["Description"] = PageDescription;
            ViewData["CanonicalUrl"] = PageCanonicalUrl;
            ViewData["Robots"] = PageRobots;
        }
    }
}
