using CruzITELEC1C.Models;
namespace CruzITELEC1C.Services
{
    public interface IMyFakeDataService
    { 
        List<Student> StudentList { get; }
        List<Instructor> InstructorList { get; }
    }
}
