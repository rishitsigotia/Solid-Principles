using Solid_Principles.S.O.L.I.D.O.OpenClosedDemo;

namespace Solid_Principles.S.O.L.I.D.L.Without_LSP
{
	class Program
	{
		static void Main(string[] args)
		{
			Employee empJohn = new PermanentEmployee(1, "John");
			Employee empJason = new TemporaryEmployee(2, "Jason");
			Employee empMike = new ContractEmployee(3, "Mike");
			Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
				empJohn.ToString(),
				empJohn.CalculateBonus(100000).ToString()));
			Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
			  empJason.ToString(),
			  empJason.CalculateBonus(150000).ToString()));
			Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
			  empMike.ToString(),
			  empMike.CalculateBonus(150000).ToString()));

			Console.ReadLine();
		}
	}
	//Above code throws an error at empMike, as Bonus is not applicable to ContractEmployee. In that case LSP is violated and we have redefined the code to follow LSP.
}
