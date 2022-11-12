using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.DataAccess;

namespace Portfolio.Controllers;

public class HomeController : Controller
{
//    private readonly AppDbContext _db;


//         public HomeController(AppDbContext db)
//         {
//             _db = db;

//         }
            UserData userData = new UserData();
    public IActionResult Index()
    {
            userData.Name = "Leonard";
            userData.LastName = "Zaberxha";
            userData.Work = "Backend Developer";
            userData.Description = "I am passionate about my work.";
            userData.TelephoneNumber = "044-475-749";
            userData.Email = "leonardzab0@gmail.com";
            userData.AboutMeDescription="Experience in building websites,working with teams. Skilled in C#, Asp .Net MVC, Web Api,NodeJs, Web Design";

            ViewBag.UserEmail = userData.Email;
            ViewBag.AboutMeDescription = userData.AboutMeDescription;
            ViewBag.UserTelephoneNumber=userData.TelephoneNumber;
            ViewBag.UserDescription=userData.Description;
            ViewBag.UserWork=userData.Work;
            ViewBag.UserName = userData.Name;
            ViewBag.UserLastName = userData.LastName;
        //  IEnumerable<UserData> userDatas = _db.UserDatas;
        return View();
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
