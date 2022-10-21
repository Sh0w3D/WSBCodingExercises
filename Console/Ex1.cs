/// <summary>
/// Napisz program, który poprosi użytkownika o podanie
/// imienia i wypisze "Witaj imię"
/// </summary>
using System;

Console.WriteLine("Podaj imię");

var name = Console.ReadLine();

Console.WriteLine($"Witaj {name}");