using System.Buffers.Text;
using System.Text.RegularExpressions;

namespace Solid_Principles.S.O.L.I.D.I
{
	/// <summary>
	/// 1. The interface-segregation principle (ISP) states that "no client should be forced to depend on methods it does not use".
	/// 2. Which means, Instead of one fat interface many small interfaces are preferred based on groups of methods with each one serving one submodule.
	/// 3. The ISP was first used and formulated by Robert C.Martin while consulting for Xerox.
	/// </summary>

	public interface IPrintTasks
	{
		bool PrintContent(string content);
		bool ScanContent(string content);
		bool FaxContent(string content);
		bool PhotoCopyContent(string content);
		bool PrintDuplexContent(string content);
	}


	//Code after Interface Segregation Principle

	namespace ISPDemoConsole
	{
		interface IPrintScanContent
		{
			bool PrintContent(string content);
			bool ScanContent(string content);
			bool PhotoCopyContent(string content);
		}

		interface IFaxContent
		{
			bool FaxContent(string content);
		}

		interface IPrintDuplex
		{
			bool PrintDuplexContent(string content);
		}
	}

	namespace ISPDemoConsole.Client
	{
		class HPLaserJet : IPrintScanContent, IFaxContent, IPrintDuplex
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

	namespace ISPDemoConsole.Client
	{
		class CannonMG2470 : IPrintScanContent
		{
			public bool PhotoCopyContent(string content)
			{
				Console.WriteLine("PhotoCopy Done");
				return true;
			}
			public bool PrintContent(string content)
			{
				Console.WriteLine("Print Done");
				return true;
			}
			public bool ScanContent(string content)
			{
				Console.WriteLine("Scan Done");
				return true;
			}
		}
	}


}
