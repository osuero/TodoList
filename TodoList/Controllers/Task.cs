using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Controllers
{
    //this line especify te routing name
    [Route("api/[controller]")]
    //this line let you know this is an api controller 
    //actually it already know its an api
    [ApiController]
    public class Task:Controller
    {
        [HttpGet()]
        public ActionResult GetTask()
        {

            return null;
        }
    }
}
