using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Apitarea2.Models
{
    public enum CategoryGrade
    {
        D=10,
        C=30,
        B=20,
        A= 40,

    }
    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }

        [Required(ErrorMessage = "debe ingresar el codigo del curso")]
        [Display(Name = "ID del curso")]
        public int CourseID { get; set; }

        [Required(ErrorMessage = "debe ingresar el codigo del alumno")]
        [Display(Name = "ID del estudiante")]
        public int StudentID { get; set; }

        [DisplayFormat(NullDisplayText = "")]
        [Required(ErrorMessage = "debe ingresar la categoria del grado")]
        public CategoryGrade Grade { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}