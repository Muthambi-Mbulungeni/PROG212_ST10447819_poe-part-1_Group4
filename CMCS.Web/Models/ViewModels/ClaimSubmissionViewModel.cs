namespace CMCS.Web.Models.ViewModels;

public class ClaimSubmissionViewModel
{
	public int Month { get; set; }
	public int Year { get; set; }
	public decimal HourlyRate { get; set; }
	public List<ClaimLineItem> Items { get; set; } = new();
}

public class ClaimLineItem
{
	public string ActivityDescription { get; set; } = string.Empty;
	public decimal Hours { get; set; }
}


