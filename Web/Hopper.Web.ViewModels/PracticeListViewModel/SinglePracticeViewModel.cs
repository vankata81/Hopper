namespace Hopper.Web.ViewModels.PracticeListViewModel
{
    using System;

    using AutoMapper;
    using Hopper.Data.Models;
    using Hopper.Services.Mapping;

    public class SinglePracticeViewModel : IMapFrom<PracticeCreate>, IHaveCustomMappings
    {
        public int SportNameId { get; set; }

        public string Title { get; set; }

        public string SportName { get; set; }

        public string Location { get; set; }

        public DateTime Time { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public int PhoneNumber { get; set; }

        public decimal Price { get; set; }

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
