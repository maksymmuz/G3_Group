using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	abstract class MainPageBase
	{
		protected void RenderPage()
		{
			RenderHeader();
			RenderBody();
			RenderFooter();
		}

		protected abstract void RenderHeader();
		protected abstract void RenderBody();
		protected abstract void RenderFooter();
	}
}
