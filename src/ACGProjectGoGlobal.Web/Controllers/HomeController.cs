using System;
using System.Threading.Tasks;
using Abp.Runtime.Validation;
using ACGProjectGoGlobal.Web.Services;
using ACGProjectGoGlobal.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ACGProjectGoGlobal.Web.Controllers
{
    public class HomeController : ACGProjectGoGlobalControllerBase
    {
        private readonly ICosmosDbService _cosmosDbService;
        public HomeController(ICosmosDbService cosmosDbService)
        {
            _cosmosDbService = cosmosDbService;
        }

        public ActionResult Index()
        {
            return View(new UserViewModel());
        }

        [HttpPost]
        [DisableValidation]
        public async Task<RedirectToActionResult> Index(UserViewModel model)
        {
            // Store the data in session
            //var key = Guid.NewGuid().ToString(); 
            //var str = JsonConvert.SerializeObject(model);
            //HttpContext.Session.SetString(key, str);

            //// Use this to retrieve the value if you want
            //var storedValue = HttpContext.Session.GetString(key);
            //var obj = JsonConvert.DeserializeObject<UserViewModel>(str);

            await _cosmosDbService.AddItemAsync(model.GetUser());
            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            return View();
        }
    }
}