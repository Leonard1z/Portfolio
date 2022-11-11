using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.DataAccess;

namespace Portfolio.Controllers;

public class HomeController : Controller
{
   private readonly AppDbContext _db;


        public HomeController(AppDbContext db)
        {
            _db = db;

        }

    public IActionResult Index()
    {
         IEnumerable<UserData> userDatas = _db.UserDatas;
        return View(userDatas);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
