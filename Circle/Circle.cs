using System;

namespace Circle
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double radius;
			string input;
			double pi = 3.14149;


			Console.WriteLine(" What is the radius of the circle?");
			input = Console.ReadLine();
			radius = double.Parse(input);

			double diameter = 2 * radius;
			double circumference = 2 * pi * radius;
			double area = pi * radius * radius;

			Console.WriteLine("The diameter of the circle is " + diameter);
			Console.WriteLine("The circumference of the circle is " + circumference);
			Console.WriteLine("The area of the circle is " + area);

		}
	}
}
