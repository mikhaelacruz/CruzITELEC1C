using Microsoft.AspNetCore.Mvc;
using CruzITELEC1C.Models;
using CruzITELEC1C.Services;

namespace CruzITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IMyFakeDataService _testData;
        public InstructorController(IMyFakeDataService testData)
        {
            _testData = testData;
        }
        public IActionResult Index()
        {
            return View(_testData.InstructorList);
        }

        public IActionResult ShowDetails(int id)
        {
            Instructor? instructor = _testData.InstructorList.FirstOrDefault(st => st.InstructorId == id);

            if (instructor != null)
            {
                return View(instructor);
            }
            return NotFound();
        }

        [HttpGet]
        public IActionResult AddInst()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddInst(Instructor NewInstructor)
        {
            _testData.InstructorList.Add(NewInstructor);
            return View("Index", _testData.InstructorList);
        }
        public IActionResult UpdateInstructor(int id)
        {

            Instructor? instructor = _testData.InstructorList.FirstOrDefault(t => t.InstructorId == id);

            if (instructor != null)
            {
                return View(instructor);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult UpdateInstructor(Instructor UpdateInstructor)
        {
            Instructor? instructor = _testData.InstructorList.FirstOrDefault(t => t.InstructorId == UpdateInstructor.InstructorId);

            if (instructor != null)
            {
                instructor.InstructorFirstName = UpdateInstructor.InstructorFirstName;
                instructor.InstructorLastName = UpdateInstructor.InstructorLastName;
                instructor.IsTenured = UpdateInstructor.IsTenured;
                instructor.Rank = UpdateInstructor.Rank;
                instructor.DateHired = UpdateInstructor.DateHired;
            };

            return View("Index", _testData.InstructorList);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {

            Instructor? instructor = _testData.InstructorList.FirstOrDefault(t => t.InstructorId == id);
            return View(instructor);
        }

        [HttpPost]
        public IActionResult Delete(Instructor newInstructor)
        {

            Instructor? instructor = _testData.InstructorList.FirstOrDefault(t => t.InstructorId == newInstructor.InstructorId);
            if (instructor != null)
                _testData.InstructorList.Remove(instructor);
            return View("Index", _testData.InstructorList);
        }

    }
}

