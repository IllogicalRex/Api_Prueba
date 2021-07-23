using Contracts.DTO;
using Microsoft.AspNetCore.Mvc;
using Services.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiTraining.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController: ControllerBase
    {
        PersonDAO person = new PersonDAO();
        // GET api/values
        [HttpGet("allstudents")]
        public ActionResult<List<PersonDTO>> GetAllStudents()
        {
            return person.GetAllPerson(1);
        }
    }
}
