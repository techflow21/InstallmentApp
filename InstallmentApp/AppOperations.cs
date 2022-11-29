namespace InstallmentApp
{
    internal class AppOperations
    {

        public static void Starter()
        {
            Dictionary<string, decimal> UserRecords = new Dictionary<string, decimal>() { };

            string user = Parameters.Username();
            decimal amount = Parameters.Amount();
            string product = Parameters.Product();
            UserRecords.Add(user, amount);

            Console.Clear();
            Option(UserRecords, user, product);
        }

        private static void Option(Dictionary<string, decimal> UserRecords, string user, string product)
        {
            decimal amount = UserRecords[user];

            Console.WriteLine($"Select an installment plan ");
            Console.WriteLine("Enter 1 for Daily Plan\nEnter 2 for Weekly Installment Plan\nEnter 3 for Bi-Weekly Installment Plan\nEnter 4 for Monthly Installment Plan\nEnter 5 for Six Months Installment Plan\nEnter 6 for Annual Installment Plan");

            var installmentOption = Console.ReadLine();

            try
            {
                switch (installmentOption)
                {
                    case "1":
                        InstallmentOperations.DailyInstallment(amount, product, user);
                        break;

                    case "2":
                        InstallmentOperations.WeeklyInstallment(amount, product, user);
                        break;

                    case "3":
                        InstallmentOperations.BiWeeklyInstallment(amount, product, user);
                        break;

                    case "4":
                        InstallmentOperations.MonthlyInstallment(amount, product, user);
                        break;

                    case "5":
                        InstallmentOperations.SixMonthsInstallment(amount, product, user);
                        break;

                    case "6":
                        InstallmentOperations.AnnualInstallment(amount, product, user);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid installment plan entered");
                        Option(UserRecords, user, product);
                        break;
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Invalid installment plan entered");
                Option(UserRecords, user, product);
            }

        }

    }
}
