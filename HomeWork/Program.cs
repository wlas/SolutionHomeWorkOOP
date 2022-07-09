using HomeWork;

Build build;

StartMenu();

void IntroMenu()
{
    Console.WriteLine("\nВЫБЕРЕТЕ НУЖНЫЙ ПУНКТ ИЗ МЕНЮ НИЖЕ:");
    Console.WriteLine("++++++++++++++++++++++++++++++++++");
    Console.WriteLine("1 - Создать здание.");
    Console.WriteLine("2 - Вывести список зданий на консоль.");
    Console.WriteLine("3 - Расчетать количество квартир в здании.");
    Console.WriteLine("4 - Расчитать высоту здания.");
    Console.WriteLine("0 - Для заверешение.");
    Console.WriteLine("+++++++++++++++++++++++++++++++++++");
    Console.Write("Укажите номер: ");
}

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
            case "2":
                PrintListBuilding(0);
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

        Floor();
        Apartments();
        Height();
        Entrances();

        build.CreateBuilding();
        PrintListBuilding(build.GetIDBuilding());

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
    }
}

void PrintListBuilding(int idBuilding)
{
    var building = Build.GetBuildingsList();

    if (building is not null)
    {
        if (building.Count > 0)
        {
            if(idBuilding == 0)
            {
                foreach (var item in building)
                {
                    Console.WriteLine("==========================");
                    PrintItem(item);
                }
            }
            else
            {
                PrintItem(building.Find(x => x.ID == idBuilding));
            }
        }
        else
        {
            Console.WriteLine("Список зданий пуст.");
        }
    }
}

void PrintItem(Building item)
{

    Console.WriteLine($"Номер здания: {item.ID};\n" +
           $"Количество подъездов: {item.Entrances};\n" +
           $"Этажность: {item.Floor};\n" +
           $"Количество квартир на этаже: {item.Apartments};\n" +
           $"Высота потолков: {item.Height};\n" +
           $"Общее количество квартир в здании: {item.AllApartments};\n" +
           $"Общая высота здания: {item.AllHeight}.\n");

}

void Floor()
{
    Console.Write("Укажите количество этажей: ");
    if (int.TryParse(Console.ReadLine(), out int floor))
    {
        build.SetFloor(floor);
    }
}

void Apartments()
{
    Console.Write("Укажите количество квартир на этаже: ");
    if (int.TryParse(Console.ReadLine(), out int apartments))
    {
        build.SetApartments(apartments);
    }
}

void Height()
{
    Console.Write("Укажите высоту потолка квартиры: ");
    if (float.TryParse(Console.ReadLine(), out float height))
    {
        build.SetHeight(height);
    }
}

void Entrances()
{
    Console.Write("Укажите количество подъездов: ");
    if (int.TryParse(Console.ReadLine(), out int entrances))
    {
        build.SetEntrances(entrances);
    }
}