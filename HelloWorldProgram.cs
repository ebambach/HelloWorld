using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProject {
	class Program 	{
		//When you set up a class, make sure to put any properties (variables)
		//first.
		static int Age;
		//After you have your properties set up, add your methods.
		static void Main(string[] args){
			Age = 0;
			Console.WriteLine("Hello, world!");
			Console.WriteLine(Age);
			
			double R = 1.0;
			double pi = 3.1419;
			double P = (2 * R * pi);
			Console.WriteLine("The perimeter has a value of " + P);
			double C = Math.Sqrt((3*3)+(4*4));
			Console.WriteLine("C has a value of " + C);

			string s = "All work and no play makes Jack a dull boy.";
			var sUppercase = s.ToUpper();
			var sLowercase = s.ToLower();
			Console.WriteLine(s);
			Console.WriteLine(sUppercase);
			Console.WriteLine(sLowercase);

			Console.WriteLine("____   ____");
			Console.WriteLine("|  _|  |  _|");
			Console.WriteLine("|_[_|  |_[_| ");
			Console.WriteLine("");
			Console.WriteLine("-_        _-");
			Console.WriteLine("  -______-");

			var FirstName = "Eric";
			var LastName = "Bambach";
			var FullName = FirstName + " " + LastName;
			Console.WriteLine("My full name is " + FullName + ".");

			string ANewString = $"{s} {sUppercase} {sLowercase}";
			Console.WriteLine(ANewString);
		}
	}
}
