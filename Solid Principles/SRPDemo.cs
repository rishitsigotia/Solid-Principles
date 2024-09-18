namespace Solid_Principles
{	
	//Single Responsibility Principle
	//Consider a User Registration method that has to be there.
	//Basic method are there so they can be written like this.

	/// <summary>
	/// This interface is before applying S.R.P
	/// </summary>
	interface IUser_WithoutSRP
	{
		bool Login(string username, string password);
		bool Register(string username, string password, string email);
		void LogError(string error); // We don't need logging error in registration class.
		bool SendEmail(string emailContent); // We can have seprate for sending notification.
	}
	
	

	/// <summary>
	/// This is after applying SRP after are different
	/// </summary>
	interface IUser
	{
		bool Login(string username, string password);
		bool Register(string username, string password, string email);
	}
	/// <summary>
	/// Easy readable Classes
	/// </summary>
	interface ILogger
	{
		void LogError(string error);
	}
	/// <summary>
	/// Seperated classes for better fuctions
	/// </summary>
	interface IEmail
	{
		bool SendEmail(string emailContent);
	}
}
