using System.ComponentModel.DataAnnotations;
namespace StudentMgtSys_MVC_CRUD_Service.Models
{
    public class Assignment
    {
        [Key]
        public int Id { get; set; } 
        
        [Required]
        public string AssignmentName { get; set; }
        public double? AssignmentGrade { get; set; }
        public bool? IsComplete { get; set; }

    }
}
