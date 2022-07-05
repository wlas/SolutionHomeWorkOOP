namespace HomeWork
{
    public class Account
    {
        private long _number = 8834_4686_3468_7843;

        private decimal _balance = 0.10m;

        private TypeOfBankAccount _typeAccount = TypeOfBankAccount.DEBIT;

        public override string ToString()
        {
            return $"Номер лицевого счета: {_number}\nВаш баланс: {_balance} РУБ\nТип вашего счета: {_typeAccount}";
        }

        public void AddBalans(decimal result)
        {
            _balance = _balance + result;
        }

        public bool WithdrawBalans(decimal result)
        {
            bool balans = false;

            if (result <= _balance)
            {
                _balance = _balance - result;
                balans = true;
            }

            return balans;
        }
    }
}
