namespace InstallmentApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Buhari Installment App");

        bool isActive = true;

        while (isActive)
        {
            AppOperations.Starter();
            Console.WriteLine("Do you still want carry out another installment?\n------>Enter Y to Continue\n------>Enter any other key to Exit.");
            var option = Console.ReadLine();

            if (option.ToUpper() == "Y")
            {
                isActive = true;
            }
            else if (option.ToUpper() == "N")
            {
                isActive = false;
            }
            else
            {
                Console.WriteLine("You entered invalid option");
                isActive = false;
            }
        }
        isActive = false;
        Console.WriteLine("Enter any key to exit");

        Console.ReadKey();
    }
}
    

