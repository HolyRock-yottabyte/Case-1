using System;
namespace Case1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden ondalıklı sayı (double) girişi
            Console.Write("Ondalıklı bir sayı girin: ");
            string doubleInput = Console.ReadLine();
            double doubleValue = Convert.ToDouble(doubleInput);
            Console.WriteLine("Girdiğiniz ondalıklı sayı: " + doubleValue);

            // Klavyeden tam sayı girişi
            Console.Write("Bir tam sayı girin: ");
            string intInput = Console.ReadLine();
            int intValue = Convert.ToInt32(intInput);
            Console.WriteLine("Girdiğiniz tam sayı: " + intValue);

            // Klavyeden string girişi
            Console.Write("Bir metin girin: ");
            string stringInput = Console.ReadLine();
            Console.WriteLine("Girdiğiniz metin: " + stringInput);

            // Klavyeden ilk karakter (char) girişi
            Console.Write("İlk karakteri girin: ");
            char charInput1 = Console.ReadKey().KeyChar;
            Console.WriteLine("\nGirdiğiniz ilk karakter: " + charInput1);

            // Klavyeden ikinci karakter (char) girişi
            Console.Write("İkinci karakteri girin: ");
            char charInput2 = Console.ReadKey().KeyChar;
            Console.WriteLine("\nGirdiğiniz ikinci karakter: " + charInput2);

            // Klavyeden ondalıklı sayı ve tam sayı işlemleri
            double result = doubleValue * intValue;
            Console.WriteLine("Ondalıklı sayı ile tam sayının çarpımı: " + result);

        }
    }

}
    