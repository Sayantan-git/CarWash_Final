using CarWashApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWashApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WashersController : ControllerBase
    {
        private readonly CarWashContext _context;

        public WashersController(CarWashContext context)
        {
            _context = context;
        }

        // GET: api/Washers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Washer>>> GetWasher()
        {
            if (_context.Washers == null)
            {
                return NotFound();
            }
            return await _context.Washers.ToListAsync();
        }

        // GET: api/Washers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Washer>> GetWasher(int id)
        {
            if (_context.Washers == null)
            {
                return NotFound();
            }
            var washer = await _context.Washers.FindAsync(id);

            if (washer == null)
            {
                return NotFound();
            }

            return washer;
        }

        // PUT: api/Washers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdmin(int id, Washer washer)
        {
            if (id != washer.Id)
            {
                return BadRequest();
            }

            _context.Entry(washer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WasherExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Washers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Washer>> PostWasher(Washer washer)
        {
            if (_context.Washers == null)
            {
                return Problem("Entity set 'CropDealContext.Washers'  is null.");
            }
            _context.Washers.Add(washer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWasher", new { id = washer.Id }, washer);
        }

        // DELETE: api/Admins/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWasher(int id)
        {
            if (_context.Washers == null)
            {
                return NotFound();
            }
            var washer = await _context.Washers.FindAsync(id);
            if (washer == null)
            {
                return NotFound();
            }

            _context.Washers.Remove(washer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WasherExists(int id)
        {
            return (_context.Washers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}