using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RazorSample.Interfaces;
using RazorSample.ViewModels;
using Microsoft.AspNetCore.Http;

namespace RazorSample.Pages
{
    public class OrderModel : PageModel
    {
        private readonly ILogger<OrderModel> _logger;

        private readonly IMenuIndexVmService _menuService;

        public OrderModel(IMenuIndexVmService menuService)
        {
            _menuService = menuService;
        }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string MenuGenre { get; set; }

        public MenuIndexVm MenuIndexVM { get; set; }

        public void OnGet(string searchString, int pageIndex = 4)
        {
            MenuIndexVM = _menuService.GetMenuListVm(SearchString, MenuGenre, pageIndex);
            ViewData["Session"] = HttpContext.Session.GetString("IDUser");
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("IDUser")))
            {
                Response.Redirect("http://localhost:5000/Login");
            }
        }
    }
}
