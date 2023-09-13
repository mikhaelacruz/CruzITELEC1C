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
                InstructorName = "Gabriel Montano", DateHired = DateTime.Now,
                InstructorEmail = "gdmontano@ust.edu.ph", Rank = Rank.Instructor, 
                InstructorId = 100
            },
            new Instructor()
            {
                InstructorName = "Leo Lintag", DateHired = DateTime.Parse("25/5/2020"),
                InstructorEmail = "llintag@ust.edu.ph", Rank = Rank.AsstProf,
                InstructorId = 200
            },
            new Instructor()
            {
                InstructorName = "Kirby Wenceslao", DateHired = DateTime.Parse("14/7/2019"),
                InstructorEmail = "kwenceslao@ust.edu.ph", Rank = Rank.Prof,
                InstructorId = 300
            },
        };
        public IActionResult Index()
        {
            return View(InstructorList);
        }

        public IActionResult ShowDetails()
        {
            return View();
        }
    }
}
