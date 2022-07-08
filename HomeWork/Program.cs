using HomeWork;

Build build;

StartMenu();

/// <summary>
/// Вывод меню в консоль.
/// </summary>
void IntroMenu()
{
    Console.WriteLine("\nВЫБЕРЕТЕ НУЖНЫЙ ПУНКТ ИЗ МЕНЮ НИЖЕ:");
    Console.WriteLine("++++++++++++++++++++++++++++++++++");
    Console.WriteLine("1 - Создать здание.");
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
                CreateBuilding();               
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

void CreateBuilding()
{
    try
    {
        build = new();
        Console.WriteLine("Для создания здания введите следующие данные:");

        Console.Write("Укажите количество этажей: ");
        if (int.TryParse(Console.ReadLine(), out int floor))
        {
            build.SetFloor(floor);
        }

        Console.Write("Укажите количество квартир на этаже: ");
        if (int.TryParse(Console.ReadLine(), out int apartments))
        {
            build.SetApartments(apartments);
        }

        Console.Write("Укажите высоту потолка квартиры: ");
        if (float.TryParse(Console.ReadLine(), out float height))
        {
            build.SetHeight(height);
        }

        Console.Write("Укажите количество подъездов: ");
        if (int.TryParse(Console.ReadLine(), out int entrances))
        {
            build.SetEntrances(entrances);
        }

        build.CreateBuilding();
        Print(build.GetIDBuilding());

    }
    catch (Exception ex)
    {
       Console.WriteLine(ex.ToString());
    }    
}

void Print(int idBuilding)
{
    if(idBuilding == 0)
    {

    }

    Console.WriteLine();
}