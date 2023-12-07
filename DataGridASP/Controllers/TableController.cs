using DataGridASP.Models;
using DataGridASP.Models.Services.CRUD;
using Microsoft.AspNetCore.Mvc;

namespace DataGridASP.Controllers
{
    [Route("api/[controller]/[action]")]
    public class TableController : Controller
    {
        private readonly DataEntityService dataEntityService;

        public TableController(DataEntityService dataEntityService)
        {
            this.dataEntityService = dataEntityService;
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] Filter filter)
        {
            var count = await dataEntityService.CountAsync();
            return View(new PageData
            {
                TotalCount = count,
                Data = await dataEntityService.GetDataAsync(filter),
                CurrentPage = new Page(count, filter.PageSize, filter.Page),
            });
        }
    }
}
