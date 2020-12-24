using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_mvc.Models
{
    public class Contact
    {
        [Required (ErrorMessage= "پر کردن این فیلد اجباری است.")]
        [MinLength(3, ErrorMessage = "حداقل کاراکتر باید 3 تا باشد.")]
        [MaxLength(15, ErrorMessage ="حداکثر کاراکتر باشد 15 تا باشد.")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage ="لطفا ایمیل وارد کنید.")]
        [Required(ErrorMessage = "پر کردن این فیلد اجباری است.")]
        public string Email { get; set; }
        public string Message { get; set; }
        public int Service { get; set; }
        public SelectList Services { get; set; }

        
    }
}
