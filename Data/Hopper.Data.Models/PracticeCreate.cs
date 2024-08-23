namespace Hopper.Data.Models
{
    using System;
    using System.Collections.Generic;

    using Hopper.Data.Common.Models;

    public class PracticeCreate : BaseDeletableModel<int>
    {
        public int SportNameId { get; set; }

        public string Title { get; set; }

        public Sports SportName { get; set; }

        public string Location { get; set; }

        public DateTime Time { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        public string Description { get; set; }

        public int PeopleNeeded { get; set; }

        public string TeamName { get; set; }

        public int PhoneNumber { get; set; }

        public decimal Price { get; set; }
    }
}
