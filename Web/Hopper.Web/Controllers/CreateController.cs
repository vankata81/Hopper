namespace Hopper.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class CreateController : Controller
    {
        public IActionResult Create()
        {
            return this.View();
        }
    }
}
