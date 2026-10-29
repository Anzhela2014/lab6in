// // // // // // Задание 1.1
// // // // // for (int i = 10; i >= 1; i--) 
// // // // // {
// // // // //     Console.WriteLine(i);
// // // // // }
// // // // // // Задание 1.2
// // // // // for (int i = 1; i <= 50; i++)
// // // // // {
// // // // //     if (i % 2 == 0)
// // // // //     {
// // // // //         Console.WriteLine(i);
// // // // //     }
// // // // // }
// // // // // // Задание 2
// // // // // int s = 0; 
// // // // // int k = 0; 

// // // // // for (int i = 1; i <= 100; i++)
// // // // // {
// // // // //     if (i % 3 == 0)
// // // // //     {
// // // // //         s = s + i;
// // // // //     if (i % 7 == 0)
// // // // //     {
// // // // //         k = k + 1;
// // // // //     }
// // // // // }

// // // // // Console.WriteLine("Сумма кратных 3: " + s);
// // // // // Console.WriteLine("Количество кратных 7: " + k);
// // // // // Задание 4
// // // // bool f = false; 

// // // // for (int i = 1; i <= 3; i++) 
// // // // {
// // // //     Console.Write("Введите пароль: ");
// // // //     string p = Console.ReadLine();

// // // //     if (p == "qwerty")
// // // //     {
// // // //         f = true;
// // // //         Console.WriteLine("Доступ разрешён");
// // // //         break; 
// // // //     }
// // // // }
// // // // if (f == false)
// // // // {
// // // //     Console.WriteLine("Доступ заблокирован");
// // // // }
// // // // Задание 5
// // // Console.Write("Введите число n (от 1 до 9): ");
// // // int n = int.Parse(Console.ReadLine());
// // // for (int i = 1; i <= 10; i++)
// // // {
// // //     int r = n * i; 
// // //     Console.WriteLine(n + " x " + i + " = " + r);
// // // }
// // // Задание 6
// // using System;

// // namespace Lab06
// // {
// //     class Program
// //     {
// //         static void Main(string[] args)
// //         {
// //             // Задание 6
// //             for (int i = 1; i <= 30; i++)
// //             {
// //                 if (i % 3 == 0)
// //                 {
// //                     continue;
// //                 }

// //                 if (i > 20)
// //                 {
// //                     if (i % 10 == 0)
// //                     {
// //                         break;
// //                     }
// //                 }

// //                 Console.WriteLine(i);
// //             }
// //         }
// //     }
// // }
// // Итоговая задача. «Угадай число»
// int sec = 42;
// bool w = false;
// Console.WriteLine("Я загадал число. У тебя 5 попыток угадать его!");
// for (int i = 1; i <= 5; i++)
// {
//     Console.Write("Попытка №" + i + ". Введи число: ");
//     int u = int.Parse(Console.ReadLine());
//     if (u == sec)
//     {
//         Console.WriteLine("Победа! Попыток: " + i);
//         w = true;
//         break;
//     }
//     if (u > sec)
//     {
//         Console.WriteLine("Меньше");
//     }
//     if (u < sec)
//     {
//         Console.WriteLine("Больше");
//     }
// }
// if (w == false)
// {
//     Console.WriteLine("Ты проиграл, число было 42");
// }
// Доп задание
Console.Write("Введите целое число: ");
int n = int.Parse(Console.ReadLine());
int s = 0;
int c = 0;
do
{
    int o = n % 10;
    s = s + o;
    c = c + 1;
    n = n / 10;
} 
while (n > 0);
Console.WriteLine("Сумма цифр: " + s);
Console.WriteLine("Количество цифр: " + c);
