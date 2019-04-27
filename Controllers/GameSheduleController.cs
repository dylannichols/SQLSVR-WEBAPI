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
    public class GameScheduleController : ControllerBase
    {
        private readonly Rugby7Context _context;

        public GameScheduleController(Rugby7Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GameShedule>>> GetGameSchedule()
        {
            return await _context.GameShedule.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GameShedule>> GetGameSchedule(long gameId)
        {   
            GameShedule item = await _context.GameShedule.FindAsync(gameId);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

        [HttpPost]
        public async Task<ActionResult<GameShedule>> PostTodoItem(GameShedule item)
        {
            _context.GameShedule.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
              nameof(GetGameSchedule), 
              item);
        }
    }
}