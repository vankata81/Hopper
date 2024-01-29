namespace Hopper.Services.Data.IndexService
{
    using Hopper.Data.Common.Repositories;
    using Hopper.Data.Models;
    using Hopper.Web.ViewModels.Home;
    using System.Linq;

    public class GetCountService : IGetCountService
    {
        private readonly IDeletableEntityRepository<PracticeCreate> practiceRepository;
        private readonly IRepository<Sports> sportsRepository;

        public GetCountService(IDeletableEntityRepository<PracticeCreate> practiceRepository, IRepository<Sports> sportsRepository)
        {
            this.practiceRepository = practiceRepository;
            this.sportsRepository = sportsRepository;
        }

        public IndexViewModel GetCounts()
        {
            var data = new IndexViewModel
            {
                AllPractices = this.sportsRepository.All().Count(),
                BasketballPractices = this.sportsRepository.All().Where(x => x.Name == "basketball").Count(),
                FootballPractices = this.sportsRepository.All().Where(y => y.Name == "football").Count(),
            };

            return data;
        }
    }
}
