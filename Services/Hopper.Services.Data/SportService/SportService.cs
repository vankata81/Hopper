namespace Hopper.Services.Data.SportService
{
    using System.Collections.Generic;
    using System.Linq;

    using Hopper.Data.Common.Repositories;
    using Hopper.Data.Models;

    public class SportService : ISportService
    {
        private readonly IRepository<Sports> sportRepository;

        public SportService(IRepository<Sports> sportRepository)
        {
            this.sportRepository = sportRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs()
        {
            return this.sportRepository.All().Select(c => new
            {
                c.Id,
                c.Name,
            }).ToList().Select(c => new KeyValuePair<string, string>(c.Id.ToString(), c.Name));
        }
    }
}
