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
            };

            return data;
        }
    }
}
