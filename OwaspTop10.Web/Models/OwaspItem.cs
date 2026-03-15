namespace OwaspTop10.Web.Models
{
    public class OwaspItem
    {
		public string Id { get; set; } = string.Empty;          // e.g. "A01"
		public string Title { get; set; } = string.Empty;       // e.g. "Broken Access Control"
		public string Description { get; set; } = string.Empty;
		public string RiskRating { get; set; } = string.Empty;  // Critical / High / Medium
		public string ControllerName { get; set; } = string.Empty;
		public bool IsImplemented { get; set; } = false;
	}
}
