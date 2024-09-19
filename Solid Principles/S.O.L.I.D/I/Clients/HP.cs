namespace Solid_Principles.S.O.L.I.D.I.Clients
{
	public class HP: IPrintTasks
	{
		public bool FaxContent(string content)
		{
			Console.WriteLine("Fax Done"); return true;
		}
		public bool PhotoCopyContent(string content)
		{
			Console.WriteLine("PhotoCopy Done"); return true;
		}
		public bool PrintContent(string content)
		{
			Console.WriteLine("Print Done"); return true;
		}
		public bool PrintDuplexContent(string content)
		{
			Console.WriteLine("Print Duplex Done"); return true;
		}
		public bool ScanContent(string content)
		{
			Console.WriteLine("Scan Done"); return true;
		}
	}
}
