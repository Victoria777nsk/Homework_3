// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberString = Convert.ToString(number);
int length = numberString.Length;

if (length == 5)
{
    if (numberString [0] == numberString [4] && numberString [1] == numberString [3])
    {
        Console.Write($"Число {number} является палиндромом");
    }
    else 
    {
        Console.Write($"Число {number} НЕ является палиндромом");
    }
}
else
{
    Console.Write($"Ошибка! Число {number} НЕ пятизначное");
}




//   if (number[0]==number[4] || number[1]==number[3]){
//     Console.WriteLine($"Ваше число: {number} - палиндром.");
//   }
//   else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
// }

// if (number!.Length == 5){
//   CheckingNumber(number);
// }
// else Console.WriteLine($"Введи правильное число");