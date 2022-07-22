namespace HomeWork
{
    public class BCoder : ICoder
    {
        public string Decode(string str)
        {
            return Encode(str);
        }

        public string Encode(string str)
        {
            if (str is null)
            {
                throw new ArgumentException("Строка не должна быть Null");
            }

            char[] arr = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                int firstRus = 1072;//буква 'а' в utf16
                int lastRus = 1103;//буква 'я' в utf 16

                int firstEng = 97;//буква 'a' в utf 16
                int lastEng = 122;//буква 'z' в utf 16

                var isLow = char.IsLower(str[i]);
                var ch = (int)char.ToLower(str[i]);

                if (ch >= firstRus && ch <= lastRus)//Определение русского алфавита
                {
                    ch = lastRus - (ch - firstRus);
                }
                if (ch >= firstEng && ch <= lastEng)//Определение английского алфавита
                {
                    ch = lastEng - (ch - firstEng);
                }

                if (isLow)
                {
                    arr[i] = (char)ch;
                }
                else
                {
                    arr[i] = char.ToUpper((char)ch);
                }
            }

            return new string(arr);
        }
    }
}
