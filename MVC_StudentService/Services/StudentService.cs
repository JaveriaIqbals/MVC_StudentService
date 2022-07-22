using MVC_StudentService.Data;
using StudentMgtSys_MVC_CRUD_Service.Models;

namespace MVC_StudentService.Services
{
    public class StudentService : IStudentService
    {
        ClassDbContext _db;
        public StudentService(ClassDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            var list = _db.students.ToList();
            return list;
        }

        public void DeleteStudent(int id)
        {
            Student std = _db.students.FirstOrDefault(x => x.Id == id);
            if(std != null)
            {
                _db.students.Remove(std);
                _db.SaveChanges();
            }
        }
    }
}
