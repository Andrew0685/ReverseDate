using System;

namespace ReverseDate
{
    class Program
    {
        static void Main(string[] args)
        {
            string personFirstName = "Иван Андреевич";
            string personSecondName = "Наталья Александровна";
            string template;

            Console.WriteLine("Сведения до замены:\n personFirstName - {0},\n personSecondName - {1}", personFirstName, personSecondName);
            template = personFirstName;
            personFirstName = personSecondName;
            personSecondName = template;
            Console.WriteLine("Сведения после замены:\n personFirstName - {0},\n personSecondName - {1}", personFirstName, personSecondName);
            Console.ReadKey();
        }
    }
}
