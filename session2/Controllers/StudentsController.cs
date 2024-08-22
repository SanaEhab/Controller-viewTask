using Microsoft.AspNetCore.Mvc;

namespace session2.Controllers
{
	public class StudentsController : Controller
	{
		public IActionResult GetAll()
		{
			return View("Index"); 
		}

		public IActionResult Create()
		{
			return View();
		}

		public IActionResult Update() 
		{
			return View();
		}
		public IActionResult Delete()
		{
			return View();
		}

	}
}
