using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
	public class CommentList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentvalues = new List<UserComment>
			{
				new UserComment
				{
					ID= 1,
					UserName= "Serhat"
				},
				new UserComment
				{
					ID= 2,
					UserName = "Uğurcan"
				},
				new UserComment
				{
					ID= 3,
					UserName="Engin"
				}
			};
			return View(commentvalues);
		}
	}
}
