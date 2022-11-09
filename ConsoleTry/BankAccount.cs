using System.Text;
namespace MySuperBank
{
    public class BankAccount
    {
        // prop [Tab]：快速建立屬性
        // public int MyProperty { get; set; }
        // 建立屬性後，修改屬性類型，
        // 然後 [Tab] 修改屬性名稱，
        // 然後 [Tab] 移到最後，
        // 然後 [Enter] 換行繼續建立。
        public string Number { get; }
        public string Owner { get; set; }

        public decimal Balance
        {
            get 
            {
                decimal balance = 0;
                foreach (var item in allTransaction)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        private static int accountNumberSeed = 1234567890; 
        private List<Transaction> allTransaction = new List<Transaction>();
        
        public BankAccount(string name, decimal initialBalance)
        {
            Owner = name;
            Number = accountNumberSeed.ToString();
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
            accountNumberSeed++;
        }

        // Make Deposit：存款
        // Argument Out Of Range Exception：參數超出範圍異常
        // Amount of deposit must be positive：存款金額必須為正數
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive.");
            }
            var deposit = new Transaction(amount, date, note);
            allTransaction.Add(deposit);
        }

        // Make Withdrawal：提款
        // Argument Out Of Range Exception：參數超出範圍異常
        // Amount of withdrawal must be positive：提款金額必須為正數
        // Invalid Operation Exception：無效操作異常
        // Not sufficient funds for this withdrawal：本次提款資金不足
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive.");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransaction.Add(withdrawal);
        }

        public string GetAccountHistory()
        {
            var result = new StringBuilder();
            result.AppendLine("Date\t\tAmonut\tNote");
            foreach (var item in allTransaction)
            {
                result.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Notes}");
            }
            return result.ToString();
        }
    }
}