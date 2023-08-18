using StudentDetailsDF.Models;

namespace StudentDetailsDF.Services.Interfaces
{
    public interface IStudent
    {
        Task<List<Student>> GetAllStudents();
        Task <Student> GetStudentById(int id);
        Task <List<Student>> AddStudent(Student student);
        Task <Student> UpdateStudent(int id,Student student);
        Task <List<Student>> DeleteStudent(int rollno);
    }
}
