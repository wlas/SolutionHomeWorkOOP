using System.Text;

namespace HomeWork
{
    internal struct RationalNumbers
    {
        /// <summary>
        /// Значение числителя
        /// </summary>
        private int _numerator;

        /// <summary>
        /// Значение знаменателя
        /// </summary>
        private int _denumerator;

        /// <summary>
        /// Числитель рационального числа
        /// </summary>
        public int Numerator => _numerator;

        /// <summary>
        /// Знаменатель рационального числа
        /// </summary>
        public int Denumerator => _denumerator;

        /// <summary>
        /// Переопределение стандартного констрктора. (0/1)
        /// </summary>
        public RationalNumbers() 
        { 
            _numerator = 0; 
            _denumerator = 1; 
        }

        /// <summary>
        /// Полный констрктор (Числитель/Знаменатель)
        /// </summary>
        /// <param name="numerator">Числитель</param>
        /// <param name="denumerator">Знаменатель</param>
        public RationalNumbers(int numerator, int denumerator)
        {
            _numerator = numerator;
            _denumerator = denumerator;
        }
        /// <summary>
        /// Конструктор целых чисел (Числитель/1)
        /// </summary>
        /// <param name="numerator">Числитель</param>
        public RationalNumbers(int numerator) : this(numerator, 1) { }
        /// <summary>
        /// Представление рационального числа в виде обыкновенной неупрощенной дроби.
        /// </summary>
        /// <returns>[Числитель]/[Знаменатель]</returns>
        public override string ToString()
        {
            return $"{Numerator}/{Denumerator}";
        }

        public static bool operator ==(RationalNumbers numb1, RationalNumbers numb2)
        {
            if ((numb1.Numerator == 0) && (0 == numb2.Numerator))
            {
                return true;
            }
            else if ((numb1.Numerator != 0) && (numb2.Numerator != 0) && ((numb2.Denumerator * numb1.Numerator) == (numb2.Numerator * numb1.Denumerator)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(RationalNumbers numb1, RationalNumbers numb2)
        {
            return !(numb1 == numb2);
        }

        public bool Equals(RationalNumbers numb)
        {
            return (this == numb);
        }
        public static bool operator <(RationalNumbers numb1, RationalNumbers numb2)
        {
            return (numb1.Numerator * numb2.Denumerator - numb2.Numerator * numb1.Denumerator) < 0;
        }

        public static bool operator >(RationalNumbers numb1, RationalNumbers numb2)
        {
            return (numb1.Numerator * numb2.Denumerator - numb2.Numerator * numb1.Denumerator) > 0;            
        }

        public static bool operator <=(RationalNumbers numb1, RationalNumbers numb2)
        {
            return (numb1.Numerator * numb2.Denumerator - numb2.Numerator * numb1.Denumerator) <= 0;
        }
        public static bool operator >=(RationalNumbers numb1, RationalNumbers numb2)
        {
            return (numb1.Numerator * numb2.Denumerator - numb2.Numerator * numb1.Denumerator) >= 0;
        }
        public static RationalNumbers operator +(RationalNumbers numb1, RationalNumbers numb2)
        {
            var denum = numb1.Denumerator * numb2.Denumerator;
            var numer = numb1.Numerator * numb2.Denumerator + numb1.Denumerator * numb2.Numerator;
            return new RationalNumbers(numer, denum);
        }
        public static RationalNumbers operator -(RationalNumbers numb1, RationalNumbers numb2)
        {
            var denum = numb1.Denumerator * numb2.Denumerator;
            var numer = numb1.Numerator * numb2.Denumerator - numb1.Denumerator * numb2.Numerator;
            return new RationalNumbers(numer, denum);
        }

        public static RationalNumbers operator ++(RationalNumbers numb)
        {
            var numbNew = numb._numerator + numb._denumerator;
            numb._numerator = numbNew;
            return numb;
        }
        public static RationalNumbers operator --(RationalNumbers numb)
        {
            var numNew = numb.Numerator - numb.Denumerator;
            numb._numerator = numNew;
            return numb;
        }
        public static RationalNumbers operator *(RationalNumbers numb1, RationalNumbers numb2)
        {
            var number = numb1.Numerator * numb2.Numerator;
            var denumber = numb1.Denumerator * numb2.Denumerator;
            return new RationalNumbers(number, denumber);
        }
        public static RationalNumbers operator /(RationalNumbers numb1, RationalNumbers numb2)
        {
            var number = numb1.Numerator * numb2.Denumerator;
            var denum = numb1.Denumerator * numb2.Numerator;
            var resNum = number / denum * denum;
            return new RationalNumbers(resNum, denum);
        }
        public static RationalNumbers operator %(RationalNumbers numb1, RationalNumbers numb2)
        {
            var numer = numb1.Numerator * numb2.Denumerator;
            var denum = numb1.Denumerator * numb2.Numerator;
            var resNum = numer % denum;
            return new RationalNumbers(resNum, denum);
        }
        public static explicit operator int(RationalNumbers numb)
        {
            int newNum = numb.Numerator / numb.Denumerator;
            return newNum;
        }
        public static explicit operator float(RationalNumbers numb)
        {
            float newNum = (float)numb.Numerator / (float)numb.Denumerator;
            return newNum;
        }
        public static explicit operator RationalNumbers(int numb)
        {
            return new RationalNumbers(numb);
        }
        public static explicit operator RationalNumbers(float numb)
        {
            if ((numb > int.MaxValue) || (numb < int.MinValue))
            {
                throw new ArgumentOutOfRangeException($"Модуль числа {nameof(numb)} слишком большой");
            }
            else if ((numb >= -10000) && (numb <= 10000))
            {
                int pastPoint = 100000;//Количество сохраняемых знаков после запятой
                var newNum = (int)(numb * pastPoint);
                return new RationalNumbers(newNum, pastPoint);
            }
            else
            {
                var newNum = (int)numb;
                return new RationalNumbers(newNum);
            }
        }

    }
}

