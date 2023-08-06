using System.ComponentModel.DataAnnotations;
namespace FirstMVC.Models
{
    public class Contact
    {
        [Display(Name="Введите имя")]
        [Required(ErrorMessage ="Вам нужно ввести имя")]
        public string Name { get; set; }
        [Display(Name = "Введите фамилию")]
        [Required(ErrorMessage = "Вам нужно ввести фамилию")]
        public string SurName { get; set; }
        [Display(Name = "Введите email")]
        [Required(ErrorMessage = "Вам нужно ввести email")]
        public string Email { get; set; }
        [Display(Name = "Введите сообщения")]
        [StringLength(10, ErrorMessage ="текс не менее 10 сиволов" )]
        [Required(ErrorMessage = "Вам нужно ввести сообщение")]
        public string Message { get; set; }
        [Display(Name = "Введите возраст")]
        [Required(ErrorMessage = "Вам нужно ввести возраст")]
        public int Age { get; set; }

    }
}
