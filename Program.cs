decimal vlSaque, vlRestante;
int n200, n100, n50, n20, n10, n5, n2, n1;

Console.Clear();

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(@" *------- Caixa Eletrônico -------*");
Console.ResetColor();

Console.Write("\nDigite o valor que será sacado (R$): ");
vlSaque = Convert.ToDecimal(Console.ReadLine());

if (vlSaque <= 0)
    {

        Console.Write("\nO valor ");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write($"{vlSaque}");
        Console.ResetColor();
        Console.Write(" não pode ser sacado  ");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(";(\n");
        Console.ResetColor();
        return;
        
     
    }

if (vlSaque % 1 > 0)
    {

        Console.Write("\nEste caixa não trabalha com moedas ");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(";(\n");
        Console.ResetColor();
        return;
    }

vlRestante = vlSaque;

n200 = (int)(vlRestante / 200);
vlRestante = vlRestante % 200;

n100 = (int)(vlRestante / 100);
vlRestante = vlRestante % 100;

n50 = (int)(vlRestante / 50);
vlRestante = vlRestante % 50;

n20 = (int)(vlRestante / 20);
vlRestante = vlRestante % 20;

n10 = (int)(vlRestante / 10);
vlRestante = vlRestante % 10;

n5 = (int)(vlRestante / 5);
vlRestante = vlRestante % 5;

n2 = (int)(vlRestante / 2);
vlRestante = vlRestante % 2;

n1 = (int)(vlRestante / 1);
vlRestante = vlRestante % 1;

Console.WriteLine("\n========================");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@" O caixa deve entregar:");
Console.ResetColor();
Console.WriteLine("========================\n");


if (n200 > 0) Console.WriteLine($"{n200} nota(s) de R$200,00");

if (n100 > 0) Console.WriteLine($"{n100} nota(s) de R$100,00");

if (n50 > 0) Console.WriteLine($"{n50} nota(s) de R$50,00");

if (n20 > 0) Console.WriteLine($"{n20} nota(s) de R$20,00");

if (n10 > 0) Console.WriteLine($"{n10} nota(s) de R$10,00");

if (n5 > 0) Console.WriteLine($"{n5} nota(s) de R$5,00");

if (n2 > 0) Console.WriteLine($"{n2} nota(s) de R$2,00");

if (n1 > 0) Console.WriteLine($"{n1} nota(s) de R$1,00");

Console.WriteLine();

