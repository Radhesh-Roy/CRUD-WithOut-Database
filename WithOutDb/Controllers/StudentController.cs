using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using WithOutDb.Models;

namespace WithOutDb.Controllers
{
    public class StudentController: Controller
    {
       

        List<Student> students = new List<Student>()
            {
            new Student(1,343,"Radhesh","CSE","Eight","rj@gmail.com"),
            new Student(2,3434,"Joy","CSE","Eight","rj@gmail.com"),
            new Student(3,34343,"Sofik","CSE","Eight","rj@gmail.com"),
            new Student(4,3434,"Nipon","CSE","Eight","rj@gmail.com"),
            new Student(5,3435,"Jibon","CSE","Eight","rj@gmail.com"),
            new Student(6,553,"Radhesh","CSE","Eight","rj@gmail.com"),
            };

        [HttpGet]
        public IActionResult Index()
        {
           
            return View(students);
        }

        [HttpGet]
        public IActionResult CreateOrEdit()
        {
            return View();  

        }

        [HttpPost]  
        public IActionResult CreateOrEdit(int id,Student student)
        {
            if (id==0)
            {
                
                    students.Add(student);
                    return RedirectToAction(nameof(Index));
                
            }
            else
            {
               
                return RedirectToAction(nameof(Index));
            }

            

        }
        [HttpGet]
        public IActionResult Delete(int id,Student student)
        {
            var data = students[id];
            if (data !=null)
            {
                students.Remove(student);
                return RedirectToAction(nameof(Index));

            }
            return RedirectToAction(nameof(Index));
        }
    }
}
