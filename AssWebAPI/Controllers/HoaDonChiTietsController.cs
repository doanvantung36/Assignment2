using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AssAPI.AppDbContext;
using AssAPI.Model;

namespace AssWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoaDonChiTietsController : ControllerBase
    {
        private readonly AppDbContexts _context;

        public HoaDonChiTietsController(AppDbContexts context)
        {
            _context = context;
        }

        // GET: api/HoaDonChiTiets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HoaDonChiTiet>>> GetHoaDonChiTiets()
        {
            return await _context.HoaDonChiTiets.ToListAsync();
        }

        // GET: api/HoaDonChiTiets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HoaDonChiTiet>> GetHoaDonChiTiet(int id)
        {
            var hoaDonChiTiet = await _context.HoaDonChiTiets.FindAsync(id);

            if (hoaDonChiTiet == null)
            {
                return NotFound();
            }

            return hoaDonChiTiet;
        }

        // PUT: api/HoaDonChiTiets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHoaDonChiTiet(int id, HoaDonChiTiet hoaDonChiTiet)
        {
            if (id != hoaDonChiTiet.MaHoaDon)
            {
                return BadRequest();
            }

            _context.Entry(hoaDonChiTiet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HoaDonChiTietExists(id))
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

        // POST: api/HoaDonChiTiets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HoaDonChiTiet>> PostHoaDonChiTiet(HoaDonChiTiet hoaDonChiTiet)
        {
            _context.HoaDonChiTiets.Add(hoaDonChiTiet);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HoaDonChiTietExists(hoaDonChiTiet.MaHoaDon))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHoaDonChiTiet", new { id = hoaDonChiTiet.MaHoaDon }, hoaDonChiTiet);
        }

        // DELETE: api/HoaDonChiTiets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHoaDonChiTiet(int id)
        {
            var hoaDonChiTiet = await _context.HoaDonChiTiets.FindAsync(id);
            if (hoaDonChiTiet == null)
            {
                return NotFound();
            }

            _context.HoaDonChiTiets.Remove(hoaDonChiTiet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HoaDonChiTietExists(int id)
        {
            return _context.HoaDonChiTiets.Any(e => e.MaHoaDon == id);
        }
    }
}
