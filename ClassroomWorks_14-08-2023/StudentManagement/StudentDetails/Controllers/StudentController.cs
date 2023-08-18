using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentDetails.Models;
using StudentDetails.Services.Interfaces;

namespace StudentDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public IStudent _Student;


        public StudentController(IStudent student)
        {
            _Student = student;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAllStudents()
        {
            var Students = await _Student.GetAllStudents();
            if (Students == null)
            {
                return NotFound();
            }
            return Ok(Students);
        }

        [HttpGet("{id}")]
       
        public async Task<ActionResult<Student>> GetStudentById(int id)
        {
            Student student;
            try
            {
                student = await _Student.GetStudentById(id);

            }catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
            return Ok(student);
        }
        [HttpPost]
        public async Task<ActionResult<List<Student>>> AddStudent(Student student)
        {
            var Students = await _Student.AddStudent(student);
            return Ok(Students);


        }


        //UpdateStudentById

        [HttpPut]
        public async Task<ActionResult<Student>> UpdateStudent(int rollno,  Student student)
        {
          
            try
            {
                var ustudent = await _Student.UpdateStudent(rollno, student);
                return Ok(ustudent);

            }catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
            
        }

        [HttpDelete]
        public async Task<ActionResult<List<Student>>> DeleteStudent(int rollno)
        {

            try
            {
                var student = await _Student.DeleteStudent(rollno);
                return Ok(student);

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }

    }
}
