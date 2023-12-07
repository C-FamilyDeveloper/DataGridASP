using DataGridASP.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DataGridASP.Views.Table
{
    public class IndexModel : PageModel
    {
        public PageData LogPage { get; set; }
        public void OnGet(PageData logPage)
        {
            LogPage = logPage;
        }
    }
}
