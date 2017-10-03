using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Authentication.DbModel;
using Authentication.Models;
using Microsoft.AspNetCore.Mvc;

namespace Authentication.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private ApplicationDbContext applicationDbContext {get; set;}
        public ValuesController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        [HttpPost]
        public IActionResult Post([FromBody] User UserFromPost)
        {
            applicationDbContext.Users.Add(UserFromPost);
            applicationDbContext.SaveChanges();
            return Ok(UserFromPost);
        }
    }
}
