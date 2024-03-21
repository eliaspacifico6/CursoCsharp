namespace Course.Entities {
    internal class BusinessAccaount : Account {

        public double LoanLimit { get; set; }

        public BusinessAccaount() {
        }

        public BusinessAccaount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance) {
            LoanLimit = loanLimit;
        }

        public void Loan( double amount ) {

            if (LoanLimit <= amount) {
                base.Withdraw( amount );
                Balance -= 2;
            }

        }

      
    }
}
