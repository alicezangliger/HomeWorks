using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {  
            string line1;
            string line2;
            try
            {
                Console.WriteLine("Input your line in Russian: ");       
                line1 = Convert.ToString(Console.ReadLine());
                string RusToTrslt = LineHelper.RussianToTranslit(line1);
                Console.WriteLine("Your line in Translit: {0}", RusToTrslt);
            }
            catch (ArgumentException argex)
            {
                Console.WriteLine($"Error: {argex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            
            Console.WriteLine("**********************************");
            try
            {
                Console.WriteLine("Input your line in Translit: ");      
                line2 = Convert.ToString(Console.ReadLine());
                string TrsltToRus = LineHelper.TranslitToRussian(line2);
                Console.WriteLine("Your line in Russian: {0}", TrsltToRus);
            }
            catch (ArgumentException argex)
            {
                Console.WriteLine($"Error: {argex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
