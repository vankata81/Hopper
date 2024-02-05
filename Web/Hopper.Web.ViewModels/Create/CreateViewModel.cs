namespace Hopper.Web.ViewModels.Create
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class CreateViewModel
    {
        [Required]
        public string Sport { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public TimeOnly Time { get; set; }

        [Required]
        public DateOnly Date { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int PeopleNeeded { get; set; }

        public string TeamName { get; set; }

        [Display(Name = "Phone Number")]
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public int PhoneNumber { get; set; }

        public decimal Price { get; set; }
    }
}
