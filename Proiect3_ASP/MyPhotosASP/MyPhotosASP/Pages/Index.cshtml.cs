using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceReference;

namespace MyPhotosASP.Pages
{
    public class IndexModel : PageModel
    {
        Service service = new Service();
        public List<MyPhotoTable> pictures { get; set; }
        public int nrImg { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Genre { get; set; }
        public List<SelectListItem> Genres = new List<SelectListItem>
        {
            new SelectListItem {Text = "Nume", Value = "Name"},
            new SelectListItem {Text = "Eveniment", Value = "Event"},
            new SelectListItem {Text = "Locatie", Value = "Place"},
            new SelectListItem {Text = "Persoana", Value = "Person"}

        };
        
        public IndexModel()
        {
            pictures = new List<MyPhotoTable>();
        }

        public async Task OnGetAsync()
        {
            
            pictures = (await service.GetAllInfoAsync()).OrderBy(p => p.Name).ToList();
            if (!string.IsNullOrEmpty(SearchString))
            {
                pictures = (await service.GetInfoBySomethingAsync(Genre, SearchString)).ToList();
            }
            nrImg = pictures.Count();
        }
    }
}
