// See https://aka.ms/new-console-template for more information

                      //PROVA 1º QUESTÃO//

class Program
{
    static void Main(string[] args)
    {
        int maior, i;
        int[] vet = new int[5] { 20, 3, 25, 12, 1 };
        maior = vet[0];
        for (i = 1; i < 5; i++)
        {
            if (vet[i] > maior)
            {
                maior = vet[i];
            }
        }
        Console.WriteLine(maior);
    }
}