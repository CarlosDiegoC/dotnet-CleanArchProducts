using System.Threading.Tasks;
using CleanArchProducts.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchProducts.Mvc.Controllers
{
    [Route("[controller]")]
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetCategories();
            return View(categories);
        }
    }
}