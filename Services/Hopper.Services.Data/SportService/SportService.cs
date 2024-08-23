namespace Hopper.Services.Data.SportService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Hopper.Data;
    using Hopper.Data.Common.Repositories;
    using Hopper.Data.Models;
    using Hopper.Services.Mapping;
    using Hopper.Web.ViewModels.PracticeListViewModel;
    using Microsoft.EntityFrameworkCore;

    public class SportService(IRepository<Sports> sportRepository, IDeletableEntityRepository<PracticeCreate> practiceRepository) : ISportService
    {
        private readonly IRepository<Sports> sportRepository = sportRepository;
        private readonly IDeletableEntityRepository<PracticeCreate> practiceRepository = practiceRepository;

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

        public IEnumerable<T> GetAll<T>(int page, int itemsPerPage)
        {
            var practice = this.practiceRepository.AllAsNoTracking()
                .OrderByDescending(c => c.Id)
                .Skip((page - 1) * itemsPerPage).Take(itemsPerPage)
                .To<T>().ToList();

            return practice;
        }

        public int GetCount()
        {
            return this.practiceRepository.All().Count();
        }

        public T GetById<T>(int id)
        {
            var practice = this.practiceRepository.All().Where(x => x.SportNameId == id)
                .To<T>().FirstOrDefault();

            return practice;
        }
    }
}
