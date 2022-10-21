/*
    Napisz program, który wpisze największą z 3 podanych licz, użyj instrukcji if
*/

using System;

int a;
int b;
int c;

Console.WriteLine("Podaj liczbę");
a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Podaj liczbę");
b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Podaj liczbę");
c = int.Parse(Console.ReadLine()!);

if (a > b && a > c)
    Console.WriteLine($"największe jest a");
if (b > a && b > c)
    Console.WriteLine($"największe jest b");
else
    Console.WriteLine($"największe jest c");