using DemoMVC.Models;
using DemoMVC.Views.Demo;

namespace DemoMVC.Controllers
{
    class DemoController
    {
        public void Index()
        {
            Student sv = new Student
            {
                FullName = "Trần Trọng Linh",
                StudentId = "2221050270"
            };

            Index.Render(sv);
        }
    }
}