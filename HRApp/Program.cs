using HRLib;

namespace HRApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region git check
            Console.WriteLine("Git Check");
            #endregion
            Console.WriteLine("HRApp Test");

            ConfirmEmployee confirm = new ConfirmEmployee();
            Trainee trainee = new Trainee();

            //NO PARAMETER TEST
            Console.WriteLine(confirm); 
            Console.WriteLine(trainee);

            //PARAMETER TEST
            try
            {
                ConfirmEmployee confirm1 = new ConfirmEmployee("Ankit", "Pune", 4000, "Software Engineer");
                Console.WriteLine(confirm1);
                Console.WriteLine("Salary of Confirm Employee 1 is: " + confirm1.CalculateSalary());
            }
            catch(BasicTooLowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Trainee trainee1 = new Trainee("Aman", "Mumbai", 20, 1500);

            Console.WriteLine(trainee1);
    
            Console.WriteLine("Salary of Trainee 1 is: " + trainee1.CalculateSalary());

        }
    }
}
