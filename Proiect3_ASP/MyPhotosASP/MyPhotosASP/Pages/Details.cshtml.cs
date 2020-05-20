using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReference;


namespace MyPhotosASP
{
    public class DetailsModel : PageModel
    {
        public MyPhotoTable picture { get; set; }
        
        Service service = new Service();

        public async Task OnGetAsync(int? id)
        {
            if (!id.HasValue)
                return;
            picture = (await service.GetAllInfoAsync()).Where(p => p.Id == id).First();

            Console.WriteLine(picture.Name);
            ViewData["POST"] = picture.Name.ToString() + " created on  " + picture.Create_Date.ToString();
            
        }
    }
}