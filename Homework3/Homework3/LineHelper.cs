using System;


namespace Homework3
{
    public class LineHelper
    {
        //arrays of Translit letters
        private static string[] trstUp = { "Yo", "Zh", "Kh", "Sch", "Ch", "Sh", "Yu", "Ya", "A", "B", "V", "G", "D", "E", "Z", "I", "Y", "K", "L", "M", "N", "O", "P", "R", "S", "T", "C", "U", "F", "\"", "Y", "'", "E" };
        private static string[] trstLow = { "yo", "zh", "kh", "sch", "ch", "sh", "yu", "ya", "a", "b", "v", "g", "d", "e", "z", "i", "y", "k", "l", "m", "n", "o", "p", "r", "s", "t", "c", "u", "f", "\"", "y", "'", "e" };
        //arrays of Russian letters
        private static string[] rusUp = { "Ё", "Ж", "Х", "Щ", "Ч", "Ш", "Ю", "Я", "А", "Б", "В", "Г", "Д", "Е", "З", "И", "Ы", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "Ц", "У", "Ф", "Ъ", "Й", "Ь", "Э" };
        private static string[] rusLow = { "ё", "ж", "х", "щ", "ч", "ш", "ю", "я", "а", "б", "в", "г", "д", "е", "з", "и", "ы", "к", "л", "м", "н", "о", "п", "р", "с", "т", "ц", "у", "ф", "ъ", "й", "ь", "э" };

        public static string RussianToTranslit(string str1)  //method which replaces Russian letters with Translit letters
        {
            int j = 0;
            int length = 32;                                 //array length constant
            if (str1 == null)
            {
                throw new ArgumentNullException();
            }
            if (str1 != string.Empty)
            {
                if (!(str1[j] >= 32 && str1[j] <= 64))
                {
                    
                    for (int i = 0; i <= length; i++)
                    {
                        str1 = str1.Replace(rusUp[i], trstUp[i]);
                        str1 = str1.Replace(rusLow[i], trstLow[i]);
                    }
                    return str1;
                }
                else
                {
                    throw new ArgumentException ("Incorrect data entered");
                }
            }
            else
            {
                throw new Exception("No data entered");
            }
        }

        public static string TranslitToRussian(string str2) //method which replaces Translit letters with Russian letters
        {
            int j = 0;
            int length = 32;                                //array length constant
            if (str2 == null)
            {
                throw new ArgumentNullException();
            }
            if (str2 != string.Empty)
            {
                if (!(str2[j] >= 32 && str2[j] <= 64 ))
                {
                    for (int i = 0; i <= length; i++)
                    {
                        str2 = str2.Replace(trstUp[i], rusUp[i]);
                        str2 = str2.Replace(trstLow[i], rusLow[i]);
                    }
                    return str2;
                }
                else
                {
                    throw new ArgumentException("Incorrect data entered");
                }
            }
            else
            {
                throw new Exception("No data entered");
            }

        }
    }
}
