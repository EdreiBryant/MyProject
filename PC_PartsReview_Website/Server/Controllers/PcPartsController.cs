using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using PC_PartsReview_Website.Server.Data;
using PC_PartsReview_Website.Server.IRepository;
using PC_PartsReview_Website.Shared.Domain;

namespace PC_PartsReview_Website.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PcPartsController : ControllerBase
    {
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;

        //public PcPartsController(ApplicationDbContext context)
        public PcPartsController(IUnitOfWork unitOfWork)

        {
            //_context = context;
            _unitOfWork = unitOfWork;
        }

        // GET: api/PcParts
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<PcPart>>> GetPcParts()
        public async Task<IActionResult> GetPcParts()

        {
            //  if (_context.PcParts == null)
            //{
            //    return NotFound();
            //}
            //  return await _context.PcParts.ToListAsync();
            var pcparts = await _unitOfWork.PcParts.GetAll();
            return Ok(pcparts);
        }

        // GET: api/PcParts/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<PcPart>> GetPcPart(int id)
        public async Task<IActionResult> GetPcPart(int id)

        {
          //  if (_context.PcParts == null)
          //{
          //    return NotFound();
          //}
          //  var pcPart = await _context.PcParts.FindAsync(id);

          //  if (pcPart == null)
          //  {
          //      return NotFound();
          //  }

          //  return pcPart;
          var pcpart = await _unitOfWork.PcParts.Get(q => q.Id == id);
          if (pcpart == null) 
            {
                return NotFound();
            }
          return Ok(pcpart);
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

            //_context.Entry(pcPart).State = EntityState.Modified;
            _unitOfWork.PcParts.Update(pcPart);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!PcPartExists(id))
                //{
                //    return NotFound();
                //}
                //else
                //{
                //    throw;
                //}
                if (!await PcPartExists(id)) 
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
          //if (_context.PcParts == null)
          //{
          //    return Problem("Entity set 'ApplicationDbContext.PcParts'  is null.");
          //}
          //  _context.PcParts.Add(pcPart);
          //  await _context.SaveChangesAsync();
            await _unitOfWork.PcParts.Insert(pcPart);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetPcPart", new { id = pcPart.Id }, pcPart);
        }

        // DELETE: api/PcParts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePcPart(int id)
        {
            //if (_context.PcParts == null)
            //{
            //    return NotFound();
            //}
            //var pcPart = await _context.PcParts.FindAsync(id);
            var pcpart = await _unitOfWork.PcParts.Get(q => q.Id == id);
            if (pcpart == null)
            {
                return NotFound();
            }

            //_context.PcParts.Remove(pcPart);
            //await _context.SaveChangesAsync();

            await _unitOfWork.PcParts.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool PcPartExists(int id)
        private async Task<bool> PcPartExists(int id)
        {
            //return (_context.PcParts?.Any(e => e.Id == id)).GetValueOrDefault();
            var pcpart = await _unitOfWork.PcParts.Get(q => q.Id == id);
            return pcpart != null;
        }
    }
}
