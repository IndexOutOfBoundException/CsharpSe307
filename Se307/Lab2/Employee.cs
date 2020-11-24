using System;

namespace Se307.Lab2
{
    public class Employee
    {
        private string firstName, lastName, position;
        private int age, workHours;
        private double paymentHour;
        
        public Employee(string firstName, string lastName, string position, int age, int workHours, double paymentHour)
        {
            try
            {
             
                this.firstName = firstName;
                this.lastName = lastName;
                this.position = position;
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            if (age <= 16 || age >= 70)
            {
                Console.WriteLine("Invalid Age!");
            }
            else
            {
                this.age = age;
            }

            if (workHours <= 0)
            {
                Console.WriteLine("Invalid working hours!");
            }
            else
            {
                this.workHours = workHours;
            }

            if (paymentHour < 0)
            {
                Console.WriteLine("Payments per hour must be positive!");
            }
            else
            {
                this.paymentHour = paymentHour;
            }
            
           
        }


        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public string Position
        {
            get => position;
            set => position = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public int WorkHours
        {
            get => workHours;
            set => workHours = value;
        }

        public double PaymentHour
        {
            get => paymentHour;
            set => paymentHour = value;
        }

        /*
          There is a wrong expression in the document. The calculateWeeklySalary is written wrong. It's said 
          workHour*paymentHour. However this method gives us the daily salary. That's why I considered 5 working days
          and multiplied the result with 5 in order to achieve weekly salary.
                                                        
         */
        public double calculateWeeklySalary()
        {
            return 5*workHours * paymentHour;
        }

        public void displayEmployeeInformation()
        {
            Console.WriteLine("First Name: "+ FirstName);
            Console.WriteLine("Last Name: " +lastName);
            Console.WriteLine("Age: " +age);
            Console.WriteLine("Position: " +position);
            Console.WriteLine("Weekly Salary: " +calculateWeeklySalary() +"TL");
        }

      
       
    }
}