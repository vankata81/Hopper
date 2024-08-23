namespace Hopper.Web.ViewModels.Create
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CreateViewModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Location { get; set; }

        public DateTime Time { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        [Required]
        public string Description { get; set; }

        [Required]
        public int PeopleNeeded { get; set; }

        public string TeamName { get; set; }

        public int PhoneNumber { get; set; }

        public decimal Price { get; set; }

        [Required]
        public int AllSportsId { get; set; }

        public IEnumerable<KeyValuePair<string, string>> AllSports { get; set; }
    }
}
