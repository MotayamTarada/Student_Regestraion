using HopeRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HopeRegistration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Entities.HopeRegistrationNovContext context = new Entities.HopeRegistrationNovContext();

            ViewBag.Teachers = context.Teachers.Count();
            ViewBag.Students = context.Students.Count();
            ViewBag.Grades = context.GradeNumbers.Count();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult LoginToSystem(Models.LoginModel  loginModel)
        {

            if (loginModel.UserName.ToLower() == "Admin".ToLower() && loginModel.Password == "Admin")
                return RedirectToAction("Index");
            else
                  return RedirectToAction("Login");
        }

        public IActionResult StudentDetails()
        {

            Entities.HopeRegistrationNovContext context = new Entities.HopeRegistrationNovContext();


            List<Models.StudentDetailsModel> ListData1 = new List<StudentDetailsModel>();
            List<Models.StudentDetailsModel> ListData2 = new List<StudentDetailsModel>();
            List<Models.StudentDetailsModel> FinalList = new List<StudentDetailsModel>();

            ListData1 = (from TS in context.TeacherStudents.Include(x => x.Student).Include(x => x.GradeNumber).Include(x => x.SectionNumber).ToList()
                         select new Models.StudentDetailsModel
                         {
                             TeacherName = "",
                             StudentName = TS.Student.FirstName + " " + TS.Student.LastName,
                             ClassName = TS.GradeNumber.Name,
                             SectionName = TS.SectionNumber.Name,
                             GradeNumberId = TS.GradeNumberId,
                             SectionId = TS.SectionNumberId,

                         }).ToList();

            ListData2 = (from TS in context.TeacherGradeNumbers.Include(x => x.Teacher).Include(x => x.GradeNumber).Include(x => x.SectionNumber).ToList()
                         select new Models.StudentDetailsModel
                         {
                             TeacherName = TS.Teacher.FirstName + " " + TS.Teacher.LastName,
                             StudentName = "",
                             ClassName = TS.GradeNumber.Name,
                             SectionName = TS.SectionNumber.Name,
                             GradeNumberId = TS.GradeNumberId,
                             SectionId = TS.SectionNumberId,
                         }).ToList();


            foreach (Models.StudentDetailsModel item in ListData1)
            {
                Models.StudentDetailsModel obj = new StudentDetailsModel();
                obj.StudentName = item.StudentName;
               var result= ListData2.Where(x => x.GradeNumberId == item.GradeNumberId && x.SectionId == item.SectionId).FirstOrDefault();
                if (result != null)
                    obj.TeacherName = result.TeacherName;
                else
                    obj.TeacherName = "";

                obj.SectionName = item.SectionName;
                obj.ClassName = item.ClassName;

               FinalList.Add(obj);
            }


            foreach (Models.StudentDetailsModel item in ListData2)
            {
                Models.StudentDetailsModel obj = new StudentDetailsModel();
                obj.TeacherName = item.TeacherName;
                var result = ListData1.Where(x => x.GradeNumberId == item.GradeNumberId && x.SectionId == item.SectionId).FirstOrDefault();
                if (result != null)
                    obj.StudentName = result.StudentName;
                else
                    obj.StudentName = "";

                obj.SectionName = item.SectionName;
                obj.ClassName = item.ClassName;

                if(!FinalList.Contains(obj))
                FinalList.Add(obj);
            }







            //                        join TGN in context.TeacherGradeNumbers.ToList() on TS.GradeNumberId equals TGN.GradeNumberId

            return View(FinalList);

        }
    }
}
