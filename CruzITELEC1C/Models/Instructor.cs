namespace CruzITELEC1C.Models
{ public enum Rank
    {
        Instructor, AsstProf, Prof
    }
    public class Instructor
    {
        public int InstructorId { get; set; }

        public string InstructorFirstName { get; set; }

        public string InstructorLastName { get; set; }

        public bool IsTenured { get; set; }

        public DateTime DateHired { get; set; }

        public Rank Rank { get; set; }

        public string InstructorEmail { get; set; }

    }
}
