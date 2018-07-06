using Microsoft.AspNetCore.Mvc;

namespace asp_net_core_razor_pages_view_component_ajax_refresh
{
    public class HelloWorldViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var model = new string[]
            {
                "Hello", "from", "the", "view", "component."  
            };

            return View("Default", model);
        }     
    }
}