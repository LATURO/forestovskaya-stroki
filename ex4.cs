using System;
using System.Collections;
namespace foresr
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string s1 = Console.ReadLine();
			string[] c1 = s1.Split(' ');
			for (int i = 0; i < c1.Length; i++) {
				Console.WriteLine(c1[i]);
			}
		}
	}
}
