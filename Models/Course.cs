using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace SchoolAppCoreMVC.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        [Required]
        public required string Title { get; set; }
        [Required]
        public required int credits { get; set; }

        public int DepartmentID { get; set; }

        [ForeignKey("DepartmentID")]
        public virtual Department? Department { get; set; }

    }
}
