using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SchoolAppCoreMVC.Models
{
    public class Department 
    {
        [Key]
        public int DepartmentID { get; set; }
        public string? Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
    }
}
