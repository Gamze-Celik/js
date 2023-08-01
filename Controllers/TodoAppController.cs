using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UygulamaHavuzum.Models;

namespace UygulamaHavuzum.Controllers
{
    public class TodoAppController : Controller
    {
        private readonly TodoContext _context;

        public TodoAppController(TodoContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.TodoListApp.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create([Bind("Id,TodoListItem,IsDone")] TodoList todoList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(todoList);
                _context.SaveChanges();

                return Json(todoList);
            }
            return NotFound();
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var todoList = _context.TodoListApp.Find(id);
            if (todoList == null)
            {
                return NotFound();
            }
            return View(todoList);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,TodoListItem, IsDone ")] TodoList todoList)
        {
            if (id != todoList.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(todoList);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TodoListExists(todoList.Id))
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
            return View(todoList);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var todoList = await _context.TodoListApp
                .FirstOrDefaultAsync(m => m.Id == id);

            if (todoList == null)
            {
                return NotFound();
            }

            _context.TodoListApp.Remove(todoList);
            await _context.SaveChangesAsync();

            return Json(new { success = true });
        }

        private bool TodoListExists(int id)
        {
            return _context.TodoListApp.Any(e => e.Id == id);
        }

    }
}


