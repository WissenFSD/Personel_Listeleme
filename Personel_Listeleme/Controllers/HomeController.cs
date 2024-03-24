using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Personel_Listeleme.Models;
using System.Diagnostics;

namespace Personel_Listeleme.Controllers
{
	public class HomeController : Controller
	{
		public AdventureWorks2019Context _context;
		public HomeController(AdventureWorks2019Context context)
		{
			_context = context;
		}

		public IActionResult Index()
		{

			var personList = _context.Employees.Select(s => new ViewList()
			{
				Id = s.BusinessEntityId,
				JobTitle = s.JobTitle.Substring(0,23)+"..",
				Gender = s.Gender,


			}).ToList(); ;

			return View(personList);
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
}
