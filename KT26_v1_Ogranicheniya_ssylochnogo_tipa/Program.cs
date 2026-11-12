using System;

namespace KT26v1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("ReferenceBox<string>");

            ReferenceBox<string> referenceBox = new ReferenceBox<string>();

            Console.WriteLine($"Пустая: {referenceBox.IsEmpty}");

            Console.Write("Введите имя: ");
            string? name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Ошибка: имя не должно быть пустым!");
            }
            else
            {
                referenceBox.Set(name);
                Console.WriteLine($"Пустая: {referenceBox.IsEmpty}");
                Console.WriteLine($"Значение: {referenceBox.Get()}");
            }

            Console.WriteLine("\nValueBox<int>");

            ValueBox<int> valueBox = new ValueBox<int>();

            Console.WriteLine($"Пустая: {valueBox.IsEmpty}");

            Console.Write("Введите целое число: ");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Ошибка: нужно ввести целое число!");
            }
            else
            {
                valueBox.Set(number);
                Console.WriteLine($"Пустая: {valueBox.IsEmpty}");
                Console.WriteLine($"Значение: {valueBox.Get()}");
            }

            Console.WriteLine("\nПроверка ограничений типов");

            Console.WriteLine(
                "Ошибка ReferenceBox<int>: int не является ссылочным типом.");

            Console.WriteLine(
                "Ошибка ValueBox<string>: string не является типом-значением.");

            Console.WriteLine("\nПрограмма завершена.");
        }
    }
}