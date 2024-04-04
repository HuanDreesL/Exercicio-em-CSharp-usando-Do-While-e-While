double salario;
double soma = 1;

do
{
    Console.Write("Digite o Salário: ");
    salario = Convert.ToDouble(Console.ReadLine());
    soma += salario;

} while(salario > 0);

Console.WriteLine($"A soma dos salarios é R${soma:f2}");
