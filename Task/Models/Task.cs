using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Task.Models
{
    /// <summary>
    /// Задача
    /// </summary>
    public class Task
    {
      
        public int TaskID { get; set; }

        [Required(ErrorMessage = "Введите задачу")]
        [Display(Name = "Задача")]
        public string TaskTopic { get; set; }

        [Display(Name = "Пояснение")]
        public string TaskNote { get; set; }

        [Display(Name = "Дата")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Введи дату")]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
       

    }
}