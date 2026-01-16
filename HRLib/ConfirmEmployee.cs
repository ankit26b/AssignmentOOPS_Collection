using System;
using System.Collections.Generic;
using System.Text;

namespace HRLib
{
    public class ConfirmEmployee : Employee
    {
        //Minimum basic salary allowed

        private const double MinBasic = 5000.0;

        private double basic;

		public double Basic
		{
			get { return basic; }
			set {

                if (value < MinBasic)
                {
                    throw new BasicTooLowException(value, MinBasic);
                }
           
               basic = value;
            }
        }

		private string designation;

		public string Designation
		{
			get { return designation; }
			set { designation = value; }
		}


        public ConfirmEmployee() : base()
        {
            Basic = MinBasic;
            Designation = "default";
        }


        public ConfirmEmployee(string name, string address, double basic, string designation) : base(name, address)
        {
            Basic = basic;          
            Designation = designation;
        }


        public sealed override double CalculateSalary()
        {
            double hraPct, convPct;

            if (Basic >= 30000)
            {
                hraPct = 0.30;
                convPct = 0.30;
            }
            else if (Basic >= 20000)
            {
                hraPct = 0.20; convPct = 0.20;
            }
            else
            {
                hraPct = 0.10; convPct = 0.10;
            }

            double hra = Basic * hraPct;
            double conv = Basic * convPct;
            double pf = Basic * 0.10;

            double netSalary = Basic + hra + conv - pf;
            return netSalary;
        }

    }
}
