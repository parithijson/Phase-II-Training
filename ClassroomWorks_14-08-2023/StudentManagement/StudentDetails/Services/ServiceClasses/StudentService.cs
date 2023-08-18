using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentDetails.Exceptions;
using StudentDetails.Models;
using StudentDetails.Services.Interfaces;


namespace StudentDetails.Services.ServiceClasses
{
    public class StudentService : IStudent
    {
        //Context object
        public StudentContext? _StudentContext;

        public StudentService(StudentContext? studentContext)
        {
            _StudentContext = studentContext;
        }

        //End-Points method
        public async Task<List<Student>> AddStudent(Student student)
        {
         
         
            _StudentContext.Students.Add(student);
            await _StudentContext.SaveChangesAsync();
            return await _StudentContext.Students.ToListAsync();
           

        }

      
        public async Task<List<Student>> GetAllStudents()
        {
            var Reulst = await _StudentContext.Students.ToListAsync();
            return Reulst;
        }

       
        public async Task<Student> GetStudentById(int id)
        {
            var result = await _StudentContext.Students.FirstAsync(x => x.Rollno == id);
            if(result == null)
            {
                throw new Exception(StudentDetailsExceptions.excetpionsmessages[0]);
            }
            else
            {
                return result;
            }
        }



        //UpdateStudentById

        public async Task<Student> UpdateStudent(int id, Student student)
        {
            Student? rstudent;
            rstudent = await _StudentContext.Students.FindAsync(id);
            if(rstudent == null)
            {
                throw new Exception(StudentDetailsExceptions.excetpionsmessages[0]);

            }
            else
            {
                rstudent.StudentName = student.StudentName;
                rstudent.Address = student.Address;
                rstudent.PhoneNumber = student.PhoneNumber;
                await _StudentContext.SaveChangesAsync();

                return await _StudentContext.Students.FindAsync(id);

            }
        }

        public async Task<List<Student>> DeleteStudent(int rollno)
        {
            var rstudent = await _StudentContext.Students.FindAsync(rollno);
            if (rstudent == null)
            {
                throw new Exception(StudentDetailsExceptions.excetpionsmessages[0]);

            }
            else
            {
                _StudentContext.Students.Remove(rstudent);
                await _StudentContext.SaveChangesAsync();

                return await _StudentContext.Students.ToListAsync();

            }
        }

    
    }
}
