
using GiraoITELEC1C.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GiraoITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        List<Student> StudentList = new List<Student>
            {
                new Student()
                {
                    Id= 1,FirstName = "Patricia Yvonne",LastName = "Girao", Course = Course.BSIT, AdmissionDate = DateTime.Parse("2023-01-21"), GPA = 1.5, Email = "yvonne.girao@gmail.com"
                },
                new Student()
                {
                    Id= 2,FirstName = "Roxanne Alyssandra",LastName = "Debil", Course = Course.BSIT, AdmissionDate = DateTime.Parse("2022-02-22"), GPA = 1, Email = "roxanne.debil@gmail.com"
                },
                new Student()
                {
                    Id= 3,FirstName = "Charlene",LastName = "Arlante", Course = Course.BSCS, AdmissionDate = DateTime.Parse("2021-03-23"), GPA = 1.5, Email = "charlene.arlante@gmail.com"
                },
                new Student()
                {
                    Id= 4,FirstName = "Gabrielle Joanna Marie",LastName = "Belgar", Course = Course.BSCS, AdmissionDate = DateTime.Parse("2020-04-24"), GPA = 1.5, Email = "gabrielle.belgar@gmail.com"
                },
            };
        public IActionResult Index()
        {

            return View(StudentList);
        }

        public IActionResult ShowDetail(int id)
        {
            Student? student = StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)
                return View(student);

            return NotFound();
        }

    }
}