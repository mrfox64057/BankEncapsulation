namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount adamsAccount = new BankAccount();
            Console.WriteLine("Greetings, how much would you like to deposit today?");
            var amountDeposited = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(adamsAccount.GetBalance());
            adamsAccount.Deoposit(amountDeposited);
            Console.WriteLine(adamsAccount.GetBalance());
        }
    }
}
