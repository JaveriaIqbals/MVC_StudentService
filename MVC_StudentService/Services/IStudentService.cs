using StudentMgtSys_MVC_CRUD_Service.Models;

namespace MVC_StudentService.Services
{
    public interface IStudentService
    {
        public IEnumerable<Student> GetAllStudents();
        public void DeleteStudent(int id);

    }
}
