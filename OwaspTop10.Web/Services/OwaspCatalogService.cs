using OwaspTop10.Web.Models;

namespace OwaspTop10.Web.Services
{
	public class OwaspCatalogService
	{
		public List<OwaspItem> GetAll() => new()
	{
		new() { Id = "A01", Title = "Broken Access Control",
				Description = "Users can act outside their intended permissions. Includes SSRF, IDOR, and privilege escalation.",
				RiskRating = "Critical", ControllerName = "A01", IsImplemented = false },

		new() { Id = "A02", Title = "Security Misconfiguration",
				Description = "Insecure default configs, unnecessary features enabled, verbose error messages, missing hardening.",
				RiskRating = "Critical", ControllerName = "A02", IsImplemented = false },

		new() { Id = "A03", Title = "Software Supply Chain Failures",
				Description = "Compromises in building, distributing, or updating software via vulnerable or malicious third-party dependencies.",
				RiskRating = "High", ControllerName = "A03", IsImplemented = false },

		new() { Id = "A04", Title = "Cryptographic Failures",
				Description = "Weak or missing cryptography leading to exposure of sensitive data, keys, or secrets.",
				RiskRating = "Critical", ControllerName = "A04", IsImplemented = false },

		new() { Id = "A05", Title = "Injection",
				Description = "Unsanitized user input is interpreted as commands — SQL, NoSQL, OS, LDAP injection and more.",
				RiskRating = "Critical", ControllerName = "A05", IsImplemented = false },

		new() { Id = "A06", Title = "Insecure Design",
				Description = "Missing or ineffective security controls at the architecture and design phase.",
				RiskRating = "High", ControllerName = "A06", IsImplemented = false },

		new() { Id = "A07", Title = "Authentication Failures",
				Description = "Weak authentication allowing credential stuffing, brute force, session hijacking, or account takeover.",
				RiskRating = "High", ControllerName = "A07", IsImplemented = false },

		new() { Id = "A08", Title = "Data Integrity Failures",
				Description = "Code and infrastructure lacking protection against integrity violations — insecure deserialization, tampered updates.",
				RiskRating = "High", ControllerName = "A08", IsImplemented = false },

		new() { Id = "A09", Title = "Security Logging & Alerting Failures",
				Description = "Insufficient logging and alerting allowing attacks to go undetected and unresponded to.",
				RiskRating = "Medium", ControllerName = "A09", IsImplemented = false },

		new() { Id = "A10", Title = "Mishandling of Exceptional Conditions",
				Description = "Applications that fail unsafely — leaking stack traces, failing open, crashing on bad input, or hiding errors.",
				RiskRating = "Medium", ControllerName = "A10", IsImplemented = false },
	};
	}
}
