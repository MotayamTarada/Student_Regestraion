using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HopeRegistration.Controllers
{
    public class StudentController : Controller
    {
        Entities.HopeRegistrationNovContext context = new Entities.HopeRegistrationNovContext();
        public IActionResult GetAllStudents()
        {
            List<Models.StudentModel> lst = (from x in context.Students.ToList()
                                             join y in context.Nationalities.ToList() on x.NationalityId equals y.NationalityId
                                             select new Models.StudentModel
                                             {
                                                 FirstName = x.FirstName,
                                                 LastName = x.LastName,
                                                 GenderDisplayName = x.Gender.HasValue ? (x.Gender.Value == true ? "Male" : "Female") : "",
                                                 Mobile = x.Mobile,
                                                 DateOfBirth = x.DateOfBirth,
                                                 StudentId = x.StudentId,
                                                 NationalityId = x.NationalityId.HasValue ? x.NationalityId.Value: -1,
                                                 NationalityName = y.NationalityName,
                                             }).ToList();


            return View(lst);
        }

        public IActionResult AddNewStudent()
        {
            ViewBag.Nationality = context.Nationalities.ToList();
            ViewBag.GradeNumber = context.GradeNumbers.ToList();
            ViewBag.Section = context.SectionNumbers.ToList();

            return View();
        }

        public IActionResult Save(Models.StudentModel studentModel)
        {
            Entities.Student student = new Entities.Student();
            student.FirstName = studentModel.FirstName;
            student.LastName = studentModel.LastName;
            student.DateOfBirth = studentModel.DateOfBirth;
            student.Mobile = studentModel.Mobile;
            student.Gender = studentModel.Gender;
            student.NationalityId = studentModel.NationalityId;

            context.Students.Add(student);
            context.SaveChanges();

            Entities.TeacherStudent teacherStudent  = new Entities.TeacherStudent();
            teacherStudent.StudentId = student.StudentId;
            teacherStudent.GradeNumberId = studentModel.GradeNumberId;
            teacherStudent.SectionNumberId = studentModel.SectionId;
            context.TeacherStudents.Add(teacherStudent);
            context.SaveChanges();



            return RedirectToAction("GetAllStudents");

        }

        public IActionResult UpdateStudent(int Id)
        {
            ViewBag.Nationality = context.Nationalities.ToList();

            var result = context.Students.Where(x => x.StudentId == Id).FirstOrDefault();

            Models.StudentModel studentModel = new Models.StudentModel();

            studentModel.StudentId = result.StudentId;
            studentModel.FirstName = result.FirstName;
            studentModel.LastName = result.LastName;
            studentModel.Mobile = result.Mobile;
            if (result.NationalityId.HasValue)
            {
                studentModel.NationalityId = result.NationalityId.Value;
            }
            studentModel.DateOfBirth = result.DateOfBirth;

            return View (studentModel);

        }


        public IActionResult Update(Models.StudentModel studentModel)
        {

            var result = context.Students.Where(x => x.StudentId == studentModel.StudentId).FirstOrDefault();


            result.FirstName = studentModel.FirstName;
            result.LastName = studentModel.LastName;
            result.Gender = studentModel.Gender;
            result.Mobile = studentModel.Mobile;
            result.DateOfBirth = studentModel.DateOfBirth;
            result.NationalityId = studentModel.NationalityId;

            context.SaveChanges();


            return RedirectToAction("GetAllStudents");
        }

        public IActionResult DeleteStudent(int Id)
        {
            Entities.Student student = new Entities.Student();
            student = context.Students.Where(x => x.StudentId == Id).FirstOrDefault(); 
            context.Students.Remove(student); 
            context.SaveChanges(); 
            

            return RedirectToAction("GetAllStudents");
        }

    }
}
