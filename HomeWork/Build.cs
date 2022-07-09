namespace HomeWork
{
    public class Build
    {
        private static List<Building> buildings = new();

        /// <summary>
        /// Счетчик уникальных номеров зданий
        /// </summary>
        private static int _counter = 1;

        /// <summary>
        /// Уникальный номер здания
        /// </summary>
        private int _IDBuilding;

        /// <summary>
        /// Высота здания
        /// </summary>
        private float _Height;

        /// <summary>
        /// Этажность
        /// </summary>
        private int _FloorCount;

        /// <summary>
        /// Количество квартир
        /// </summary>
        private int _ApartmentsCount;

        /// <summary>
        /// Количество подъездов
        /// </summary>
        private int _EntrancesCount;

        private int GetGenerateID()
        {
            return _counter++;
        }

        /// <summary>
        /// Задаем количество этажей
        /// </summary>
        /// <param name="floor">Этажность</param>
        public void SetFloor(int floor)
        {
            _FloorCount = floor;
        }

        /// <summary>
        /// Указываем количество квартир на этаже
        /// </summary>
        /// <param name="apartments">Количество квартир</param>
        public void SetApartments(int apartments)
        {
            _ApartmentsCount = apartments;
        }

        /// <summary>
        /// Задаем высоту 1 этажа
        /// </summary>
        /// <param name="height">Высота этажа</param>
        public void SetHeight(float height)
        {
            _Height = height;
        }

        /// <summary>
        /// Узнаем колличество подъездов
        /// </summary>
        /// <param name="entrances">Количество подъездов</param>
        public void SetEntrances(int entrances)
        {
            _EntrancesCount = entrances;
        }
        /// <summary>
        /// Создание строения и добавления его в список.
        /// </summary>
        public void CreateBuilding()
        {
            if(_FloorCount > 0 && _ApartmentsCount > 0 && _Height > 0 && _EntrancesCount > 0)
            {
                _IDBuilding = GetGenerateID();

                var building = new Building()
                {
                    ID = _IDBuilding,
                    Floor = _FloorCount,
                    Apartments = _ApartmentsCount,
                    Height = _Height,
                    Entrances = _EntrancesCount,
                    AllApartments = AllApartmentsCount(ref _FloorCount, ref _ApartmentsCount),
                    AllHeight = AllHeight(ref _FloorCount, ref _Height)
                };

                buildings.Add(building);
            }
        }

        /// <summary>
        /// Метод считает общее количество квартир в здании
        /// </summary>
        /// <param name="floor">Этажность</param>
        /// <param name="apartments">Количество квартир на этаже</param>
        /// <returns></returns>
        public static int AllApartmentsCount(ref int floor, ref int apartments)
        {
            return floor * apartments;
        }

        /// <summary>
        /// Метод считает высоту здания
        /// </summary>
        /// <param name="floor">Этажность</param>
        /// <param name="height">Высота этажа</param>
        /// <returns></returns>
        public static float AllHeight(ref int floor, ref float height)
        {
            float basement = 2.1F;

            float attic = 4.2F;

            return floor * height + basement + attic;
        }

        /// <summary>
        /// Метод возврыщает текущее ID здания
        /// </summary>
        /// <returns></returns>
        public int GetIDBuilding() => _IDBuilding;

        /// <summary>
        /// Метод возвращает список зданий.
        /// </summary>
        /// <returns></returns>
        public static List<Building> GetBuildingsList() => buildings;
        
    }
}
