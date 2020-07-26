using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KindercarBack.Models;

namespace KindercarBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KindergartenController : ControllerBase
    {
        private readonly MyContext _context;

        public KindergartenController(MyContext context)
        {
            _context = context;
        }

        // GET: api/Kindergarten
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Kindergarten>>> GetKindergartens()
        {
            return await _context.Kindergartens.ToListAsync();
        }

        // GET: api/Kindergarten/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Kindergarten>> GetKindergarten(int id)
        {
            var kindergarten = await _context.Kindergartens.FindAsync(id);

            if (kindergarten == null)
            {
                return NotFound();
            }

            return kindergarten;
        }

        // PUT: api/Kindergarten/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKindergarten(int id, Kindergarten kindergarten)
        {
            if (id != kindergarten.KindergartenId)
            {
                return BadRequest();
            }

            _context.Entry(kindergarten).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KindergartenExists(id))
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

        // POST: api/Kindergarten
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Kindergarten>> PostKindergarten(Kindergarten kindergarten)
        {
            _context.Kindergartens.Add(kindergarten);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKindergarten", new { id = kindergarten.KindergartenId }, kindergarten);
        }

        // DELETE: api/Kindergarten/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Kindergarten>> DeleteKindergarten(int id)
        {
            var kindergarten = await _context.Kindergartens.FindAsync(id);
            if (kindergarten == null)
            {
                return NotFound();
            }

            _context.Kindergartens.Remove(kindergarten);
            await _context.SaveChangesAsync();

            return kindergarten;
        }

        private bool KindergartenExists(int id)
        {
            return _context.Kindergartens.Any(e => e.KindergartenId == id);
        }
    }
}
