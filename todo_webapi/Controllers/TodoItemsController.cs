using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api_example.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoItemsController : ControllerBase
    {
        private readonly Models.DBContext _context;
        public TodoItemsController(Models.DBContext ctx)
        {
            _context = ctx;
        }

        [HttpGet]
        public IActionResult Get(){
            return Ok(_context.TodoItems.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var item = _context.Find<Models.TodoItem>(id);
            if(item != null){
                return Ok(item);
            }else{
                return NotFound();
            }
        } 

        [HttpPost]
        public async Task<ActionResult<Models.TodoItem>> Post([FromBody] Models.TodoItem item){
            _context.TodoItems.Add(item);
            try{
                await _context.SaveChangesAsync();
            }catch(Exception ex){
                throw new Exception(ex.Message);
            }
            return Ok(item);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Models.TodoItem>> Put(long id,[FromBody] Models.TodoItem item){
            if(id != item.Id){
                return BadRequest();
            }
            _context.Entry<Models.TodoItem>(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            try{
                await _context.SaveChangesAsync();
            }catch(Exception ex){
                throw new Exception(ex.Message);
            }
            return Ok(item);
        }
    }
}