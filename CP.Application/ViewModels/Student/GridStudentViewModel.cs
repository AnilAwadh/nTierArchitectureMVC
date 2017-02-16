using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.Application.ViewModels.Student
{
    public class GridStudentViewModel
    {
        public Guid StudentId { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [Display(Name = "Date of birth")]
        //[DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Display(Name = "Situation")]
        public bool Active { get; set; }
    }
}
