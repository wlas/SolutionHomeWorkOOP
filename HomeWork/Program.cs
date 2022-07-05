using HomeWork;

Account account = new();

StartMenu();


/// <summary>
/// Вывод меню в консоль.
/// </summary>
void IntroMenu()
{
    Console.WriteLine("\nВЫБЕРЕТЕ НУЖНЫЙ ПУНКТ ИЗ МЕНЮ НИЖЕ:");
    Console.WriteLine("++++++++++++++++++++++++++++++++++");
    Console.WriteLine("1 - Вывести информацию о счете на экран.");
    Console.WriteLine("2 - Положить на счет.");
    Console.WriteLine("3 - Снять со счета.");
    Console.WriteLine("0 - Для заверешение.");
    Console.WriteLine("+++++++++++++++++++++++++++++++++++");
    Console.Write("Укажите номер: ");
}

/// <summary>
/// Вывод меню в консоль.
/// </summary>
void StartMenu()
{
    while (true)
    {
        IntroMenu();

        string rezult = Console.ReadLine();

        switch (rezult)
        {
            case "1":
                PrintInfo();
                break;
            case "2":
                AddBalans();
                break;
            case "3":
                WithdrawBalans();
                break;
            case "0":
                Console.WriteLine("Завершение программы.");
                Console.ReadKey(true);
                return;
            default:
                Console.WriteLine("Не определено. Пожалуйста, укажите цифру повторно.");
                break;
        }
    }
}

void PrintInfo()
{
    Console.WriteLine(account);
}

void AddBalans()
{
    Console.Write($"Введите сумму для зачислеения на Ваш счет: ");
    if (Decimal.TryParse(Console.ReadLine(), out decimal result))
    {
        account.AddBalans(result);
        Console.WriteLine(account);
    }
    else
    {
        Console.WriteLine("Ошибка. Не корректный ввод данных.");
    }
}

void WithdrawBalans()
{
    Console.Write($"Введите сумму для снятия с Вашего счета: ");
    if (Decimal.TryParse(Console.ReadLine(), out decimal result))
    {
        if (account.WithdrawBalans(result))
        {
            Console.WriteLine(account);
        }
        else
        {
            Console.WriteLine("На вашем счету не достаточно средств.");
        }
    }
    else
    {
        Console.WriteLine("Ошибка. Не корректный ввод данных.");
    }
}