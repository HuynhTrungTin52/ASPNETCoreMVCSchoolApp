using FastReport.Data;
using FastReport.Web;
using Microsoft.AspNetCore.Mvc;
using SchoolAppCoreMVC.Models;

namespace SchoolAppCoreMVC.Controllers
{
    public class ReportsController : Controller
    {
        private readonly SchoolContext _context;
        private readonly IWebHostEnvironment _env;

        public ReportsController(SchoolContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            var webReport = new WebReport();
            FastReport.Utils.RegisteredObjects.AddConnection(typeof(FastReport.Data.MsSqlDataConnection));
            var reportPath = Path.Combine(_env.ContentRootPath, "Reports", "StudentGrades.frx");
            webReport.Report.Load(reportPath);

            var students = _context.Students.ToList();

            webReport.Report.RegisterData(students, "Students");
            var dataSource = webReport.Report.GetDataSource("Students");
            if (dataSource != null)
            {
                dataSource.Enabled = true;
            }

            return View(webReport);
        }
    }
}