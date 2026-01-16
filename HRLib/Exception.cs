using System;
using System.Collections.Generic;
using System.Text;

namespace HRLib
{
    public class BasicTooLowException: Exception
    {

		public BasicTooLowException(double attempted, double minimum) : base()
		{
			Console.WriteLine($"Basic salary {attempted} is below the minimum allowed {minimum}.");
		}

    }
}
