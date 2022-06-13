using System;
using System.Collections.Generic;
using System.Text;

namespace ejericiciopayroll
{
    class Payroll
    {
        private double Document;
        private double WorkedDays;
        private double Salary;
        private string FirstName;
        private string LastName;
     
        public void setDocument(double Document_)
        { this.Document = Document_; }
        public double getDocument () 
        { return this.Document; }
       
        public void setWorkedDays(double WorkedDay_)
        { this.WorkedDays = WorkedDay_; }

        public double getWorkedDays()
        { return this.WorkedDays; }

        public void setSalary(double Salary_)
        { this.Salary = Salary_; }

        public double getSalary()
        { return this.Salary;}

        public void setFirstName(string FirstName_)
        { this.FirstName = FirstName_; }
        
        public string getFirtName()
        { return this.FirstName; }

        public void setLastName(string LastName_)
        { this.LastName = LastName_; }

        public string getLastNme()
        { return this.LastName; }
    }
}
