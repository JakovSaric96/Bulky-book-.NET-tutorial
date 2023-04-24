using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{
	public class BurekController : Controller
	{
		public IActionResult Secret()
		{
			return View();
		}
	}
}
