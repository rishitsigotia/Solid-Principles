using Microsoft.AspNetCore.SignalR;

namespace Solid_Principles.S.O.L.I.D.O
{
	//	1.The simplest way to apply OCP is to implement the new functionality on new derived(sub) classes that inherit the original class implementation.
	// 2.Another way is to allow client to access the original class with an abstract interface.
	// 3.So, at any given point of time when there is a requirement change instead of touching the existing functionality it’s always suggested to create new classes and leave the original implementation untouched

	//code before applying OPEN CLOSED
	public class Employee
	{
		Employee() { }
		public Employee(int id, string name, string type)
		{
			this.ID = id;
			this.Name = name;
			this.EmployeeType = type;
		}

		public int ID { get; set; }
		public string EmployeeType { get; set; }
		public string Name { get; set; }

		public decimal CalculateBonus(decimal salary)
		{
			if (this.EmployeeType == "Permanent")
				return salary * .1M;
			else
				return salary * .05M;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Employee empJohn = new Employee(1, "John", "Permanent");
			Employee empJason = new Employee(2, "Jason", "Temp");

			Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
				empJohn.ToString(),
				empJohn.CalculateBonus(100000).ToString()));
			Console.ReadLine();
		}
	}
	//-------------------------------------------------------------------------------------------//

	//Code after Open Closed Principle Implementation



	namespace OpenClosedDemo
	{
		public abstract class Employee
		{
			public int ID { get; set; }
			public string Name { get; set; }

			public Employee()
			{
			}
			public Employee(int id, string name)
			{
				this.ID = id; this.Name = name;
			}
			public abstract decimal CalculateBonus(decimal salary);

			public override string ToString()
			{
				return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
			}
		}

		public class PermanentEmployee : Employee
		{
			public PermanentEmployee()
			{ }

			public PermanentEmployee(int id, string name) : base(id, name)
			{ }
			public override decimal CalculateBonus(decimal salary)
			{
				return salary * .1M;
			}
		}
		public class TemporaryEmployee : Employee
		{
			public TemporaryEmployee()
			{ }

			public TemporaryEmployee(int id, string name) : base(id, name)
			{ }
			public override decimal CalculateBonus(decimal salary)
			{
				return salary * .05M;
			}
		}
		class Program
		{
			static void Main(string[] args)
			{
				Employee empJohn = new PermanentEmployee(1, "John");
				Employee empJason = new TemporaryEmployee(2, "Jason");

				Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
					empJohn.ToString(),
					empJohn.CalculateBonus(100000).ToString()));
				Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
				  empJason.ToString(),
				  empJason.CalculateBonus(150000).ToString()));
				Console.ReadLine();
			}
		}
	}
}