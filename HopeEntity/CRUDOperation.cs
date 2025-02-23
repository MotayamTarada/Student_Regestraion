using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeEntity
{
    public class CRUDOperation
    {
        HopeEntity.HopeOctoberEntities entities = new HopeOctoberEntities();
        public void AddNewUser()
        {
            //HopeEntity.HopeOctoberEntities entities = new HopeOctoberEntities();

            HopeEntity.User user = new User();
            user.FirstName = "Ahmad";
            user.LastName = "Ahmad";
            user.Email = "Ahmad@test";
            user.Gender = true;
            user.Mobile = "0858588";
            user.Comments = "Test Comments";

            entities.Users.Add(user);
            entities.SaveChanges();

        }

        public void UpdateUser()
        {
           // HopeEntity.HopeOctoberEntities entities = new HopeOctoberEntities();

            HopeEntity.User user = new User();
            user = entities.Users.Where(x => x.ID == 4).FirstOrDefault();
            if (user != null)
            {
                user.FirstName = "Test";
                user.LastName = "Update";

                entities.SaveChanges();
            }
            else
            {
                // error
            }
        }

        public void DeleteUser()
        {
            //HopeEntity.HopeOctoberEntities entities = new HopeOctoberEntities();

            HopeEntity.User user = new User();
            user = entities.Users.Where(x => x.ID == 4).FirstOrDefault();

            entities.Users.Remove(user);
            entities.SaveChanges();

        }

        public void DeleteDoctor()
        {
            // HopeEntity.HopeOctoberEntities entities = new HopeOctoberEntities();

            Doctor doctor = new Doctor();

            int count = entities.Students.Where(x => x.DoctorId == 3).ToList().Count();

            if (count == 0)
            {
                doctor = entities.Doctors.Where(x => x.DoctorId == 3).FirstOrDefault();

                entities.Doctors.Remove(doctor);
                entities.SaveChanges();
            }
            else
            {
                // error
            }

        }

        public void GetAllUsers()
        {
           // HopeEntity.HopeOctoberEntities entities = new HopeOctoberEntities();

            List<User> lstusers = entities.Users.ToList();

            List<User> lstusers_V2 = (from x in entities.Users.ToList()
                                      select new User
                                      {
                                           FirstName = x.FirstName,
                                           LastName = x.LastName,
                                           Gender = x.Gender,
                                            
                                      }).ToList();

            List<CustomAbed> lstusers_V3 = (from x in entities.Users.ToList()
                                      select new CustomAbed
                                      {
                                          FirstName = x.FirstName,
                                          LastName = x.LastName,
                                          Gender = x.Gender == true ? "Male" : "Female",
                                      }).ToList();

            var lstusers_V4 = (from x in entities.Users.ToList()
                                            select new 
                                            {  
                                                FirstName = x.FirstName,
                                                LastName = x.LastName,
                                                Gender = x.Gender == true ? "Male" : "Female",
                                            }).ToList();

            var lstusers_V5 = entities.Users.SqlQuery("select First from Users").ToList();


        }

        public class CustomAbed
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Gender { get; set; }
        }

        public void AddNewDoctor()
        {
            //HopeEntity.HopeOctoberEntities entities = new HopeOctoberEntities();
            for (int i = 0; i < 1500; i++)
            {

            HopeEntity.Doctor obj = new Doctor();
            obj.DoctorName = "Ahmad" + DateTime.Now;

            entities.Doctors.Add(obj);
            entities.SaveChanges();

            }
        }


        public void GetAllStudentsMarks()
        {
           // HopeEntity.HopeOctoberEntities entities = new HopeOctoberEntities();

            var result = (from obj in entities.TeacherStudents.ToList()
                          join stud in entities.Students.ToList() on obj.StudentId equals stud.StudentId
                          join teach in entities.Teachers.ToList() on obj.TeacherId equals teach.TeacherId
                          select new
                          {
                              FirstName = stud.FirstName,
                              LastName = stud.LastName,
                              Mark = obj.Marks,
                              SubjectName = teach.TeacherSubject,

                          }).ToList();


            var result_V1 = (from obj in entities.TeacherStudents.ToList()
                          join stud in entities.Students.ToList() on obj.StudentId equals stud.StudentId
                          join teach in entities.Teachers.ToList() on obj.TeacherId equals teach.TeacherId
                          select new
                          {
                              FirstName = stud.FirstName,
                              LastName = stud.LastName,
                              Mark = obj.Marks,
                              SubjectName = teach.TeacherSubject,

                          }).Where(x => x.Mark == 80).FirstOrDefault();
        }

        public void CustomQueries()
        {

            var result_V10 = entities.Students.Where(x => x.FirstName.Contains("u") || x.LastName.Contains("u")).ToList();


            //HopeEntity.HopeOctoberEntities entities = new HopeOctoberEntities();

            //var result = entities.Teachers.Where(x => x.TeacherSubject == "Math").FirstOrDefault();

            //var ss = result.TeacherStudents.ToList()[0].StudentId;

            //var result_v2 = entities.Teachers.Where(x => x.TeacherSubject == "Math").First();

            //var result_v3 = entities.Teachers.Where(x => x.TeacherSubject == "Math").ToList().LastOrDefault();

            //var result_v4 = entities.Teachers.Where(x => x.TeacherSubject == "Math").ToList().Last();

            int mark = entities.TeacherStudents.ToList().OrderBy(x => x.Marks).LastOrDefault().Marks;

            int mark2 = entities.TeacherStudents.ToList().OrderByDescending(x => x.Marks).FirstOrDefault().Marks;

            int mark3 = entities.TeacherStudents.ToList().Max(x => x.Marks);

            double AVG1 = entities.TeacherStudents.ToList().Average(x => x.Marks);

            List<TeacherStudent> result100 = entities.TeacherStudents.ToList();


            int tempMark = 0;
            int count = 0;
            foreach (TeacherStudent item in result100)
            {
                tempMark = tempMark + item.Marks;
                count++;
            }

            for (int i = 0; i < result100.Count(); i++)
            {
                tempMark = tempMark + result100[i].Marks;
            }

            double AVG2 = tempMark / count;


            // Return Student First Name,Student Last Name, Doctor Name, Subject Name, Mark, Gender
        }


        public void GetLatestDoctors()
        {
            List<Doctor> lstDoctors = new List<Doctor>();

            lstDoctors = entities.Doctors.ToList().OrderByDescending(y => y.DoctorId).Take(2000).ToList();

        }


       
    }
}
