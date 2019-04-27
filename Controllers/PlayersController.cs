using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLSVR_WEBAPI.Models;

namespace SQLSVR_WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly Rugby7Context _context;

        public PlayersController(Rugby7Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Players>>> GetPlayers()
        {
            return await _context.Players.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Players>> GetPlayers(long id)
        {   
            Players item = await _context.Players.FindAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

        [HttpPost]
        public async Task<ActionResult<Players>> PostPlayers(Players item)
        {
            _context.Players.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
              nameof(GetPlayers), 
              item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoItem(short id, Players item)
        {
            if (id != item.PlayerId)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return Content("Player has been updated");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(short id)
        {
            Players player = await _context.Players.FindAsync(id);

            if (player == null)
            {
                return NotFound();
            }

            _context.Players.Remove(player);
            await _context.SaveChangesAsync();

            return Content("Player has been removed");
        }
    }
}