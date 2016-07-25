using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using FailTracker.Web.Domain;
using FailTracker.Web.Filters;
using FailTracker.Web.Infrastructure.Mapping;

namespace FailTracker.Web.Models.Issue
{
	public class EditIssueForm : IMapFrom<Domain.Issue>, 
		IHaveUserSelectList, IHaveIssueTypeSelectList
	{
		public int IssueID { get; set; }
		public string Subject { get; set; }
		public string CreatorUserName { get; set; }
		public string Body { get; set; }

		[Display(Name = "Issue Type")]
		public IssueType IssueType { get; set; }
		public SelectListItem[] AvailableIssueTypes { get; set; }
	
		[Display(Name = "Assigned To")]
		public string AssignedToID { get; set; }
		public SelectListItem[] AvailableUsers { get; set; }
	}
}