namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            Console.WriteLine("Hello, How much would you like to deposit?");
            var amountToDeposit = double.Parse(Console.ReadLine());

            account.Deposit(amountToDeposit);



            Console.WriteLine($"Your account balance is ${account.GetBalance()} dollars.");
        }
    }
}
