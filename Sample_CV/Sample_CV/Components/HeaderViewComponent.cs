using Microsoft.AspNetCore.Mvc;
using Sample_CV.Models;

namespace Sample_CV.Components
{
    public class HeaderViewComponent :ViewComponent
    {
        public IViewComponentResult Invoke ()
        {
            AboutMe MyInfo = new AboutMe ();

            MyInfo.IntroMessage = "سلام، مرضیه فاطمی هستم.  به وبسایت شخصی من خوش آمدید";
            MyInfo.GitHubURL = "https://github.com/MarziehFatemi";
            MyInfo.LinkedInURL = "https://www.linkedin.com/in/marzieh-fatemi-04ba846b/";
            MyInfo.Name = "مرضیه فاطمی";
            MyInfo.Image ="Me.jpg"; 
            return View("_Header", MyInfo);
        }

    }
}
