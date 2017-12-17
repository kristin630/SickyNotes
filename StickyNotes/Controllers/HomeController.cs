using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StickyNotes.Models;
using System.Net.Http;

namespace StickyNotes.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            InputModel model = new InputModel();
            InputModel help = model;
            using (var client = new HttpClient())
            {
                var uri = new Uri("https://www.googleapis.com/customsearch/v1?key=AIzaSyAC-rl-YtiC534wrSUVVDlwQGq3k9BDpZs&amp;cx=017576662512468239146:omuauf_lfve&amp;q=homework");
                // HTTP GET
                var ResponseTask = client.GetAsync(uri);
                ResponseTask.Wait();

                var result = ResponseTask.Result;
                Console.WriteLine(result.StatusCode);
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();

                    help.Response = readTask.Result;
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");

                }

            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(InputModel model)
        {
            string req = model.Task;
            return View(model);
        }
    

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
