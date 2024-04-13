namespace Hopper.Services.Data.SportService
{
    using System.Collections.Generic;
    using System.Linq;

    using Hopper.Data.Common.Repositories;
    using Hopper.Data.Models;
    using Hopper.Web.ViewModels.PracticeListViewModel;

    public class SportService : ISportService
    {
        private readonly IRepository<Sports> sportRepository;
        private readonly IDeletableEntityRepository<PracticeCreate> practiceRepository;

        public SportService(IRepository<Sports> sportRepository, IDeletableEntityRepository<PracticeCreate> practiceRepository)
        {
            this.sportRepository = sportRepository;
            this.practiceRepository = practiceRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs()
        {
            return this.sportRepository.All().Select(c => new
            {
                c.Id,
                c.Name,
            })
            .OrderBy(x => x.Name)
            .ToList().Select(c => new KeyValuePair<string, string>(c.Id.ToString(), c.Name));
        }

        public IEnumerable<PracticeinListViewModel> GetAll(int page, int itemsPerPage = 12)
        {
            var practice = this.practiceRepository.AllAsNoTracking()
                .OrderByDescending(c => c.Id)
                .Skip((page - 1) * itemsPerPage).Take(itemsPerPage)
                .Select(x => new PracticeinListViewModel
                {
                    SportId = x.Id,
                    SportName = x.SportName.Name,
                    Date = x.Date,
                    Description = x.Description,
                    Time = x.Time,
                }).ToList();

            return practice;
        }
    }
}
