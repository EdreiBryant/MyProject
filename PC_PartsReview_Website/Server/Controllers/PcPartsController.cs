using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PC_PartsReview_Website.Server.Data;
using PC_PartsReview_Website.Shared.Domain;

namespace PC_PartsReview_Website.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PcPartsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PcPartsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/PcParts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PcPart>>> GetPcParts()
        {
          if (_context.PcParts == null)
          {
              return NotFound();
          }
            return await _context.PcParts.ToListAsync();
        }

        // GET: api/PcParts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PcPart>> GetPcPart(int id)
        {
          if (_context.PcParts == null)
          {
              return NotFound();
          }
            var pcPart = await _context.PcParts.FindAsync(id);

            if (pcPart == null)
            {
                return NotFound();
            }

            return pcPart;
        }

        // PUT: api/PcParts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPcPart(int id, PcPart pcPart)
        {
            if (id != pcPart.Id)
            {
                return BadRequest();
            }

            _context.Entry(pcPart).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PcPartExists(id))
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

        // POST: api/PcParts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PcPart>> PostPcPart(PcPart pcPart)
        {
          if (_context.PcParts == null)
          {
              return Problem("Entity set 'ApplicationDbContext.PcParts'  is null.");
          }
            _context.PcParts.Add(pcPart);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPcPart", new { id = pcPart.Id }, pcPart);
        }

        // DELETE: api/PcParts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePcPart(int id)
        {
            if (_context.PcParts == null)
            {
                return NotFound();
            }
            var pcPart = await _context.PcParts.FindAsync(id);
            if (pcPart == null)
            {
                return NotFound();
            }

            _context.PcParts.Remove(pcPart);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PcPartExists(int id)
        {
            return (_context.PcParts?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
