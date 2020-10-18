using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class ParentClass
	{
		private int _age;


		public int Age
		{
			get 
			{ 
				return _age; 
			}
		}

		public int Age1
		{
			get => _age;
		}
	}

}