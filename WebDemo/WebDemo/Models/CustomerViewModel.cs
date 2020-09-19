using System.ComponentModel.DataAnnotations;

namespace WebDemo.Models
{
    public class CustomerViewModel
    {
        [Display(Name = "FullName")]
        public string FullName { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "MobileNo")]
        public string MobileNo { get; set; }
    }
}