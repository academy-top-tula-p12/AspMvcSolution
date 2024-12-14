using System.ComponentModel.DataAnnotations;

namespace AspMvcTagHelpersApp.Models
{
    public enum Position
    {
        [Display(Name = "Manager")]
        Manager,
        [Display(Name = "Developer")]
        Developer,
        [Display(Name = "Tester")]
        Tester
    }
}
