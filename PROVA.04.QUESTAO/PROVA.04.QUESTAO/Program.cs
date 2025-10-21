// See https://aka.ms/new-console-template for more information

// PROVA 4º QUESTÃO//

using System.ComponentModel.Design;

int x = 5;
int y = 10;
string resultado = "Início";

    if (x++ > 5 && y < 15)
    {
        resultado = "A";
    Console.WriteLine($"x={x}, y={y}, Resultado={resultado}");
    }
    else if (x < 7 || y-- == 10)
        {
            resultado = "B";
    Console.WriteLine($"x={x}, y={y}, Resultado={resultado}");
    }
    else
        {
            resultado = "C";
    Console.WriteLine($"x={x}, y={y}, Resultado={resultado}");
    }
