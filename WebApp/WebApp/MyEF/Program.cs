using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Model.Model;
using WebApp.BLL.BLL;


namespace MyEF
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentModel _studentModel = new StudentModel()
            {
                Roll = "1001",
                Name = "Rafiq",
               // Id = 40,
                Address = "Dhaka",
                Age = 10
            };
            StudentManager _studentManager = new StudentManager();

            //if (_studentManager.Add(_studentModel))
            //{
            //    Console.WriteLine("Save");
                
            //}
            //else
            //{
            //    Console.WriteLine("Not");

            //}


            //if (_studentManager.Delete(id:1))
            //{
            //    Console.WriteLine("Delete");

            //}
            //else
            //{
            //    Console.WriteLine("Not");

            //}

            _studentModel.Id = 3;
            _studentModel.Name = "Rakib";
            _studentModel.Address = "Ctg";
            _studentModel.Roll = "1004";

            //if (_studentManager.Upadte(_studentModel))
            //{
            //    Console.WriteLine("Update");
            //}
            //else
            //{
            //    Console.WriteLine("Not");

            //}

            var students = _studentManager.GetAll();
            var getById = _studentManager.GetById(id:2);

            Console.ReadLine();

        }
    }
}
