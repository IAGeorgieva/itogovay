//Задача: Написать программу, которая из имеющегося массива строк формирует 
//новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
//выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.
//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

using System;
using static System.Console;
Clear();


string[] main = { "Hello", "2", "world", ":-)", "hel", "win", "123" };

PrintArray(main);

void PrintArray(string[] main)
{
    int size = 0;
    int count = 0;

    for (int i = 0; i < main.Length; i++) 
    { 
        if (main[i].Length < 4) {size++;}
    }

string[] otvet = new string[size];

for (int i = 0; i < main.Length; i++)
    { 
    if (main[i].Length < 4) 
        {
        otvet[count] = main[i];
        count++;
        }
    }

for (int i = 0; i < otvet.Length; i++) {Console.WriteLine(otvet[i]);}
}