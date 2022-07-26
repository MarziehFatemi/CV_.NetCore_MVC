using Microsoft.AspNetCore.Mvc;

namespace Sample_CV.Components
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("PView"); 
        }
    }
}
