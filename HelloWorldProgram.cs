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
		int IncrementNumber(int p1) {
			p1 = p1 + 7;
			return p1;
		}
		//The "AddNumbers" methods can both be used, depending on how many parameters are passed to them,
		//and the type of parameters.
		int AddNumbers(int parameter1, int parameter2) {
			return parameter1 + parameter2;
		}
		double AddNumbers(double parameter1, double parameter2) {
			return parameter1 + parameter2;
		}
		int AddNumbers(int parameter1, int parameter2, int parameter3) {
			return parameter1 + parameter2 + parameter3;
		}
		int SubtractTwoNmbers(int parameter1, int parameter2) {
			return parameter1 - parameter2;
		}
		string ToFullName(string p1, string p2) {
			//Using the $ to combine these variables in the brackets in called "interpolation"
			var FullName = $"{p1} {p2}";
			return FullName;
		}
		void Print(string message) {
			Console.WriteLine(message);
		}
		static void Main(string[] args) {
			new Program().Run();
		}
		void Run() {
			//The lines below send two numbers as parameters to the above methods, which are then
			//printed as strings.
			var p1 = 5;
			Print(IncrementNumber(p1).ToString());
			var sum = AddNumbers(3.5, 4.6);
			Print(sum.ToString());
			var difference = SubtractTwoNmbers(2, 2);
			Print(difference.ToString());

			Age = 29;
			string message = "Hello, world!";
			Console.WriteLine(Age.ToString());
			
			//double R = 1.0;
			//double pi = 3.1419;
			//double P = (2 * R * pi);
			//Console.WriteLine("The perimeter has a value of " + P);
			//double C = Math.Sqrt((3*3)+(4*4));
			//Console.WriteLine("C has a value of " + C);

			string s = "All work and no play makes Jack a dull boy.";
			var sUppercase = s.ToUpper();
			var sLowercase = s.ToLower();
			//Console.WriteLine(s);
			//Console.WriteLine(sUppercase);
			//Console.WriteLine(sLowercase);

			Console.WriteLine("____   ____");
			Console.WriteLine("|  _|  |  _|");
			Console.WriteLine("|_[_|  |_[_| ");
			Console.WriteLine("");
			Console.WriteLine("-_        _-");
			Console.WriteLine("  -______-");

			var FirstName = "Eric";
			var LastName = "Bambach";
			Print(ToFullName(FirstName, LastName));
			
			//string message = $"{s} {sUppercase} {sLowercase}";
			Print(message);
		}
	}
}
