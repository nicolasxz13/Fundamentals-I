Console.WriteLine("#Desde el 1 - 255");

for (int i = 1; i <= 255; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("#Desde el 1 - 100");
Console.WriteLine("Se pueden divir por 3 y 5");
for (int i = 1; i <= 100; i++)
{
    if ((i % 3) == 0)
    {
        Console.WriteLine("Se puede dividir por 3 " + i);
    }
    else if ((i % 5) == 0)
    {
        Console.WriteLine("Se puede dividir por 5 " + i);
    }
}

Console.WriteLine("#Desde el 1 - 100");
Console.WriteLine("Se pueden dividir por 3 y 5");
Console.WriteLine("Division 3 = Fizz - Divisiones 5 = Buzz");

for (int i = 1; i <= 100; i++)
{
    if ((i % 3) == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if ((i % 5) == 0)
    {
        Console.WriteLine("Buzz");
    }
}

Console.WriteLine("\nFuncion con While -_-\n");

int value = 1;

while (value != 100)
{
    if ((value % 3) == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if ((value % 5) == 0)
    {
        Console.WriteLine("Buzz");
    }
    value++;
}