int numero;
int maior = 0;
int menor = 0;
int contador = 1;

do
{
    Console.WriteLine($"DIGITE O {contador}°: ");
    numero = Convert.ToInt32(Console.ReadLine());

    if (menor == 0) menor = numero; 
  
    if (numero > 0 && numero > maior)
        maior = numero;

    if (numero > 0 && menor > numero)
        menor = numero;

    contador++;
} while (numero > 0);


Console.WriteLine($"Número Maior: {maior}");
Console.WriteLine($"Número Menor: {menor}");
Console.WriteLine($"Quantidade Digitada: {contador - 2}");
