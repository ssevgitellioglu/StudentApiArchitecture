
using Microsoft.AspNetCore.Mvc;
using StıdentApi.Business;
using StudentApi.Entities;

namespace StudentApi.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private IStudentService _studentService;
        public StudentsController(IStudentService studentService)
        {
            _studentService =studentService;

        }
        [HttpGet]
        public IActionResult Get()
          {
            var students = _studentService.GetAllStudents();
            return Ok(students);

        }
        [HttpGet("{id}")]
        [Route("[action]/{id}")] //students/get
        public IActionResult Get(int id)
        {
            var student = _studentService.GetStudentsById(id);
            if(student == null)
            {
                return Ok(student);
            }
            return NotFound() ;

        }
        [HttpPost]
        public IActionResult Post([FromBody] Student student)
        {
            if (ModelState.IsValid)
            {
                var addedStudent = _studentService.AddStudent(student);
                return CreatedAtAction("Get", new { id = addedStudent.Id }, addedStudent);
            }
            return BadRequest(ModelState); //400+validation errors
        }
        [HttpPut]
        public IActionResult Put([FromBody] Student student)
        {
            if (_studentService.UpdateStudent(student) != null)
            {
                return Ok(_studentService.UpdateStudent(student)); //200 + data
            }

            return NotFound() ;
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_studentService.GetStudentsById(id) != null)
            {
                _studentService.DeleteStudent(id); //200
                return Ok();
            }

            return NotFound(); //404 döndürecek

        }

    }
  }
