int digitado = 0;
int maximo = 0;
int minimo = 0;

do
{
    Console.WriteLine("Insira um Número: ");
    digitado = Convert.ToInt32(Console.ReadLine());
    if (digitado != 0)
    {
        if(digitado > maximo || maximo == 0)
            maximo = digitado;
        if(digitado < minimo || minimo == 0)
            minimo = digitado;
    }
} while (digitado != 0);
Console.WriteLine($"Maior número {maximo}");
Console.WriteLine($"Menor número {minimo}");
