using System;
using System.Collections.Generic;
using System.Text;

namespace HRLib
{
    public class Trainee : Employee
    {
        //no of days worked
        private int noOfDays;

		public int NoOfDays
		{
			get { return noOfDays; }
			set { noOfDays = value; }
		}

		private double ratePerDay;

		public double RatePerDay
		{
			get { return ratePerDay; }
			set { ratePerDay = value; }
		}


        public Trainee() : base()
        {
            NoOfDays = 0;
            RatePerDay = 0.0;
        }



        public Trainee(string name, string address, int noOfDays, double ratePerDay) : base(name, address)
        {
            NoOfDays = noOfDays;
            RatePerDay = ratePerDay;
        }


        public sealed override double CalculateSalary()
        {
            return NoOfDays * RatePerDay;
        }


        public override string ToString()
        {
            return base.ToString() + $", NoOfDays: {NoOfDays}, RatePerDay: {RatePerDay}";
        }

    }
}
