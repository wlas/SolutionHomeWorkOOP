using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Building
    {
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

        public void Floor(int floor)
        {
            _FloorCount = floor;
        }

        public void Apartments(int apartments)
        {
            _ApartmentsCount = apartments;
        }

        public void Height(float height)
        {
            _Height = height;
        }

        public void Entrances(int entrances)
        {
            _EntrancesCount = entrances;
        }
    }
}
