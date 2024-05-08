namespace Hopper.Services.Data.CreateService
{
    using System.Threading.Tasks;

    using Hopper.Data.Common.Models;
    using Hopper.Data.Common.Repositories;
    using Hopper.Data.Models;
    using Hopper.Web.ViewModels.Create;

    public class CreateService : ICreateService
    {
        private readonly IDeletableEntityRepository<PracticeCreate> practiceRepository;
        private readonly IRepository<Sports> sportRepository;

        public CreateService(
            IDeletableEntityRepository<PracticeCreate> practiceRepository,
            IRepository<Sports> sportRepository)
        {
            this.practiceRepository = practiceRepository;
            this.sportRepository = sportRepository;
        }

        public async Task CreateAsync(CreateViewModel viewModel)
        {
            var practice = new PracticeCreate
            {
                Title = viewModel.Title,
                SportNameId = viewModel.AllSportsId,
                Location = viewModel.Location,
                Description = viewModel.Description,
                PhoneNumber = viewModel.PhoneNumber,
                Price = viewModel.Price,
                Time = viewModel.Time,
                PeopleNeeded = viewModel.PeopleNeeded,
                Date = viewModel.Date,
            };
            await this.practiceRepository.AddAsync(practice);
            await this.practiceRepository.SaveChangesAsync();
        }
    }
}
