namespace Hopper.Web.Controllers
{
    using Hopper.Data.Common.Repositories;
    using Hopper.Services.Data.SportService;
    using Hopper.Web.ViewModels.PracticeListViewModel;
    using Microsoft.AspNetCore.Mvc;

    public class AllController : Controller
    {
        private readonly ISportService sportService;

        public AllController(ISportService sportService)
        {
            this.sportService = sportService;
        }

        public IActionResult AllPractice(int id = 1)
        {
            var viewmodel = new PracticeListViewModel
            {
                Practices = this.sportService.GetAll(id, 12),
            };
            return this.View(viewmodel);
        }
    }
}
