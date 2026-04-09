using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;


namespace SchoolAppCoreMVC.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public decimal Grade { get; set; }

        public int CourseID { get; set; }
        public int StudentID { get; set; }

        [ForeignKey("CourseID")]
        public virtual Course? Course { get; set; }

        [ForeignKey("StudentID")]
        public virtual Student? Student { get; set; }
    }
}
