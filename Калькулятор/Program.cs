// See https://aka.ms/new-console-template for more information
Console.WriteLine("Калькулятор вас приветствует!");
string x ="";
int a = 0; //то что получается
string z = "-";
x = Console.ReadLine();
Int32.TryParse(x, out int c);
x = Console.ReadLine();
Int32.TryParse(x, out int b);
z = Console.ReadLine();
switch (z)
    {
    case "-":
    Console.WriteLine(c,"-",b=a);
        a = c - b;
        break;
    }