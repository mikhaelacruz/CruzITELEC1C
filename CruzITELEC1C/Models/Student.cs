using System.ComponentModel.DataAnnotations;

namespace CruzITELEC1C.Models
{ 
    public enum Course
    {
        BSIT, BSCS, BSIS
    }
    public class StudentList
    {
        [Required]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [Display(Name = "Name")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Date of Enrollment is required.")]
        [Display(Name = "Date Enrolled")]
        public DateTime DateEnrolled { get; set; }

        [Required(ErrorMessage = "Course is required.")]
        [Display(Name = "Course")]
        public Course Course { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [Display(Name = "Email")]
        public string StudentEmail { get; set; }

    }
}
