using System;
using System.Collections;
namespace foresr
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string s1 = Console.ReadLine();
			char[] c1 = s1.ToCharArray();
			for (int i = 2; i < 6; i++) {
				Console.Write(c1[i]);
			}
		}
	}
}
