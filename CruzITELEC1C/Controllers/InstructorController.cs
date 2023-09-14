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
                InstructorEmail ="mikhaela.cruz.cics@ust.edu.ph", Rank = Rank.AsstProf, DateHired = DateTime.Parse("28/09/2022")            },
            new Instructor()
            {
                InstructorId=3, InstructorFirstName = "Kirby", InstructorLastName = "Wenceslao", IsTenured= true,
                InstructorEmail ="kirby.wenceslao.cics@ust.edu.ph", Rank = Rank.Prof, DateHired = DateTime.Parse("28/07/2022")
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
    }
}
