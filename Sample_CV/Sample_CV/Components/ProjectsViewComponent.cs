using Microsoft.AspNetCore.Mvc;
using Sample_CV.Models;

using Sample_CV.StoredData; 
namespace Sample_CV.Components
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("PView",ProjectsData.GetProjects()); 
        }
    }
}
