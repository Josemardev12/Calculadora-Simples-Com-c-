using System.Globalization;

int valor_1 = 10;
int valor_2 = 10;

Console.WriteLine(" 1-soma / 2-mutiplicacao / 3-divisao / 4-subtracao ");
Console.WriteLine(valor_1);
Console.WriteLine(valor_2);


long calcu = int.Parse(Console.ReadLine());

if (calcu == 1)
{
    int resultado = (valor_1 + valor_2);
    Console.Write(resultado);
}
else if (calcu == 2)
{
    int resultado = (valor_1 * valor_2);
    Console.Write(resultado);
}
else if (calcu == 3)
{
    int resultado = (valor_1 / valor_2);
    Console.Write(resultado);
    
}
else if (calcu == 4)
{
    int resultado = (valor_1 - valor_2);
    Console.Write(resultado);
}