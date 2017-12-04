using System;

class GenerateNumber
{
    static void Main()
    {
        Console.WriteLine("Please input number between 1 and 100");
        var number = 0;
        var counter = 0;
        Random rndNum = new Random();
        var randomNumber = rndNum.Next(0, 101);
        do
        {
            number = int.Parse(Console.ReadLine());
            counter++;
            if (number > randomNumber)
            {
                Console.WriteLine("Down");
            }
            else if (number < randomNumber)
            {
                Console.WriteLine("Up");
            }
            else if (number == randomNumber)
            {
                Console.WriteLine("You win from {0}th try!", counter);
            }
        } while (number != randomNumber);
    }
}