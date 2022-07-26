using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Sample_CV.Models
{
    public class Contact
    {
        [Required(ErrorMessage ="این بند اجباری است")]
        [MinLength(3,ErrorMessage ="نام باید حاوی حداقل 3 کاراکتر باشد ")]
        [MaxLength(100,ErrorMessage="حداکثر 100 کاراکتر مجاز می باشد")]
        public string Name { get; set; }

        [Required(ErrorMessage = "این بند اجباری است")]

        [EmailAddress(ErrorMessage ="ایمیل معتبر نیست")]
        public string Email { get; set; }

        public int Service { get; set; }

        [Required(ErrorMessage = "این بند اجباری است")]
        [MaxLength(1000, ErrorMessage = "حداکثر 100 کاراکتر مجاز می باشد")]

        public string msg { get; set; }

        public SelectList Services { get; set; }
    }
}
