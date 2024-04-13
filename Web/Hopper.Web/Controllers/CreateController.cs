namespace Hopper.Web.Controllers
{
    using System.Threading.Tasks;

    using Hopper.Services.Data.CreateService;
    using Hopper.Services.Data.SportService;
    using Hopper.Web.ViewModels.Create;
    using Microsoft.AspNetCore.Mvc;

    public class CreateController : Controller
    {
        private readonly ISportService sportService;
        private readonly ICreateService createService;

        public CreateController(ISportService sportService, ICreateService createService)
        {
            this.sportService = sportService;
            this.createService = createService;
        }

        public IActionResult Create()
        {
            var viewModel = new CreateViewModel();
            viewModel.AllSports = this.sportService.GetAllAsKeyValuePairs();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.AllSports = this.sportService.GetAllAsKeyValuePairs();
                return this.View(input);
            }

            await this.createService.CreateAsync(input);

            return this.Redirect("/");
        }
    }
}
