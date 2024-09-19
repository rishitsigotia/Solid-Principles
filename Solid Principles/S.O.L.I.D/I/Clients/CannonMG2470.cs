namespace Solid_Principles.S.O.L.I.D.I.Clients
{
	public class CannonMG2470 : IPrintTasks
	{
		public bool PhotoCopyContent(string content)
		{
			Console.WriteLine("PhotoCopy Done"); return true;
		}
		public bool PrintContent(string content)
		{
			Console.WriteLine("Print Done"); return true;
		}
		public bool ScanContent(string content)
		{
			Console.WriteLine("Scan Done"); return true;
		}

		public bool PrintDuplexContent(string content)
		{
			throw new NotImplementedException();
		}


		public bool FaxContent(string content)
		{
			throw new NotImplementedException();
		}
	}
}
