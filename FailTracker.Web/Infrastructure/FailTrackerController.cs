using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using FailTracker.Web.Filters;
using Microsoft.Web.Mvc;

namespace FailTracker.Web.Infrastructure
{
	[IssueTypeSelectListPopulator,
	 UserSelectListPopulator]
	public abstract class FailTrackerController : Controller
	{
		protected ActionResult RedirectToAction<TController>(
			Expression<Action<TController>> action)
			where TController : Controller
		{
			return ControllerExtensions.RedirectToAction(this, action);
		}
	}
}