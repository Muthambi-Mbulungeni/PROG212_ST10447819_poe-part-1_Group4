//using CMCS.Web.Models;
//using Microsoft.AspNetCore.Mvc;

//namespace CMCS.Web.Controllers;

//public class AdminController : Controller
//{
//	public IActionResult Coordinator()
//	{
//		var pending = new List<Claim>
//		{
//			new Claim{ Id = 201, Month = DateTime.UtcNow.Month, Year = DateTime.UtcNow.Year, Status = ClaimStatus.Submitted, TotalHours = 12, HourlyRate = 450, Amount = 5400 },
//		};
//		return View(pending);
//	}

//	public IActionResult Manager()
//	{
//		var toApprove = new List<Claim>
//		{
//			new Claim{ Id = 301, Month = DateTime.UtcNow.Month, Year = DateTime.UtcNow.Year, Status = ClaimStatus.Verified, TotalHours = 15, HourlyRate = 500, Amount = 7500 },
//		};
//		return View(toApprove);
//	}

//	public IActionResult Review(int id)
//	{
//		var claim = new Claim
//		{
//			Id = id,
//			Month = DateTime.UtcNow.Month,
//			Year = DateTime.UtcNow.Year,
//			Status = ClaimStatus.Submitted,
//			HourlyRate = 500,
//			TotalHours = 10,
//			Amount = 5000,
//			Lines = new List<ClaimLine>
//			{
//				new ClaimLine{ Id = 1, ClaimId = id, ActivityDescription = "Lecture: PROG6212", Hours = 6 },
//				new ClaimLine{ Id = 2, ClaimId = id, ActivityDescription = "Marking", Hours = 4 }
//			},
//			Documents = new List<Document>
//			{
//				new Document{ Id = 1, ClaimId = id, FileName = "Timesheet.pdf", FilePath = "/uploads/Timesheet.pdf" },
//			}
//		};
//		return View(claim);
//	}
//}


