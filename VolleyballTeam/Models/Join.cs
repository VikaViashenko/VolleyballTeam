using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace VolleyballTeam.Models
{
    public class Join
    {
        [Display(Name = "Ім'я")]
        [Required(ErrorMessage = "Введіть ім'я!")]
        public string Name { get; set; }

        [Display(Name = "Прізвище")]
        [Required(ErrorMessage = "Введіть прізвище!")]
        public string Surname { get; set; }

        [Display(Name = "Стать")]
        public string Sex { get; set; }

        [Display(Name = "Вік")]
        [Required(ErrorMessage = "Введіть ваш вік!")]
        public int Age { get; set; }

        [Display(Name = "Номер телефону")]
        [Required(ErrorMessage = "Введіть номер телефону!")]
        public int Phone { get; set; }

        [Display(Name = "Імейл")]
        public string Email { get; set; }

        [Display(Name = "Ваш ріст")]
        public int Height { get; set; }

        [Display(Name = "Вашу вагу")]
        public int Weight { get; set; }

        [Display(Name = "Коментар")]
        [StringLength(100, ErrorMessage = "Ваш коментар не може містити більше ніж 100 символів")]
        public string Comment { get; set; }

    }
}
