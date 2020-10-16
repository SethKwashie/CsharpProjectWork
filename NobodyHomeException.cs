using System;
using System.Security.Cryptography.X509Certificates;

public class NobodyHomeException : Exception
{
	public NobodyHomeException(string message)
	{
		base(message);
	}
}
