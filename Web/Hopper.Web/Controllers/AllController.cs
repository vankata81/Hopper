namespace Hopper.Web.Controllers
{
    using System.Drawing.Printing;

    using Hopper.Data.Common.Repositories;
    using Hopper.Data.Models;

    using Hopper.Services.Data.SportService;

    using Hopper.Web.ViewModels.PracticeListViewModel;
    using Microsoft.AspNetCore.Mvc;

    public class AllController(ISportService sportService) : Controller
    {
        private readonly ISportService sportService = sportService;

        public IActionResult AllPractice(int id = 1)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            const int ItemsPerPage = 3;
            var viewModel = new PracticeListViewModel
            {
                ItemsPerPage = ItemsPerPage,
                PageNumber = id,
                PracticesCount = this.sportService.GetCount(),
                Practices = this.sportService.GetAll<PracticeinListViewModel>(id, ItemsPerPage),
            };

            return this.View(viewModel);
        }

        public IActionResult ById(int id)
        {
            var practice = this.sportService.GetById<SinglePracticeViewModel>(id);

            return this.View(practice);
        }
    }
}
