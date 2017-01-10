using System;
using System.Collections;
namespace foresr
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string s1 = Console.ReadLine();
			string s2 = Console.ReadLine();
			if (s1 == s2) {
				Console.WriteLine("при проверке == они равны");
			}
			else if (s1 != s2)
			{
				Console.WriteLine("при проверке == они не равны");
			}

			if (String.CompareOrdinal(s1,s2)==0)
			{
				Console.WriteLine("при проверке CompareOrdinal они равны");
			}
			else if (String.CompareOrdinal(s1, s2) != 0)
			{
				Console.WriteLine("при проверке CompareOrdinal они не равны");
			}
		}
	}
}
