namespace InstallmentApp
{
    static class Parameters
    {
        public static string Username()
        {
            Console.Write("Enter your name: ");
            string? userName = Console.ReadLine();

            if (userName.Trim() == "")
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
            string? ProductEntry = Console.ReadLine();

            if (ProductEntry.Trim() == "")
            {
                Console.Clear();
                Console.WriteLine("Invalid Product name entered, try again!");
                Product();
            }

            return ProductEntry;
        }
        public static decimal Amount()
        {
            Console.Write("Enter amount you want to pay now: ");
            var fee = Console.ReadLine();

            bool IsValid = decimal.TryParse(fee, out decimal toPayAmount);
            if (!IsValid)
            {
                Console.Clear();
                Console.WriteLine("Invalid amount entered, try again!");
                Amount();
            }

            return toPayAmount;
        }
    }
}
