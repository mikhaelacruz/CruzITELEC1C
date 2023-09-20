using Microsoft.AspNetCore.Mvc;
using CruzITELEC1C.Models;

namespace CruzITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        List<Student> StudentList = new List<Student>()
        { new Student()
            {
                StudentName = "Mikhaela Cruz", DateEnrolled = DateTime.Now,
                StudentEmail = "mikhaela.cruz.cics@ust.edu.ph", Course = Course.BSIS,
                StudentId = 100
            },
            new Student()
            {
                StudentName = "Ollie Bahinting", DateEnrolled = DateTime.Parse("25/5/2020"),
                StudentEmail = "ollie.bahinting.cics@ust.edu.ph", Course = Course.BSIT,
                StudentId = 200
            },
            new Student()
            {
                StudentName = "Kirby Wenceslao", DateEnrolled = DateTime.Parse("14/7/2019"),
                StudentEmail = "kirby.wenceslao.cics@ust.edu.ph", Course = Course.BSCS,
                StudentId = 300
            },

        };
        public IActionResult Index()
        {
            return View(StudentList);
        }

        public IActionResult ShowDetails(int id)
        {
            Student? student = StudentList.FirstOrDefault(t => t.StudentId == id);

            if (student != null)
            {
                return View(student);
            }
            return NotFound();
        }
        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student newstudent)
        {

            StudentList.Add(newstudent);
            return View("Index", StudentList);
        }
        public IActionResult UpdateStudent(int id)
        {

            Student? student = StudentList.FirstOrDefault(t => t.StudentId == id);

            if (student != null)
            {
                return View(student);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult UpdateStudent(Student UpdateStudent)
        {
            Student? student = StudentList.FirstOrDefault(t => t.StudentId == UpdateStudent.StudentId);

            if (student != null)
            {
                student.StudentName = UpdateStudent.StudentName;
                student.StudentEmail = UpdateStudent.StudentEmail;
                student.Course = UpdateStudent.Course;
            };

            return View("Index", StudentList);
        }
    }
}
