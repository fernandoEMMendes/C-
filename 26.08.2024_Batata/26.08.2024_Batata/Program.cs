
string[] historico = new string[10];
int indice = 0;

float num1 = 0;
float num2 = 0;
float resultado = 0;

while (true)
{
    Console.Clear();
    Console.WriteLine("\t\t\t\tMenu");
    Console.WriteLine("Digite F1 para fazer soma!");
    Console.WriteLine("Digite F2 para fazer subtração!");
    Console.WriteLine("Digite F3 para fazer multiplicação!");
    Console.WriteLine("Digite F4 para fazer divisão!");

    ConsoleKeyInfo key = Console.ReadKey();
    if (key.Key != ConsoleKey.F1 || key.Key != ConsoleKey.F2|| key.Key != ConsoleKey.F3 || key.Key != ConsoleKey.F4)
    {
        
    }

    Console.Clear();

    Console.WriteLine("Número 1");
    num1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Número 2");
    num2 = float.Parse(Console.ReadLine());


    if (key.Key == ConsoleKey.F1)
    {
        resultado = num1 + num2;
        Console.WriteLine($"{num1} + {num2} = {resultado}");

        Console.WriteLine("Presione qualquer tecla para continuar...");
        Console.ReadKey();

        if (indice < historico.Length)
        {
            historico[indice] = $"{num1} + {num2} = {resultado}";
            indice++;
        }
    }

    if (key.Key == ConsoleKey.F2)
    {
        resultado = num1 - num2;
        Console.WriteLine($"{num1} - {num2} = {resultado}");
        
        Console.WriteLine("Presione qualquer tecla para continuar...");
        Console.ReadKey();

        if (indice < historico.Length)
        {
            historico[indice] = $"{num1} - {num2} = {resultado}";
            indice++;
        }
    }

    if (key.Key == ConsoleKey.F3)
    {
        resultado = num1 * num2;
        Console.WriteLine($"{num1} * {num2} = {resultado}");

        Console.WriteLine("Presione qualquer tecla para continuar...");
        Console.ReadKey();

        if (indice < historico.Length)
        {
            historico[indice] = $"{num1} * {num2} = {resultado}";
            indice++;
        }
    }

    if (key.Key == ConsoleKey.F4)
    {
        resultado = num1 / num2;
        Console.WriteLine($"{num1} / {num2} = {resultado}");

        Console.WriteLine("Presione qualquer tecla para continuar...");
        Console.ReadKey();

        if (indice < historico.Length)
        {
            historico[indice] = $"{num1} / {num2} = {resultado}";
            indice++;
        }
    }
}
