using System;

namespace ejericiciopayroll
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Payroll myObj = new Payroll();
                Console.WriteLine("Insert document: ");
                myObj.setDocument(double.Parse(Console.ReadLine()));
                Console.WriteLine("*************************************");

                
                Console.WriteLine("Insert First Name: ");
                myObj.setFirstName(Console.ReadLine());
                Console.WriteLine("*************************************");

                Console.WriteLine("Insert Last Name: ");
                myObj.setLastName(Console.ReadLine());
                Console.WriteLine("*************************************");

              
                Console.WriteLine("Insert Salary: ");
                myObj.setSalary(double.Parse(Console.ReadLine()));
                Console.WriteLine("*************************************");


                Console.WriteLine("Insert Worked Days: ");
                myObj.setWorkedDays(double.Parse(Console.ReadLine()));
                Console.WriteLine("*************************************");







            }
            catch
            {

            }
        }
    }
}
