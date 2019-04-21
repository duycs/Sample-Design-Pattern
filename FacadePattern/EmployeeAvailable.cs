using System;

namespace Sample_Design_Pattern.FacadePattern{

    //a sub system
    public class EmployeeAvailable{
        public bool IsEmployeeAvailable(string employeeName){
            //check an employee avalible
            Console.WriteLine($"Employee {employeeName} available");
            return true;
        }
    }
}