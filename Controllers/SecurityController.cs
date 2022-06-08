using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ThanksCardAPI.Models;
namespace ThanksCardAPI.Controllers
{
    public class SecurityController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public SecurityController(ApplicationContext context)       
        {
            _context = context;
        }

        // GET: api/Security
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Security>>> GetSecurity()
        {
            return await _context.Security.ToListAsync();
        }

        // GET: api/Security/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Security>> GetSecurity(long id)
        {
            var Security = await _context.Security.FindAsync(id);

            if (Security == null)
            {
                return NotFound();
            }

            return Security;
        }

        // PUT: api/Securitys/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSecurity(long id, Security Security)
        {
            if (id != Security.id)
            {
                return BadRequest();
            }

            _context.Entry(Security).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SecurityExists(id))
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


        // POST: api/Security
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Security>> PostSecurity(Security Security)
        {
            _context.Security.Add(Security);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSecurity", new { id = Security.id }, Security);
        }

        // DELETE: api/Security/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSecurity(long id)
        {
            var Security = await _context.Security.FindAsync(id);
            if (Security == null)
            {
                return NotFound();
            }

            _context.Security.Remove(Security);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SecurityExists(long id)
        {
            return _context.Security.Any(e => e.id == id);
        }
    }
}