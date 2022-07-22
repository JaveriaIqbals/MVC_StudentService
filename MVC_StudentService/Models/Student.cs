using System.ComponentModel.DataAnnotations;

namespace StudentMgtSys_MVC_CRUD_Service.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string StudentName { get; set; }

        [Required]
        public string Address { get; set; } 

        public int Age { get; set; }
        List<Assignment> AssignmentList { get; set; } = new List<Assignment>();
    }
}
