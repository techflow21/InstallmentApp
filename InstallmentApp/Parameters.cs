using System.Text.RegularExpressions;

namespace InstallmentApp
{
    static class Parameters
    {
        public static string Username()
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            string pattern = @"^[a-zA-Z]{2,25}$";

            Regex regex = new Regex(pattern);

            if (! regex.IsMatch(userName))
            {
                Console.Clear();
                Console.WriteLine("Invalid user name, try again!");
                Username();
            }
            return userName;
        }
        public static string Product()
        {
            Console.Write("Enter the product name: ");
            string productEntry = Console.ReadLine();

            string pattern = @"^[a-zA-Z]{2,25}$";

            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(productEntry))

            {
                Console.Clear();
                Console.WriteLine("Invalid Product name, try again!");
                Product();
            }

            return productEntry;
        }
        public static decimal Amount()
        {
            Console.Write("Enter amount you want to pay now: ");
            string currentPay = Console.ReadLine();
            
            string pattern = @"^[a-zA-Z]$";
            Regex regex = new(pattern);

            try
            {
                if (regex.IsMatch(currentPay) || string.IsNullOrEmpty(currentPay))
                {
                    Console.Clear();
                    Console.WriteLine("Invalid amount entered, try again!");
                    Amount();
                }
                else if (Convert.ToDecimal(currentPay) < 0 || Convert.ToDecimal(currentPay) > 500000)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid amount entered, you can't pay negatve value or pay higher than maximum ($500000), try again!");
                    Amount();
                } 
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid amount entered, try again!");
                Amount();
            }

            catch (OverflowException)
            {
                Console.WriteLine("Invalid amount entered, try again!");
                Amount();
            }

            return Convert.ToDecimal(currentPay);
        }
    }
}
