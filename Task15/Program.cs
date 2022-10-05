// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

// if (number == 6 || number == 7)
// {
//     Console.WriteLine("да");
// }
// else
//     if (number >= 1 && number <= 5)
// {
//     Console.WriteLine("нет");
// }
// else Console.WriteLine("Нет такого дня недели");

string answer = "Не введены данные";

string WeekendСheck(int num)
{
    if (num == 6 || num == 7)
    {
        answer = "да";
    }
    else
        if (num >= 1 && num <= 5)
        {
         answer = "нет";
        }

    else answer = "Нет такого дня недели";
    return answer;
}

Console.WriteLine(WeekendСheck(number));
