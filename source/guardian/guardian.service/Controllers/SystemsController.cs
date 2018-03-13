using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using guardian.service.Models;

namespace guardian.service.Controllers
{
    [Produces("application/json")]
    [Route("api/Systems")]
    public class SystemsController : Controller
    {
        private readonly GuardianContext _context;

        public SystemsController(GuardianContext context)
        {
            _context = context;
        }

        // GET: api/Systems
        [HttpGet]
        public IEnumerable<guardian.service.Models.System> GetSystems()
        {
            return _context.Systems;
        }

        // GET: api/Systems/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSystem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var system = await _context.Systems.SingleOrDefaultAsync(m => m.Id == id);

            if (system == null)
            {
                return NotFound();
            }

            return Ok(system);
        }

        // PUT: api/Systems/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSystem([FromRoute] int id, [FromBody] guardian.service.Models.System system)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != system.Id)
            {
                return BadRequest();
            }

            _context.Entry(system).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SystemExists(id))
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

        // POST: api/Systems
        [HttpPost]
        public async Task<IActionResult> PostSystem([FromBody] guardian.service.Models.System system)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Systems.Add(system);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSystem", new { id = system.Id }, system);
        }

        // DELETE: api/Systems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSystem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var system = await _context.Systems.SingleOrDefaultAsync(m => m.Id == id);
            if (system == null)
            {
                return NotFound();
            }

            _context.Systems.Remove(system);
            await _context.SaveChangesAsync();

            return Ok(system);
        }

        private bool SystemExists(int id)
        {
            return _context.Systems.Any(e => e.Id == id);
        }
    }
}