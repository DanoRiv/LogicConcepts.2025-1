﻿var numberString = string.Empty;
do
{
    Console.Write("Ingrese un número entero o 'Salir' para salir: ");
    numberString = Console.ReadLine();
    if(numberString!.ToLower() == "salir")
    {
        continue;
    }
    var numberInt = 0;
    if (int.TryParse(numberString, out numberInt))
    {
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"El número {numberInt} es par");
        }
        else
        {
            Console.WriteLine($"El número {numberInt} es impar");
        }
    }
    else
    {
        Console.WriteLine($"El valor ingresado {numberInt} no es un número entero");
    }
} while (numberString!.ToLower() != "salir");
Console.WriteLine("Fin del programa");