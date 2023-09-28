using CruzITELEC1C.Models;
using CruzITELEC1C.Services;
using System;
using System.Collections.Generic;

namespace CruzITELEC1C.Services
{
    public class MyFakeDataService : IMyFakeDataService
    {
        public List<Student> StudentList { get; }
        public List<Instructor> InstructorList { get; }

        public MyFakeDataService() // constructor
        {
            // Initialize StudentList
            StudentList = new List<Student>
            {
                new Student()
                {
                    StudentName = "Mikhaela Cruz",
                    DateEnrolled = DateTime.Now,
                    StudentEmail = "mikhaela.cruz.cics@ust.edu.ph",
                    Course = Course.BSIS,
                    StudentId = 100
                },
                new Student()
                {
                    StudentName = "Ollie Bahinting",
                    DateEnrolled = DateTime.Parse("25/5/2020"),
                    StudentEmail = "ollie.bahinting.cics@ust.edu.ph",
                    Course = Course.BSIT,
                    StudentId = 200
                },
                new Student()
                {
                    StudentName = "Kirby Wenceslao",
                    DateEnrolled = DateTime.Parse("14/7/2019"),
                    StudentEmail = "kirby.wenceslao.cics@ust.edu.ph",
                    Course = Course.BSCS,
                    StudentId = 300
                }
            };

            // Initialize InstructorList
            InstructorList = new List<Instructor>
            {
                new Instructor()
                {
                    InstructorId = 1,
                    InstructorFirstName = "Gabriel",
                    InstructorLastName = "Montano",
                    IsTenured = true,
                    InstructorEmail = "gabrielmontano@ust.edu.ph",
                    Rank = Rank.Instructor,
                    DateHired = DateTime.Now
                },
                new Instructor()
                {
                    InstructorId = 2,
                    InstructorFirstName = "Mikhaela",
                    InstructorLastName = "Cruz",
                    IsTenured = true,
                    InstructorEmail = "mikhaela.cruz.cics@ust.edu.ph",
                    Rank = Rank.AsstProf,
                    DateHired = DateTime.Parse("12/06/2018")
                },
                new Instructor()
                {
                    InstructorId = 3,
                    InstructorFirstName = "Kirby",
                    InstructorLastName = "Wenceslao",
                    IsTenured = true,
                    InstructorEmail = "kirby.wenceslao.cics@ust.edu.ph",
                    Rank = Rank.Prof,
                    DateHired = DateTime.Parse("28/08/2015")
                }
            };
        }
    }
}
