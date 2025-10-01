// See https://aka.ms/new-console-template for more information

// EXEMPLO QUADRO - FRACALOSSI //

int quantidade = 0;
Console.WriteLine("Digite a quantidade de pessoas que deseja incluir: ");
quantidade = int.Parse(Console.ReadLine());
string[] nomes = new string[quantidade];

for(int i=0; i < nomes.Length; i++)
{
    Console.WriteLine($"Digite o {i + 1}° Nome: ");
    nomes[i] = Console.ReadLine();
}

Console.WriteLine("Nomes incluidos no vetor NOMES[] ");
Console.WriteLine("******************************** ");

for (int i=0; i < nomes.Length; i++)
{
    Console.WriteLine($"Posição [{1}] = {nomes[i]} ");
}

Console.WriteLine("******************************** ");