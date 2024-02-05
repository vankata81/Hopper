namespace Hopper.Data.Models
{
    using System;

    using Hopper.Data.Common.Models;

    public class PracticeCreate : BaseDeletableModel<int>
    {
        public Sports SportNames { get; set; }

        public string Location { get; set; }

        public TimeOnly Time { get; set; }

        public DateOnly Date { get; set; }

        public string Description { get; set; }

        public int PeopleNeeded { get; set; }

        public string TeamName { get; set; }

        public int PhoneNumber { get; set; }

        public decimal Price { get; set; }
    }
}
