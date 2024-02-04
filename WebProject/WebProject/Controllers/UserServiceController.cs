using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using WebProject.Data;
using WebProject.Models;
using WebProject.Services;

namespace WebProject.Controllers
{
    public class UserServiceController : Controller
    {
        private readonly DBContext _context;
        private readonly IUserService _userService;

        public UserServiceController(DBContext context, IUserService userService)
        {
            _context = context;
            _userService = userService;
        }


        public async Task<IActionResult> Index()
        {
            var users = await _userService.GetAllUsers();
            return View(users);
        }

        public IActionResult Search()
        {
            return View();
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var users = await _userService.GetUserById((int)id);
            return View(users);
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Username,Age")] User user)
        {
            if (ModelState.IsValid)
            {
                await _userService.CreateUser(user);
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Search(string search)
        {               
            var users = _userService.SearchByName(search);
            return View(users);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.Users.FindAsync(id);
            if (users == null)
            {
                return NotFound();
            }
            return View(users);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Username,Age")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _userService.UpdateUser(user);
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id is not null)
            {
                var user = await _userService.GetUserById((int)id);
                if (user == null)
                {
                    return NotFound();
                }
                return View(user);
            }
            return View();
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string name)
        {
            await _userService.DeleteUser(name);
            return RedirectToAction(nameof(Index));
        }

        private bool UsersExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
