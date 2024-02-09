using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Entityes
{
    public class Participant
    {
        public int Id { get; set; }

        [Display(Name = "Фамилия Имя")]
        [Required(ErrorMessage = "Введите Фамилию и Имя")]
        [StringLength(128, ErrorMessage = "Длинное Имя и фамилия")]
        public string NameParticipant { get; set; }

        [Display(Name = "Возраст")]
        [Required(ErrorMessage = "Введите возраст")]
        public int Age { get; set; }

        [Display(Name = "Опыт")]
        [Required(ErrorMessage = "Введите свой опыт")]
        public int Experience { get; set; }

        [Display(Name = "Город")]
        [Required(ErrorMessage = "Введите город")]
        [StringLength(128, ErrorMessage = "Сильно большое название города")]
        public string City { get; set; }

        [Display(Name = "Пол")]
        [Required(ErrorMessage = "Введите выберите пол")]
        public List<Gender> GenderId { get; set; }

    }
}
