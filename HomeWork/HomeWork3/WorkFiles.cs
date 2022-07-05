using System.Text;

namespace HomeWork.HomeWork3
{
    public class WorkFiles
    {
        private StringBuilder sbList;
        private StringBuilder sbEmail;

        private string _PathSaveFile = "Email.txt";     
        public WorkFiles(string path)
        {
            if(path != null)
            {
                sbList = new();
                sbEmail = new();

                using (StreamReader sr = new(path))
                {
                    while (true)
                    {                        
                        string line = sr.ReadLine();

                        if (line == null) break;

                        if (line.Length > 0)
                        {
                            var array = ReadStr(ref line);
                            if (array != null)
                            {
                                foreach (string item in array)
                                {
                                    string email = Email(item);
                                    if(email != null)
                                    {
                                        sbEmail.Append(email + "\n");
                                    }
                                }
                            }

                            sbList.Append(line + "\n");
                        }
                    }
                }

                if (sbEmail.Length > 0)
                {
                    if (!File.Exists(_PathSaveFile))
                    {
                        using (File.Create(_PathSaveFile)) ;
                    }

                    using (StreamWriter sw = new StreamWriter(_PathSaveFile))
                    {
                        sw.WriteLine(sbEmail);
                    }
                }
            }            
        }
        /// <summary>
        /// Метод возвращчет список строк прочитанных из файла.
        /// </summary>
        /// <returns>Возвращается строка</returns>
        public StringBuilder GetFIOList()
        {
            return sbList;
        }

        /// <summary>
        /// Метод возвращает список найденных email адресов.
        /// </summary>
        /// <returns>Взврощается строка</returns>
        public StringBuilder GetEmailList()
        {
            return sbEmail;
        }

        /// <summary>
        /// Метод ищет email адрес в строке
        /// </summary>
        /// <param name="str">Строка для поиска</param>
        /// <returns>Возврщается строка с найденным email адресом</returns>
        private String Email(string str)
        {
            string email = default;

            if(str.Length > 0)
            {
                if (str.Contains("@"))
                {
                    email = str.Trim();
                }
            }            

            return email;
        }

        /// <summary>
        /// Разбиваем строку на массив строк.
        /// </summary>
        /// <param name="str">Строка из файла</param>
        /// <returns>Массив строк</returns>
        private String[] ReadStr(ref string str)
        {
            String[] strArr = default;

            if (str.Length > 0)
            {
                strArr = str.Split('&');
            }                

            return strArr;
        }

        /// <summary>
        /// Метод принимает строку и возвращает эту строку в обратном порядке.
        /// </summary>
        /// <param name="str">Строка ввода</param>
        /// <returns>Возвращаемая страка в обратном порядке.</returns>
        static public string StringRevers(string str)
        {
            StringBuilder sb = new StringBuilder();
            var array = str.Reverse();
            foreach (var item in array)
            {
                sb.Append(item);
            }

            return sb.ToString();
        }
    }
}
