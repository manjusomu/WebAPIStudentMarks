using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStudentDatabaseAPI.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]

        public int StuId { get; set; }
        public string ? StuName { get; set; }
        public string ? SubName { get; set; }
        public int Mark { get; set; }
        
    }
}
