using CRUDWebApiWithSwagger.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApiWithSwagger.Models;

namespace WebApiWithSwagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentContext _context;
        public StudentController(StudentContext context)
        {
            this._context = context;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<List<StudentDetails>> Get()
        {
            var result = _context.StudentDetails.ToList();
            return new List<StudentDetails>(result);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<StudentDetails> Get(int id)
        {
            var result = _context.StudentDetails.Where(x => x.StudentId == id).FirstOrDefault();
            return result;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] StudentDetails studentDetails)
        {
            _context.StudentDetails.Add(studentDetails);
            _context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut]
        public void Put([FromBody] StudentDetails studentDetails)
        {
            _context.StudentDetails.Update(studentDetails);
            _context.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var itemToDelete = _context.StudentDetails.Where(x => x.StudentId == id).FirstOrDefault();
            _context.StudentDetails.Remove(itemToDelete);
            _context.SaveChanges();
        }
    }
}