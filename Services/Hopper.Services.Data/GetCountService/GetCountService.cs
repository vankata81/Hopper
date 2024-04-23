namespace Hopper.Services.Data.IndexService
{
    using System.Linq;

    using Hopper.Data.Common.Repositories;
    using Hopper.Data.Models;
    using Hopper.Web.ViewModels.Home;

    public class GetCountService : IGetCountService
    {
        private readonly IDeletableEntityRepository<PracticeCreate> practiceRepository;

        public GetCountService(IDeletableEntityRepository<PracticeCreate> practiceRepository)
        {
            this.practiceRepository = practiceRepository;
        }

        public IndexViewModel GetCounts()
        {
            var data = new IndexViewModel
            {
                AllPractices = this.practiceRepository.All().Count(),
                BasketballPractices = this.practiceRepository.All().Where(x => x.SportName.Name == "Basketball").Count(),
                FootballPractices = this.practiceRepository.All().Where(x => x.SportName.Name == "FootBall").Count(),
            };

            return data;
        }
    }
}
