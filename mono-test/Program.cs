using System;

namespace monotest
{
	class MainClass
	{
		void Foo (int fuga = 10)
		{
		}

		void Foo (string hoge, int fuga = 10)
		{
		}

		public static void Main ()
		{
		}

		void Bar()
		{
			Foo (fuga: 20);
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
		}
	}
}
