using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Student : IComparable
	{
		public string Name { get; set; }
		public int Age { get; set; }

		public int CompareTo(object obj)
		{
			Student student = (Student)obj;
			if (Age > student.Age) return 1;
			if (Age < student.Age) return -1;
			return 0;
		}
	}
}
