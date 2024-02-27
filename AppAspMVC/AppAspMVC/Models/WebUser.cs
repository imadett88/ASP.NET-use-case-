using System.ComponentModel.DataAnnotations;

namespace AppAspMVC.Models
{
    public class WebUser
    {
        [Display(Name = "UserNo")]
        public int Id { get; set; }
        [Display(Name = "User")]
        public string UserName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
        [Display(Name = "Photo")] //change name of attribute in the page

        public string UImage { get; set; }
    }
}
