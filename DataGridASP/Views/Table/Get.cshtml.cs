using DataGridASP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

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
