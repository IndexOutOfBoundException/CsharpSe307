namespace ConsoleApp1.Lab2
{
    public class CheckingBankAccountTest
    {
        public static void Main(string[] args)
        {
            CheckingBankAccount checkingBankAccount = new CheckingBankAccount("A2019C3",
                "Abdurrahman DEMİRİ",309.12);
            checkingBankAccount.Display();
            checkingBankAccount.Deposit(20);
            checkingBankAccount.Display();
            checkingBankAccount.ProcessCheck(100);
            checkingBankAccount.Display();
            checkingBankAccount.ProcessCheck(179.65);
            checkingBankAccount.Display();
            checkingBankAccount.ProcessCheck(200);
            checkingBankAccount.Display();
        }
    }
}