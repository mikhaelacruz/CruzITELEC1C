using Microsoft.AspNetCore.Mvc;
using CruzITELEC1C.Models;

namespace CruzITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>()
        {
            new Instructor()
            {
                InstructorId=1, InstructorFirstName = "Gabriel", InstructorLastName = "Montano", IsTenured= true,
                InstructorEmail ="gabrielmontano@ust.edu.ph", Rank = Rank.Instructor, DateHired = DateTime.Now
            },
            new Instructor()
            {
                InstructorId=2, InstructorFirstName = "Mikhaela", InstructorLastName = "Cruz", IsTenured= true,
                InstructorEmail ="mikhaela.cruz.cics@ust.edu.ph", Rank = Rank.AsstProf, DateHired = DateTime.Parse("12/06/2018")
            },
            new Instructor()
            {
                InstructorId=3, InstructorFirstName = "Kirby", InstructorLastName = "Wenceslao", IsTenured= true,
                InstructorEmail ="kirby.wenceslao.cics@ust.edu.ph", Rank = Rank.Prof, DateHired = DateTime.Parse("28/08/2015")
            },
        };
        public IActionResult Index()
        {
            return View(InstructorList);
        }

        public IActionResult ShowDetails(int id)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.InstructorId == id);

            if (instructor != null)
                return View(instructor);

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
            InstructorList.Add(NewInstructor);
            return View("Index", InstructorList);
        }
        public IActionResult UpdateInstructor(int id)
        {

            Instructor? student = InstructorList.FirstOrDefault(t => t.InstructorId == id);

            if (student != null)
            {
                return View(student);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult UpdateInstructor(Instructor UpdateInstructor)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(t => t.InstructorId == UpdateInstructor.InstructorId);

            if (instructor != null)
            {
                instructor.InstructorFirstName = UpdateInstructor.InstructorFirstName;
                instructor.InstructorLastName = UpdateInstructor.InstructorLastName;

            };

            return View("Index", InstructorList);
        }

    }
}

