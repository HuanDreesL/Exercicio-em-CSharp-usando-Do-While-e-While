int resultado = 0;

Console.WriteLine("Multiplicando: ");
int multiplicando = int.Parse(Console.ReadLine());
Console.WriteLine("Multiplicador: ");
int multiplicador = int.Parse(Console.ReadLine());
int contador = 0;
if(multiplicando > multiplicador)
{
    while (contador < multiplicador)
    {
        resultado = resultado + multiplicando;
        contador = contador + 1;
        Console.WriteLine($"{contador} vezes(s)");
    }
}
else
{
    while (contador >= 1)
    {
        resultado = resultado + multiplicando;
        contador = contador + 1;
        Console.WriteLine($"{contador} veze(s)");
    }
}
Console.WriteLine($"{multiplicando} x {multiplicador} x {resultado}");

