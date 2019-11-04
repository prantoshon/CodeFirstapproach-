using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Model.Model;
using WebApp.DatabaseContext;

namespace WebApp.Repository.Repository
{
   public class StudentRepository
    {
        ProjectDbContext _dbContext = new ProjectDbContext();
        public bool Add(StudentModel student)
        {
            _dbContext.Students.Add(student);
            return _dbContext.SaveChanges() > 0;
            
        }

        public bool Delete(int id)
        {
            StudentModel aStudent = _dbContext.Students.FirstOrDefault(c => c.Id == id);
            _dbContext.Students.Remove(aStudent);
            return _dbContext.SaveChanges() > 0;
        }

        public bool Upadte(StudentModel student)
        {
            StudentModel aStudent = _dbContext.Students.FirstOrDefault(c => c.Id == student.Id);
            if (aStudent != null)
            {
                aStudent.Roll = student.Roll;
                aStudent.Address = student.Address;
                aStudent.Name = student.Name;
                aStudent.Age = student.Age;
            }

            return _dbContext.SaveChanges() > 0;
        }

        public List<StudentModel> GetAll()
        {
           // List<StudentModel> students= new List<StudentModel>();
           return _dbContext.Students.ToList();

        }

        public StudentModel GetById(int id)
        {
            // StudentModel student = new StudentModel();
           return _dbContext.Students.FirstOrDefault(c => c.Id == id);
            
        }

    }
}
