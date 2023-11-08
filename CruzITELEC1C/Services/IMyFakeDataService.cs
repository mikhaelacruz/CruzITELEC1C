using CruzITELEC1C.Models;
namespace CruzITELEC1C.Services
{
    public interface IMyFakeDataService
    { 
        List<StudentList> StudentList { get; }
        List<Instructor> InstructorList { get; }
    }
}
