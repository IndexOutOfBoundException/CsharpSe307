using System;

namespace ConsoleApp1.Lab2
{
    public class CheckingBankAccount
    {
        private string accountNum, nameOfAccountHolder;
        private double currentBalance;
        
        public CheckingBankAccount(string accountNum, string nameOfAccountHolder, double currentBalance)
        {
            try
            {
                this.currentBalance = currentBalance;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
               
            }

            this.nameOfAccountHolder = nameOfAccountHolder;
            this.accountNum = accountNum;
           
           
        }

        public string AccountNum
        {
            get => accountNum;
            set => accountNum = value;
        }

        public string NameOfAccountHolder
        {
            get => nameOfAccountHolder;
            set => nameOfAccountHolder = value;
        }

        public double CurrentBalance
        {
            get => currentBalance;
            set => currentBalance = value;
        }

        public double Deposit(double amount)
        {
            if (amount < 0)
                Console.WriteLine("Deposited amount cannot be less than 0!");
            else
            {
                return currentBalance += amount;
            }

            return 1;
        }
        
        /*
         As I understand from the documentation the ProcessCheck method is going to decrease the balance in each money 
        withdrawal.And if the balance is under 100 there will be a stoppage each withdrawal. I mean, let's assume
        our balance is -150 and we withdrew 4 liras from the account. The new balance will be -150-4-4,8=-158,8
        I hope I understand clearly.
        */
        public double ProcessCheck(double checkAmount)
        {
            currentBalance = (currentBalance < 100)
                ? currentBalance -=(4.8 + checkAmount) 
                : currentBalance -= checkAmount;
            return currentBalance;
        }

        public void Display()
        {
            Console.WriteLine("Account Number: " +accountNum);
            Console.WriteLine("Name: " +nameOfAccountHolder);
            Console.WriteLine("Balance: " +currentBalance +" TL\n");
        }


    }
}