namespace Hopper.Data.Models
{
    using Hopper.Data.Common.Models;

    public class PracticeCreate : BaseDeletableModel<int>
    {
        public Sports SportNames { get; set; }

        public string Location { get; set; }

        public int Hour { get; set; }

        public string Description { get; set; }

        public int PeopleAvailable { get; set; }

        public int PeopleNeeded { get; set; }

        public string TeamName { get; set; }

        public int HoursForAnounce { get; set; }
    }
}
