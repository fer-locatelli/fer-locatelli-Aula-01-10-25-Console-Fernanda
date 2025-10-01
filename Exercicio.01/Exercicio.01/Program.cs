// See https://aka.ms/new-console-template for more information

int quantidade = 0;
Console.Write("Digite a quantidade de notas que deseja incluir: ");
quantidade = int.Parse(Console.ReadLine());

double[] notas = new double[quantidade];
double soma = 0;

for (int i = 0; i < quantidade; i++)
{
    Console.Write($"Digite a {i + 1}ª nota: ");
    notas[i] = double.Parse(Console.ReadLine());
    soma += notas[i]; // LEMBRAR DE USAR QUANDO PRECISAR ACUMULAR VALORES
}

double media = soma / quantidade;

// Resultado
Console.WriteLine("******************************** ");
Console.WriteLine($"A média do aluno é {media:F2}. ");
Console.WriteLine("******************************** ");