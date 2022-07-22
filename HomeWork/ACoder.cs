namespace HomeWork
{
    public class ACoder : ICoder
    {
        public string Decode(string str)
        {
            if(str is null)
            {
                throw new ArgumentNullException("Строка не должна быть Null.");
            }

            char[] arr = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                var ch = char.ToLower(str[i]) - 1;
                if (char.IsLower(str[i]))
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

        public string Encode(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException("Строка не должна быть Null.");
            }

            char[] arr = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                var ch = char.ToLower(str[i]) + 1;

                if (char.IsLower(str[i]))
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
