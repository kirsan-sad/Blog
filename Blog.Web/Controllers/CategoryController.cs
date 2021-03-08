using Blog.Domain.Interfaces;
using Blog.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _repo;
        public CategoryController(ICategoryRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var result = _repo.AllCategories();

            return View(result);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category model)
        {
            IActionResult result = null;

            if (_repo.TryCreate(model))
                return Ok(200);
            else
                return NotFound(404);
        }
    }
}
