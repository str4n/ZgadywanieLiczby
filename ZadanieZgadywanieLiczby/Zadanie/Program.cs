using System;

namespace Zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correctAnswer = false;
            int correctNumber = new Random().Next(1, 11);

          
            Console.WriteLine("Zgadnij wylosowaną liczbę z przedziału od 1 do 10.");          

            do
            {
                bool isNumber = int.TryParse(Console.ReadLine(), out int userInput);

                if (!isNumber)
                {
                    ColorMessage(ConsoleColor.DarkRed, "Proszę wprowadzić liczbę.");
                    continue;
                }

                if (userInput < 1 || userInput > 10)
                {
                    ColorMessage(ConsoleColor.DarkRed, "Proszę wprowadzić liczbę od 1 do 10.");
                    continue;
                }

                if (userInput < correctNumber)
                {
                    ColorMessage(ConsoleColor.DarkRed, "Wylosowana liczba jest większa");
                }
                else if (userInput > correctNumber)
                {
                    ColorMessage(ConsoleColor.DarkRed, "Wylosowania liczba jest mniejsza");
                }
                else
                {
                    ColorMessage(ConsoleColor.Green, "Prawidłowa liczba");
                    correctAnswer = true;
                }

            } while (!correctAnswer);
        }

        static void ColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}