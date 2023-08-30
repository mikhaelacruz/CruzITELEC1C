using Microsoft.AspNetCore.Mvc;
using CruzITELEC1C.Models;

namespace CruzITELEC1C.Controllers
{
    public class StudentController : Controller
    {

        public IActionResult Index()
        {
            Student st = new Student();
            st.StudentId = 2021154560;
            st.StudentName = "Mikhaela Cruz";
            st.DateEnrolled = DateTime.Parse("30/8/2023");
            st.Course = Course.BSIT;
            st.Email = "mikhaela.cruz.cics@ust.edu.ph";

            ViewBag.student = st;
            return View();
        }
    }
}
