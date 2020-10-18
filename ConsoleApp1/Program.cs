using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{

			#region Lists

			//List<string> testList = new List<string>();
			//testList.Add("test 1");
			//testList.Add("test 2");
			//testList.Add("test 3");
			//testList.Add("test 4");
			//testList.Add("test 5");
			//testList.Add("test 6");
			//testList.Add("test 7");
			//testList.Add("test 8");
			//testList.Add("test 9");

			//string[] vs = { "1", "2" };

			////testList.AddRange(vs);
			//var isContains = testList.Contains("test 6");			
			//var qwe = testList.Exists(e => e.Contains("test "));
			//testList.Insert(2, vs[1]);

			//Console.WriteLine(qwe);

			//Console.WriteLine(testList[5]);
			//Console.WriteLine(capacity2);


			//Dictionary<int, string> dictionaryList = new Dictionary<int, string>();

			//dictionaryList.Add(1, "dict value 1");
			//dictionaryList.Add(2, "dict value 2");
			//dictionaryList.Add(3, "dict value 3");
			//dictionaryList.Add(4, "dict value 4");
			//dictionaryList.Add(5, "dict value 5");


			//foreach (var item in dictionaryList)
			//{
			//	Console.WriteLine($"{ item.Key} {item.Value}");
			//}


			//foreach (var item in dictionaryList)
			//{
			//	Console.WriteLine(item.Value);
			//}
			#endregion

			Exception exception = new Exception();

			#region Exceptions


			string myString = null;
			int[] myArray = { 1, 2, 3, 4, 5 };
			try
			{
				Console.WriteLine(myString.Length);
				Console.WriteLine(myArray[5]);
				Console.WriteLine("Code after Exception");
			}
			
			catch (IndexOutOfRangeException ex)
			{
				Console.WriteLine("caught Argument Out Of Range Exception");
			}
			//catch (NullReferenceException ex)
			//{
			//	Console.WriteLine("caught Null Reference Exception");
			//}
			//catch (Exception ex)
			//{
			//	Console.WriteLine($"Caught Exception {ex.Message}");
			//	//Console.WriteLine(ex.Message);
			//	//throw new Exception($"My exception bla-bla, system exception is {ex.Message}");
			//}
			finally
			{
				Console.WriteLine("Finaly");
			}
	
			#endregion

			Console.ReadKey();
		}

		
	}
}
