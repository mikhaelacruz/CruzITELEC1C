using Microsoft.AspNetCore.Mvc;
using CruzITELEC1C.Models;
using CruzITELEC1C.Services;

namespace CruzITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        private readonly IMyFakeDataService _dummyData;
        public StudentController(IMyFakeDataService dummyData)
        {
            _dummyData = dummyData;
        }
        public IActionResult Index()
        {
            return View(_dummyData.StudentList);
        }

        public IActionResult ShowDetails(int id)
        {
            StudentList? student = _dummyData.StudentList.FirstOrDefault(t => t.StudentId == id);

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
        public IActionResult AddStudent(StudentList NewStudent)
        {
            if (!ModelState.IsValid)
                return View();

            _dummyData.StudentList.Add(NewStudent);
            return View("Index", _dummyData.StudentList);
        }

        [HttpGet]
        public IActionResult UpdateStudent(int id)
        {

            StudentList? student = _dummyData.StudentList.FirstOrDefault(t => t.StudentId == id);

            if (student != null)
            {
                return View(student);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult UpdateStudent(StudentList UpdateStudent)
        {
            StudentList? student = _dummyData.StudentList.FirstOrDefault(t => t.StudentId == UpdateStudent.StudentId);

            if (student != null)
            {
                student.StudentId = UpdateStudent.StudentId;
                student.StudentName = UpdateStudent.StudentName;
                student.StudentEmail = UpdateStudent.StudentEmail;
                student.Course = UpdateStudent.Course;
                student.DateEnrolled = UpdateStudent.DateEnrolled;
            };

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            StudentList? student = _dummyData.StudentList.FirstOrDefault(t => t.StudentId == id);

            if (student != null)
            {
                return View(student);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Delete(StudentList newStudent)
        {

            StudentList? student = _dummyData.StudentList.FirstOrDefault(t => t.StudentId == newStudent.StudentId);

            if (student != null)
                _dummyData.StudentList.Remove(student);

            return RedirectToAction("Index");
        }
    }
}

