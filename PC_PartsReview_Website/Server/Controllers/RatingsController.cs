using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PC_PartsReview_Website.Server.Data;
using PC_PartsReview_Website.Server.IRepository;
using PC_PartsReview_Website.Server.Repository;
using PC_PartsReview_Website.Shared.Domain;

namespace PC_PartsReview_Website.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork; 

        public RatingsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Ratings
        [HttpGet]
        public async Task<IActionResult> GetRatings()
        {
            var ratings = await _unitOfWork.Ratings.GetAll();
            return Ok(ratings);
        }

        // GET: api/Ratings/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<Rating>> GetRating(int id)
        public async Task<IActionResult> GetRating(int id)
        {
            var rating = await _unitOfWork.Ratings.Get(q => q.Id == id);
            if (rating == null)
                {
                    return NotFound();
                }
            return Ok(rating);
        }

        // PUT: api/Ratings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRating(int id, Rating rating)
        {
            if (id != rating.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Ratings.Update(rating);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await RatingExists(id))
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

        // POST: api/Ratings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Rating>> PostRating(Rating rating)
        {
            await _unitOfWork.Ratings.Insert(rating);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetRating", new { id = rating.Id }, rating);
        }

        // DELETE: api/Ratings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRating(int id)
        {
            var rating = await _unitOfWork.Ratings.Get(q => q.Id == id);
            if (rating == null)
            {
                return NotFound();
            }
            await _unitOfWork.Ratings.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> RatingExists(int id)
        {
            var rating = await _unitOfWork.Ratings.Get(q => q.Id == id);
            return rating == null;
        }

       
    }
}
