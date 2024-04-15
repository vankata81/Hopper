namespace Hopper.Web.ViewModels.PracticeListViewModel
{
    using System;
    using System.Collections.Generic;
    using AutoMapper;
    using Hopper.Data.Models;
    using Hopper.Services.Mapping;

    public class PracticeinListViewModel : IMapFrom<PracticeCreate>, IHaveCustomMappings
    {
        public int SportId { get; set; }

        public string SportName { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public DateTime Time { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<PracticeCreate, PracticeinListViewModel>()
                .ForMember(
                    x => x.SportName,
                    opt =>
                      opt.MapFrom(r => r.SportName.Name));
        }
    }
}
