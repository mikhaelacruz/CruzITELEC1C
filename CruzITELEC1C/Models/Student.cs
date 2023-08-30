namespace CruzITELEC1C.Models
{ 
    
    public enum Course
    {
        BSIT, BSCS, BSIS
    }
    public class Student
    {
        
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateTime DateEnrolled { get; set; }
        public Course Course { get; set; }
        public string Email { get; set; }

    }
}
