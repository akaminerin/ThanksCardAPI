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
    [Route("api/[controller]")]
    [ApiController]
    public class SecuritysController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public SecuritysController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Securitys
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Security>>> GetSecuritys()
        {
            return await _context.Security.ToListAsync();
        }

        // GET: api/Securitys/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Security>> GetSecurity(long id)
        {
            var security = await _context.Security.FindAsync(id);

            if (security == null)
            {
                return NotFound();
            }

            return security;
        }

        // PUT: api/Securitys/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSecurity(long id, Security security)
        {
            if (id != security.Id)
            {
                return BadRequest();
            }

            _context.Entry(security).State = EntityState.Modified;

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

        // POST: api/Securitys
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Security>> PostSecurity(Security security)
        {

            _context.Security.Add(security);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSecurity", new { id = security.Id }, security);
        }

        // DELETE: api/Securitys/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSecurity(long id)
        {
            var security = await _context.Security.FindAsync(id);
            if (security == null)
            {
                return NotFound();
            }

            _context.Security.Remove(security);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SecurityExists(long id)
        {
            return _context.Security.Any(e => e.Id == id);
        }
    }
}
