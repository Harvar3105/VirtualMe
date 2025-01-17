﻿using Core.DAL.EF;
using Core.Domain.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Controllers;

namespace WebApp.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "Admin")]
public class RefreshTokensController : BaseController
{
    private readonly AppDbContext _context;

    public RefreshTokensController(AppDbContext context)
    {
        _context = context;
    }

    // GET: Admin/RefreshTokens
    public async Task<IActionResult> Index()
    {
        var appDbContext = _context.RefreshTokens.Include(a => a.AppUser);
        return View(await appDbContext.ToListAsync());
    }

    // GET: Admin/RefreshTokens/Details/5
    public async Task<IActionResult> Details(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var appRefreshToken = await _context.RefreshTokens
            .Include(a => a.AppUser)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (appRefreshToken == null)
        {
            return NotFound();
        }

        return View(appRefreshToken);
    }

    // GET: Admin/RefreshTokens/Create
    public IActionResult Create()
    {
        ViewData["AppUserId"] = new SelectList(_context.Users, "Id", "FirstName");
        return View();
    }

    // POST: Admin/RefreshTokens/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("AppUserId,RefreshToken,ExpirationDT,PreviousRefreshToken,PreviousExpirationDT,Id")] AppRefreshToken appRefreshToken)
    {
        if (ModelState.IsValid)
        {
            appRefreshToken.Id = Guid.NewGuid();
            _context.Add(appRefreshToken);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        ViewData["AppUserId"] = new SelectList(_context.Users, "Id", "FirstName", appRefreshToken.AppUserId);
        return View(appRefreshToken);
    }

    // GET: Admin/RefreshTokens/Edit/5
    public async Task<IActionResult> Edit(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var appRefreshToken = await _context.RefreshTokens.FindAsync(id);
        if (appRefreshToken == null)
        {
            return NotFound();
        }
        ViewData["AppUserId"] = new SelectList(_context.Users, "Id", "FirstName", appRefreshToken.AppUserId);
        return View(appRefreshToken);
    }

    // POST: Admin/RefreshTokens/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Guid id, [Bind("AppUserId,RefreshToken,ExpirationDT,PreviousRefreshToken,PreviousExpirationDT,Id")] AppRefreshToken appRefreshToken)
    {
        if (id != appRefreshToken.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(appRefreshToken);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppRefreshTokenExists(appRefreshToken.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        ViewData["AppUserId"] = new SelectList(_context.Users, "Id", "FirstName", appRefreshToken.AppUserId);
        return View(appRefreshToken);
    }

    // GET: Admin/RefreshTokens/Delete/5
    public async Task<IActionResult> Delete(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var appRefreshToken = await _context.RefreshTokens
            .Include(a => a.AppUser)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (appRefreshToken == null)
        {
            return NotFound();
        }

        return View(appRefreshToken);
    }

    // POST: Admin/RefreshTokens/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        var appRefreshToken = await _context.RefreshTokens.FindAsync(id);
        if (appRefreshToken != null)
        {
            _context.RefreshTokens.Remove(appRefreshToken);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool AppRefreshTokenExists(Guid id)
    {
        return _context.RefreshTokens.Any(e => e.Id == id);
    }
}
