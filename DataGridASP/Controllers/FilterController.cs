using DataGridASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataGridASP.Controllers
{
    [Route("api/[controller]/[action]")]
    public class FilterController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return View(new Filter());
        }
    }
}
