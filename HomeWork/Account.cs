namespace HomeWork
{
    public class Account
    {
        long _number = 8834_4686_3468_7843;        

        decimal _balance = 0.10m;

        TypeOfBankAccount _typeAccount = TypeOfBankAccount.DEBIT;



        public Account()
        {

        }

        public override string ToString()
        {
            return $"Номер лицевого счета: {_number}\nВаш баланс: {_balance} РУБ\nТип вашего счета: {_typeAccount}";
        }

        public bool AddBalans()
        {
            bool balans = false;

            Console.Write($"Введите сумму для зачислеения на Ваш счет {_number}: ");
            if (Decimal.TryParse(Console.ReadLine(), out decimal result))
            {
                _balance = _balance + result;
                balans = true;
            }
            else
            {
                Console.WriteLine("Ошибка. Не корректный ввод данных.");
            }

            return balans;
        }
    }
}
