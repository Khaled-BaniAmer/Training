using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SNKhaledsController : ControllerBase
    {
        private readonly DataContext? _dbContext;
        public SNKhaledsController(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employees>>> getEmployees(){
            var result = await _dbContext.Employees.ToListAsync();
            return result;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employees>> getEmployee(int? id){
            var result = await _dbContext.Employees.Where(o => o.Id == id).FirstOrDefaultAsync();
            if(result == null)
                return NotFound();
            return result;
        }
    }
}