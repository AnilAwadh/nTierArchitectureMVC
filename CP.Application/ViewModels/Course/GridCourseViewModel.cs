using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.Application.ViewModels.Course
{
    public class GridCourseViewModel
    {
        public Guid CourseId { get; set; }
        [Display(Name = "Course Name")]
        public string Name { get; set; }
        [Display(Name = "Type of course")]
        public string CourseType { get; set; }
        [Display(Name = "Situation")]
        public bool Active { get; set; }
        [Display(Name = "Registration date")]
        public DateTime RegistrationDate { get; set; }
    }
}
