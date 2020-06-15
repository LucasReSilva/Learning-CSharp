using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebAPI.Controllers{
    [ApiController]
    [Route("[controller]")]
    public class RandomNumberController : ControllerBase{
        [HttpGet]
        public int Get(){
            return new Random().Next(100);
        }
    }
}
