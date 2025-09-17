//using CMCS.Web.Models;
//using CMCS.Web.Models.ViewModels;
//using Microsoft.AspNetCore.Mvc;

//namespace CMCS.Web.Controllers;

//public class LecturerController : Controller
//{
//	public IActionResult Dashboard()
//	{
//		return View();
//	}

//	public IActionResult Submit()
//	{
//		var vm = new ClaimSubmissionViewModel
//		{
//			Month = DateTime.UtcNow.Month,
//			Year = DateTime.UtcNow.Year,
//			HourlyRate = 0
//		};
//		return View(vm);
//	}

//	public IActionResult MyClaims()
//	{
//		var sample = new List<Claim>
//		{
//			new Claim{ Id = 101, Month = DateTime.UtcNow.Month, Year = DateTime.UtcNow.Year, Status = ClaimStatus.Submitted, TotalHours = 10, HourlyRate = 500, Amount = 5000 },
//			new Claim{ Id = 102, Month = DateTime.UtcNow.AddMonths(-1).Month, Year = DateTime.UtcNow.Year, Status = ClaimStatus.Verified, TotalHours = 8, HourlyRate = 500, Amount = 4000 }
//		};
//		return View(sample);
//	}

//	public IActionResult UploadDocuments(int id)
//	{
//		ViewBag.ClaimId = id;
//		return View();
//	}
//}


