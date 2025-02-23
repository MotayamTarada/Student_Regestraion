using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HopeRegistration.Controllers
{
    public class TeacherController : Controller
    {
        Entities.HopeRegistrationNovContext context = new Entities.HopeRegistrationNovContext();

        public IActionResult GetAllTeachers()
        {
            //var listGradeNumbers = context.GradeNumbers.ToList();
           // var ListSectionNumbers = context.SectionNumbers.ToList();
           // var ListTeacher = context.Teachers.ToList();
           // List<int> teacherIds = ListTeacher.Select(x => x.TeacherId).ToList();
          List<Entities.TeacherGradeNumber>  ListTeacherGrader = context.TeacherGradeNumbers.ToList();

            List<Models.TeacherModel> lst = (from x in context.Teachers.ToList()
                                             select new Models.TeacherModel
                                             {
                                                 FirstName = x.FirstName,
                                                 LastName = x.LastName,
                                                 GenderDisplayName = x.Gender.HasValue ? (x.Gender.Value == true ? "Male" : "Female") : "",
                                                 Mobile = x.Mobile,
                                                 HireDate = x.HireDate,
                                                 TeacherId = x.TeacherId,
                                                Education = x.Education,
                                                Salary = x.Salary,
                                                 Subject = x.Subject,
                                                  GradeNumberName = ReturnGradeNumberName(x.TeacherId, ListTeacherGrader),
                                                  SectionName = ReturnSectionName(x.TeacherId, ListTeacherGrader),
                                             }).ToList();


            return View(lst);
        }


        public string ReturnGradeNumberName(int _teacherId, List<Entities.TeacherGradeNumber> data)
        {
           var result = data.Where(x => x.TeacherId == _teacherId).FirstOrDefault();
            if (result != null)
                return context.GradeNumbers.Where(x => x.GradeNumberId == result.GradeNumberId).FirstOrDefault().Name;
            else
            return "";
        }

        public string ReturnSectionName(int _teacherId, List<Entities.TeacherGradeNumber> data)
        {
            var result = data.Where(x => x.TeacherId == _teacherId).FirstOrDefault();
            if (result != null)
                return context.SectionNumbers.Where(x => x.SectionNumberId == result.SectionNumberId).FirstOrDefault().Name;
            else
                return "";
        }

        public IActionResult AddNewTeacher()
        {

            ViewBag.GradeNumber = context.GradeNumbers.ToList();
            ViewBag.Section = context.SectionNumbers.ToList();

            return View();
        }

        public IActionResult Save(Models.TeacherModel model)
        {
            Entities.Teacher teacher = new Entities.Teacher();
            teacher.FirstName = model.FirstName;
            teacher.LastName = model.LastName;
            teacher.HireDate = model.HireDate;
            teacher.Mobile = model.Mobile;
            teacher.Gender = model.Gender;
            teacher.Subject = model.Subject;
            teacher.Salary = model.Salary;
            teacher.Education = model.Education;

            context.Teachers.Add(teacher);
            context.SaveChanges();
 
            Entities.TeacherGradeNumber teacherGradeNumber = new Entities.TeacherGradeNumber();
            teacherGradeNumber.TeacherId = teacher.TeacherId;
            teacherGradeNumber.GradeNumberId = model.GradeNumberId;
            teacherGradeNumber.SectionNumberId = model.SectionId;
            context.TeacherGradeNumbers.Add(teacherGradeNumber);
            context.SaveChanges();


            return RedirectToAction("GetAllTeachers");
        }
    }
}
