namespace Solid_Principles.S.O.L.I.D.L.With_LSP
{
	public interface IEmployee
	{
		int ID { get; set; }
		string Name { get; set; }
		decimal GetMinimumSalary();
	}
}
