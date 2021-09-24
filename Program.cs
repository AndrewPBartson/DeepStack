using System;

namespace assignment_0
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Andrew - basic", 1000);
            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.GetAccountHistory());

            var giftCard = new GiftCardAccount("Drew - gift card", 100, 50);
            giftCard.MakeWithdrawal(20, DateTime.Now, "Get expensive coffee");
            giftCard.MakeWithdrawal(50, DateTime.Now, "Buy groceries");
            giftCard.PerformMonthEndTransactions();
            // can make additional deposits:
            giftCard.MakeDeposit(27.50m, DateTime.Now, "Add money from piggy bank");
            Console.WriteLine(giftCard.GetAccountHistory());

            var savings = new InterestEarningAccount("Andy - savings account", 10000);
            savings.MakeDeposit(750, DateTime.Now, "Save some money");
            savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
            savings.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
            savings.PerformMonthEndTransactions();
            Console.WriteLine(savings.GetAccountHistory());

            var lineOfCredit = new LineOfCreditAccount("Panda - line of credit", 0, 10000);
            // How much is too much to borrow?
            lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
            lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
            lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
            lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
            lineOfCredit.PerformMonthEndTransactions();
            Console.WriteLine(lineOfCredit.GetAccountHistory());
            /*
            // Test that initial balance is positive.
            BankAccount invalidAccount;
                try
                {
                    invalidAccount = new BankAccount("invalid", -55);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Exception caught creating account with negative balance");
                    Console.WriteLine(e.ToString());
                    return;
                }
            // Test for negative balance
                try
                {
                    account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine("Exception caught trying to overdraw");
                    Console.WriteLine(e.ToString());
                }*/
            Console.ReadKey();
        }
    }
}
