using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Apitarea2.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }

        [Display(Name = "Nombre de la clase")]
        [Required(ErrorMessage = "debe ingresar nombre de la clase")]
        [StringLength(30)]
        public string Title { get; set; }

        [Display(Name = "numero de creditos")]
        [Required(ErrorMessage = "debe ingresar los creditos")]
        public int Credits { get; set; }


        [Display(Name = "ID del departamento")]
        [Required(ErrorMessage = "debe ingresar el ID del departamento")]
        public int DepartamentID { get; set; }

        public virtual ICollection <Enrollment> Enrollments { get; set; }
    }
}