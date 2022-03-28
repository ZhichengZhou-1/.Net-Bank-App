using System;
using System.Collections.Generic;
using System.Text;
using Humanizer;


namespace BankyStuff
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTranscations)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        private static int accountNumberSeed = 123456789;

        private List<Transcation> allTranscations = new List<Transcation>();
        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be postive");

            }
            var deposit = new Transcation(amount, date, note);
            allTranscations.Add(deposit);

        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive.");
            }
            if (this.Balance - amount < 0)
            {
                throw new ArgumentOutOfRangeException("Not sufficient funds for withdrawal.");

            }
            var withdrawal = new Transcation(-amount, date, note);
            allTranscations.Add(withdrawal);
        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();
            report.AppendLine("Date \t\tAmount \t\tNote");
            foreach(var item in allTranscations)
            {
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.AmountForHumans}\t\t{item.Notes}");

            }
            return report.ToString();
        }
    }
}