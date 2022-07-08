using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Build
    {
        public static List<Building> buildings = new();

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

        public void CreateBuilding()
        {
            if(_FloorCount > 0 && _ApartmentsCount > 0 && _Height > 0 && _EntrancesCount > 0)
            {

            }
        }
    }
}
