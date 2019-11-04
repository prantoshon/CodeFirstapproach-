using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Model.Model;
using WebApp.Repository.Repository;

namespace WebApp.BLL.BLL
{
    public class StudentManager
    {
        StudentRepository _studentRepository = new StudentRepository();
        public bool Add(StudentModel student)
        {
            return _studentRepository.Add(student);
        }

        public bool Delete(int id)
        {
            return _studentRepository.Delete(id);
        }

        public bool Upadte(StudentModel student)
        {
            return _studentRepository.Upadte(student);
        }

        public List<StudentModel> GetAll()
        {
            return _studentRepository.GetAll();
        }

        public StudentModel GetById(int id)
        {
            return _studentRepository.GetById(id);
        }

    }
}
