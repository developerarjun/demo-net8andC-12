namespace coreChangesDotnet8
{
    public class newChangeinCSharp12
    {
        public void demo()
        {
            #region Primary constructor
            Console.WriteLine("----------Primary constructor--------------");

            var bankAccount = new BankAccount("1234567890", "Arjun Ghimire");
            Console.WriteLine(bankAccount.ToString());
            #endregion

            #region Collection expressions
            Console.WriteLine("----------Collection expressions--------------");
            int[] row0 = [1, 2, 3];
            int[] row1 = [4, 5, 6];
            int[] row2 = [7, 8, 9];
            int[] single = [.. row0, .. row1, .. row2];
            foreach (var element in single)
            {
                Console.Write($"{element}, ");
            }
            #endregion
        }
    }
    public class BankAccount(string accountID, string owner)
    {
        public string AccountID { get; } = ValidAccountNumber(accountID)
            ? accountID
            : throw new ArgumentException("Invalid account number", nameof(accountID));

        public string Owner { get; } = string.IsNullOrWhiteSpace(owner)
            ? throw new ArgumentException("Owner name cannot be empty", nameof(owner))
            : owner;

        public override string ToString() => $"Account ID: {AccountID}, Owner: {Owner}";

        public static bool ValidAccountNumber(string accountID) =>
        accountID?.Length == 10 && accountID.All(c => char.IsDigit(c));
    }
}
