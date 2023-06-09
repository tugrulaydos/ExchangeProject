using Exchange.Service.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Exchange.Web.Controllers
{
    public class HomePageController : Controller
    {
        private readonly ICurrencyService _currencyService;        

        public HomePageController(ICurrencyService currencyService)
        {
            _currencyService = currencyService;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _currencyService.GetCurrenciesWithDate();

            return View(data);
            
        }
    }
}
