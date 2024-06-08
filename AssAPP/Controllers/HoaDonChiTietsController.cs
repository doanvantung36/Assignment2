using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AssAPI.AppDbContext;
using AssAPI.Model;

namespace AssAPP.Controllers
{
    public class HoaDonChiTietsController : Controller
    {
        

        public HoaDonChiTietsController()
        {
            
        }

        //// GET: HoaDonChiTiets
        //public async Task<IActionResult> Index()
        //{
        //    var appDbContexts = _context.HoaDonChiTiets.Include(h => h.HoaDon).Include(h => h.SanPham);
        //    return View(await appDbContexts.ToListAsync());
        //}

        //// GET: HoaDonChiTiets/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var hoaDonChiTiet = await _context.HoaDonChiTiets
        //        .Include(h => h.HoaDon)
        //        .Include(h => h.SanPham)
        //        .FirstOrDefaultAsync(m => m.MaHoaDon == id);
        //    if (hoaDonChiTiet == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(hoaDonChiTiet);
        //}

        //// GET: HoaDonChiTiets/Create
        //public IActionResult Create()
        //{
        //    ViewData["MaHoaDon"] = new SelectList(_context.HoaDons, "MaHoaDon", "IdKhachHang");
        //    ViewData["MaSanPham"] = new SelectList(_context.SanPham, "MaSanPham", "HinhAnh");
        //    return View();
        //}

        //// POST: HoaDonChiTiets/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("MaHoaDon,MaSanPham,SoLuong")] HoaDonChiTiet hoaDonChiTiet)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(hoaDonChiTiet);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["MaHoaDon"] = new SelectList(_context.HoaDons, "MaHoaDon", "IdKhachHang", hoaDonChiTiet.MaHoaDon);
        //    ViewData["MaSanPham"] = new SelectList(_context.SanPham, "MaSanPham", "HinhAnh", hoaDonChiTiet.MaSanPham);
        //    return View(hoaDonChiTiet);
        //}

        //// GET: HoaDonChiTiets/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var hoaDonChiTiet = await _context.HoaDonChiTiets.FindAsync(id);
        //    if (hoaDonChiTiet == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["MaHoaDon"] = new SelectList(_context.HoaDons, "MaHoaDon", "IdKhachHang", hoaDonChiTiet.MaHoaDon);
        //    ViewData["MaSanPham"] = new SelectList(_context.SanPham, "MaSanPham", "HinhAnh", hoaDonChiTiet.MaSanPham);
        //    return View(hoaDonChiTiet);
        //}

        //// POST: HoaDonChiTiets/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("MaHoaDon,MaSanPham,SoLuong")] HoaDonChiTiet hoaDonChiTiet)
        //{
        //    if (id != hoaDonChiTiet.MaHoaDon)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(hoaDonChiTiet);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!HoaDonChiTietExists(hoaDonChiTiet.MaHoaDon))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["MaHoaDon"] = new SelectList(_context.HoaDons, "MaHoaDon", "IdKhachHang", hoaDonChiTiet.MaHoaDon);
        //    ViewData["MaSanPham"] = new SelectList(_context.SanPham, "MaSanPham", "HinhAnh", hoaDonChiTiet.MaSanPham);
        //    return View(hoaDonChiTiet);
        //}

        //// GET: HoaDonChiTiets/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var hoaDonChiTiet = await _context.HoaDonChiTiets
        //        .Include(h => h.HoaDon)
        //        .Include(h => h.SanPham)
        //        .FirstOrDefaultAsync(m => m.MaHoaDon == id);
        //    if (hoaDonChiTiet == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(hoaDonChiTiet);
        //}

        //// POST: HoaDonChiTiets/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var hoaDonChiTiet = await _context.HoaDonChiTiets.FindAsync(id);
        //    if (hoaDonChiTiet != null)
        //    {
        //        _context.HoaDonChiTiets.Remove(hoaDonChiTiet);
        //    }

        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool HoaDonChiTietExists(int id)
        //{
        //    return _context.HoaDonChiTiets.Any(e => e.MaHoaDon == id);
        //}
    }
}
