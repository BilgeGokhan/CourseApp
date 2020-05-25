using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Web.Models
{
    public class Student
    {
        [Required(ErrorMessage ="İsminizi giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email giriniz.")]
        [EmailAddress(ErrorMessage = "Email adresinizi formata uygun girmelisiniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefonunuzu giriniz.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Kursa katılıp katılmayacağınızı bildirir misiniz.")]
        public bool? WillAttend { get; set; }
    }
}
