namespace HRLib
{
    public abstract class Employee
    {
        //last employee number assigned
        private static int lastEmpNo = 1000;

		private int empNo;

		public int EmpNo
		{
			get { return empNo; }
			private set { empNo = value; }
		}


		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string address;

		public string Address
		{
			get { return address; }
			set { address = value; }
		}


        protected Employee()
        {
			lastEmpNo++;
			EmpNo = lastEmpNo;
            Name = "default";
            Address = "default";
        }

		protected Employee(string name, string address) : this()
		{
			Name = name;
			Address = address;
		}

        public abstract double CalculateSalary();


        public override string ToString()
        {
            return $"EmpNo:{EmpNo} Name: {Name}, Address: {Address}";
        }

    }
}
