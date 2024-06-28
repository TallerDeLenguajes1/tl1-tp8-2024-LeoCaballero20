﻿using EspacioCalculadora;

Calculadora miCalculadora = new Calculadora();
bool encendida = true;
Console.WriteLine("\nBienvenido a la calculadora\n");
Console.WriteLine("Inserte un número inicial para operar: ");
string numInicialIngresado = Console.ReadLine();
Double.TryParse(numInicialIngresado, out double numInicial);
miCalculadora.Sumar(numInicial);
double operacion;
do {
do {
Console.WriteLine("\nInserte el número de la operación deseada\n");
Console.WriteLine("1.Sumar");
Console.WriteLine("2.Restar");
Console.WriteLine("3.Multiplicar");
Console.WriteLine("4.Dividir");
Console.WriteLine("5.Limpiar");
Console.WriteLine("6.Salir\n");
string operacionIngresada = Console.ReadLine();
Double.TryParse(operacionIngresada, out operacion);
} while (operacion < 1 || operacion > 7);
switch (operacion) {
    case 1: Console.WriteLine("\nIngrese un número para sumar:");
            string numSumar = Console.ReadLine();
            if (Double.TryParse(numSumar, out double numS)) {
                miCalculadora.Sumar(numS);
                Console.WriteLine("Resultado: " + miCalculadora.Resultado);
            } else {
                Console.WriteLine("Número inválido");
            }
    break;
    case 2: Console.WriteLine("\nIngrese un número para restar:");
            string numRestar = Console.ReadLine();
            if (Double.TryParse(numRestar, out double numR)) {
                miCalculadora.Restar(numR);
                Console.WriteLine("Resultado: " + miCalculadora.Resultado);
            } else {
                Console.WriteLine("Número inválido");
            }
    break;
    case 3: Console.WriteLine("\nIngrese un número para multiplicar:");
            string numMult = Console.ReadLine();
            if (Double.TryParse(numMult, out double numM)) {
                miCalculadora.Multiplicar(numM);
                Console.WriteLine("Resultado: " + miCalculadora.Resultado);
            } else {
                Console.WriteLine("Número inválido");
            }
    break;
    case 4: Console.WriteLine("\nIngrese un número para dividir:");
            string numDiv = Console.ReadLine();
            if (Double.TryParse(numDiv, out double numD)) {
                miCalculadora.Dividir(numD);
                Console.WriteLine("Resultado: " + miCalculadora.Resultado);
            } else {
                Console.WriteLine("Número inválido");
            }
    break;
    case 5: miCalculadora.Limpiar();
            Console.WriteLine("Inserte un número inicial para operar: ");
            string numInicialIngresado2 = Console.ReadLine();
            Double.TryParse(numInicialIngresado2, out double numInicial2);
            miCalculadora.Sumar(numInicial2);
    break;
    case 6: encendida = false;
    break;
}
} while (encendida==true);
Console.WriteLine("\nHasta la próxima!\n");