using System.ComponentModel.DataAnnotations;

namespace CruzITELEC1C.Models
{ public enum Rank
    {
        Instructor, AsstProf, Prof
    }
    public class Instructor
    {
        public int InstructorId { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [Display(Name = "First name")]
        public string InstructorFirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name")]
        public string InstructorLastName { get; set; }

        [Display(Name = "Is tenured")]
        public bool IsTenured { get; set; }

        [Display(Name = "Date Hired")]
        [DataType(DataType.Date)]
        public DateTime DateHired { get; set; }

        [Display(Name = "Rank")]
        public Rank Rank { get; set; }

        [EmailAddress]
        [Display(Name = "Email")]
        public string InstructorEmail { get; set; }

    }
}
