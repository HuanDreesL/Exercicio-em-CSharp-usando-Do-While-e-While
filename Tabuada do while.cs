int multiplica;
do
{
    Console.WriteLine("DIGITE A TABELA");
    multiplica = Convert.ToInt32(Console.ReadLine());
    int contador = 1;

    while (multiplica > 0 && contador <= 10)
    {
        Console.WriteLine($"Tabela {multiplica}x{contador} = {multiplica * contador}");
        contador++;
    }

}while (multiplica > 0);
