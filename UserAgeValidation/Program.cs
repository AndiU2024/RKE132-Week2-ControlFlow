﻿// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal sisestada tema vanus
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
//"You are too young to use this"
//muul juhul konsoolis kuvatakse "Welcome to Instagram"

Console.WriteLine("Enter your age");

int userAge = Int32.Parse(Console.ReadLine());

if (userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}
else
{
    Console.WriteLine("Your are too young to use Instagram!");
}
