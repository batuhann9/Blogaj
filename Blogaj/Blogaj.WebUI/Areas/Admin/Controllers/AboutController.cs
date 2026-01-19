using Blogaj.WebUI.DTOs.AboutDtos;
using Blogaj.WebUI.Helpers;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;

namespace Blogaj.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class AboutController : Controller
    {
        private readonly HttpClient _client = HttpsClientInstance.CreateClient();

        public async Task<IActionResult> Index()
        {
            _client.BaseAddress = new Uri("https://localhost:7125/api/");

            var values = await _client.GetFromJsonAsync<List<ResultAboutDto>>("abouts");

            return View(values);
        }
    }
}
