using Microsoft.AspNetCore.Mvc;

namespace asp_net_core_razor_pages_view_component_ajax_refresh
{
    public class HomeController : Controller
    {
        public IActionResult GetHelloWorld()
        {
            return ViewComponent("HelloWorld");
        }
    }
}
