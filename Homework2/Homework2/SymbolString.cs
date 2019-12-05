
namespace Homework2
{
    public class SymbolString
    {
       public static int DifferentElem(string str)     //finding max number of different elements   
        {
            int count = 1;                      //counter to register the number of testing elements 
            int length = str.Length;            //length of the line
            int maxElem = 0;
            for (int i = 0; i < length - 1; i++)     
            {
                if (str[i] != str[i + 1])
                {
                    count++;

                    if (count > maxElem)
                    {
                        maxElem = count;
                    }
                }
                else
                {
                    count = 1;
                }

            }
            return maxElem;
        }

        public static int EqualNumbers(string str)     //finding max number of repeating numbers
        {
            int count = 1;                      //counter to register the number of testing elements 
            int length = str.Length;            //length of the line
            int maxNumb = 0;
            for (int i = 0; i < length - 1; i++)     
            {
                if (str[i] >= 48 && str[i] <= 57)
                {
                    if (str[i] == str[i + 1])
                    {
                        count++;

                        if (count > maxNumb)
                        {
                            maxNumb = count;
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                }

            }
            return maxNumb;
        }

        public static int EqualLatin(string str)    //finding max number of repeating latin letters
        {
            int count = 1;                      //counter to register the number of testing elements 
            int length = str.Length;            //length of the line
            int maxLat = 0;
            for (int i = 0; i < length - 1; i++)     
            {
                if ((str[i] >= 65 && str[i] <= 90) || (str[i] >= 97 && str[i] <= 122))
                {
                    if (str[i] == str[i + 1])
                    {
                        count++;

                        if (count > maxLat)
                        {
                            maxLat = count;
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                }

            }
            return maxLat;
        }
      
    }
}
