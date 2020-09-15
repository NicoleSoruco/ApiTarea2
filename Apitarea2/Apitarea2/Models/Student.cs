using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Apitarea2.Models
{
    public class Student
    {
        [Key]
        public int SorucoID { get; set; }

        [Display(Name ="Apellido")]
        [StringLength(30)]
        public string LastName { get; set; }

        [Display(Name = "Nombre completo")]
        [Required(ErrorMessage ="debe ingresar nombre")]
        [StringLength(10)]
        public string FirstMidName { get; set; }


        [DataType(DataType.Date)]
        [Display(Name = "Fecha")]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }


        public virtual ICollection <Enrollment> Enrollments { get; set; }
    }
}