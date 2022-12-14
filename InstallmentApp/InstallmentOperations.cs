namespace InstallmentApp
{
    public class InstallmentOperations
    {
        private static DateTime todaysDate;
        private static char cashType;
        private static decimal paymentAmount;
        
        public InstallmentOperations()
        {}

        public static void DailyInstallment(decimal amount, string product, string user)
        {
            Console.Clear();
            decimal dailyPercentage = (decimal)(10d/ 100);
            paymentAmount = 500000;
            cashType = '$';
            todaysDate = DateTime.Now;

            decimal installment = amount;
            decimal initialPay = paymentAmount;
            paymentAmount += dailyPercentage;
            decimal amountLeft = paymentAmount - installment;

            Console.Clear();
            Console.WriteLine($"Your initial debt is {cashType}{initialPay}");
            Console.WriteLine($"{user.ToUpper()}! You made a payment of {cashType}{installment} out of {cashType}{paymentAmount} payable worth of {product} on {todaysDate.ToString()}\n{cashType}{amountLeft} left to be paid by you.\n");     

        }
        
        public static void WeeklyInstallment(decimal amount, string product, string user)
        {
            char cashType = '$';
            decimal weeklyPercentage = (decimal)(40d / 100);
            paymentAmount = 500000;
            todaysDate = DateTime.Now;

            decimal installment = amount;
            decimal initialPay = paymentAmount;
            paymentAmount += weeklyPercentage;
            decimal amountLeft = paymentAmount - installment;

            Console.Clear();
            Console.WriteLine($"Your initial debt is {cashType}{initialPay}");
            Console.WriteLine($"{user.ToUpper()}! You made a payment of {cashType}{installment} out of {cashType}{paymentAmount} payable worth of {product} on {todaysDate.ToString()}\n{cashType}{amountLeft} left to be paid by you.\n");

        }
        
        public static void BiWeeklyInstallment(decimal amount, string product, string user)
        {
            char cashType = '$';
            decimal weeklyPercentage = (decimal)(70d / 100);
            paymentAmount = 500000;
            todaysDate = DateTime.Now;

            decimal installment = amount;
            decimal initialPay = paymentAmount;
            paymentAmount += weeklyPercentage;
            decimal amountLeft = paymentAmount - installment;

            Console.Clear();
            Console.WriteLine($"Your initial debt is {cashType}{initialPay}");
            Console.WriteLine($"{user.ToUpper()}! You made a payment of {cashType}{installment} out of {cashType}{paymentAmount} payable worth of {product} on {todaysDate.ToString()}\n{cashType}{amountLeft} left to be paid by you.\n");
        }

        
        public static void MonthlyInstallment(decimal amount, string product, string user)
        {
            char cashType = '$';
            decimal weeklyPercentage = (decimal)(100d / 100);
            paymentAmount = 500000;
            todaysDate = DateTime.Now;

            decimal installment = amount;
            decimal initialPay = paymentAmount;
            paymentAmount += weeklyPercentage;
            decimal amountLeft = paymentAmount - installment;

            Console.Clear();
            Console.WriteLine($"Your initial debt is {cashType}{initialPay}");
            Console.WriteLine($"{user.ToUpper()}! You made a payment of {cashType}{installment} out of {cashType}{paymentAmount} payable worth of {product} on {todaysDate.ToString()}\n{cashType}{amountLeft} left to be paid by you.\n");
        }
        
        public static void SixMonthsInstallment(decimal amount, string product, string user)
        {
            char cashType = '$';
            decimal weeklyPercentage = (decimal)(200d / 100);
            paymentAmount = 500000;
            todaysDate = DateTime.Now;

            decimal installment = amount;
            decimal initialPay = paymentAmount;
            paymentAmount += weeklyPercentage;
            decimal amountLeft = paymentAmount - installment;

            Console.Clear();
            Console.WriteLine($"Your initial debt is {cashType}{initialPay}");
            Console.WriteLine($"{user.ToUpper()}! You made a payment of {cashType}{installment} out of {cashType}{paymentAmount} payable worth of {product} on {todaysDate.ToString()}\n{cashType}{amountLeft} left to be paid by you.\n");
        }

        public static void AnnualInstallment(decimal amount, string product, string user)
        {
            char cashType = '$';
            decimal weeklyPercentage = (decimal)(300d / 100);
            paymentAmount = 500000;
            todaysDate = DateTime.Now;

            decimal installment = amount;
            decimal initialPay = paymentAmount;
            paymentAmount += weeklyPercentage;
            decimal amountLeft = paymentAmount - installment;

            Console.Clear();
            Console.WriteLine($"Your initial debt is {cashType}{initialPay}");
            Console.WriteLine($"{user.ToUpper()}! You made a payment of {cashType}{installment} out of {cashType}{paymentAmount} payable worth of {product} on {todaysDate.ToString()}\n{cashType}{amountLeft} left to be paid by you.\n");
        }
    }
}
