// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

float intNum1 = 0;

bool anda = false;

string? num1 = "";

while (!anda)
{
    Console.WriteLine("Ingrese un número válido");
    num1 = Console.ReadLine();
    anda = float.TryParse(num1, out intNum1);
    if (!anda)
    {
        Console.WriteLine(num1 + " no es un n° válido.");
    }
}

char[] array =  num1.ToCharArray();

Array.Reverse(array);

string n = new string(array);

Console.WriteLine("el numero invertido es " + n);



