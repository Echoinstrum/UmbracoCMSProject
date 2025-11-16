using MessagePack.Formatters;
using System.ComponentModel.DataAnnotations;

namespace TestProjectUmbraco.ViewModels
{
    public class CallbackFormViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "Email is required")]
        [Display(Name = "Email address")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z0-9\-]+\.)+[a-zA-Z]{2,}))$", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; } = null!;
        [Required(ErrorMessage = "Phone is required")]
        [Display(Name = "Phone")]
        public string Phone { get; set; } = null!;
        [Required(ErrorMessage = "Please select an option")]
        public string SelectedOption { get; set; } = null!;
    }
}
