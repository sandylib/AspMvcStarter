using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using FailTracker.Web.Domain;
using FailTracker.Web.Filters;

namespace FailTracker.Web.Models.Issue
{
	public class NewIssueForm : IHaveIssueTypeSelectList, IHaveUserSelectList
	{
		public string Subject { get; set; }
		public string Body { get; set; }

		[Display(Name = "Issue Type")]
		public IssueType IssueType { get; set; }
		public SelectListItem[] AvailableIssueTypes { get; set; }

		[Display(Name = "Assigned To")]
		public string AssignedToUserID { get; set; }
		public SelectListItem[] AvailableUsers { get; set; }

	}
}