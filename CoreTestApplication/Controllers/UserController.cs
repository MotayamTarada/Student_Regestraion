using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTestApplication.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddUser()
        {
            return View();
        }


        public IActionResult SaveNewUser(Models.UserModel userModel)
        {
            // Save on Database
            Entities.HopeOctoberContext context = new Entities.HopeOctoberContext();
            Entities.User user = new Entities.User();

            user.FirstName = userModel.FirstName;
            user.LastName = userModel.LastName;
            user.Email = userModel.Email;
            user.Comments = userModel.Comments;
            user.Gender = userModel.Gender;
            user.Mobile = userModel.Mobile;

            context.Users.Add(user);
            context.SaveChanges();



            return RedirectToAction("GetAllUsers");
        }


        public IActionResult GetAllUsers()
        {
            Entities.HopeOctoberContext context = new Entities.HopeOctoberContext();

            List<Models.UserModel> lstUsers = new List<Models.UserModel>();

            lstUsers = (from obj in context.Users.ToList()
                        select new Models.UserModel
                        {
                            ID = obj.Id,
                            FirstName = obj.FirstName,
                            LastName = obj.LastName,
                            Email = obj.Email,
                            Comments = obj.Comments,
                            CommentsColor = obj.Comments.Count() > 10 ? "Red" : "Green",
                            Mobile = obj.Mobile,
                            Gender = obj.Gender,
                        }).ToList();

            return View(lstUsers);
        }

        public IActionResult UpdateUser(int Id)
        {
            Entities.HopeOctoberContext context = new Entities.HopeOctoberContext();

            Models.UserModel userModel = new Models.UserModel();

            Entities.User user = new Entities.User();
            user = context.Users.Where(x => x.Id == Id).FirstOrDefault();

            userModel.ID = user.Id;
            userModel.FirstName = user.FirstName;
            userModel.LastName = user.LastName;
            userModel.Email = user.Email;
            userModel.Mobile = user.Mobile;
            userModel.Comments = user.Comments;
            userModel.Gender = user.Gender;

            return View(userModel);
        }

        public IActionResult DeleteUser(int Id)
        {
            Entities.HopeOctoberContext context = new Entities.HopeOctoberContext();

            Entities.User user = new Entities.User();
            user = context.Users.Where(x => x.Id == Id).FirstOrDefault();

            context.Users.Remove(user);
            context.SaveChanges();

            return RedirectToAction("GetAllUsers");
        }

        public IActionResult Update(Models.UserModel userModel)
        {

            Entities.HopeOctoberContext context = new Entities.HopeOctoberContext();

            Entities.User user = new Entities.User();
            user = context.Users.Where(x => x.Id == userModel.ID).FirstOrDefault();

            user.FirstName = userModel.FirstName;
            user.LastName = userModel.LastName;
            user.Email = userModel.Email;
            user.Mobile = userModel.Mobile;
            user.Comments = userModel.Comments;
            user.Gender = userModel.Gender;

            context.SaveChanges();

            return RedirectToAction("GetAllUsers");
        }


        public IActionResult GetAllDoctor()
        {
            Entities.HopeOctoberContext context = new Entities.HopeOctoberContext();
            List<CustomDoctor> lst = (from x in context.Doctors.ToList()
                          select new CustomDoctor
                          {
                              DoctorId = x.DoctorId,
                              DoctorName = x.DoctorName
                          }).ToList();

            return Json(lst);

        }

        public class CustomDoctor
        {
            public int DoctorId { get; set; }
            public string DoctorName { get; set; }
        }
    }
}
