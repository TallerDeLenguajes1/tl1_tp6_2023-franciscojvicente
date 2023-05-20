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

// Punto 2

// string? operacion = "";
// int op1 = 0;
// int op2 = 0;


// Console.WriteLine("Las operaciones son las siguientes: +, -, *, /");
// Console.WriteLine("Que desea realizar? ");
// operacion = Console.ReadLine();

// if (operacion == "+" || operacion == "-" || operacion == "*" || operacion == "/") {
//     Console.WriteLine("Ingrese el numero 1: ");
//     op1 = Console.Read();
//     Console.WriteLine("Ingrese el numero 2: ");
//     op2 = Console.Read();
//     if (operacion == "+")
//     {
//         Console.WriteLine("La suma es: " +(op1+op2));
//     }
// }
float? valor1 = 0; //Aqui se almacenara el primer valor ingresado.
float? valor2 = 10; //Aqui se almacenara el segundo valor ingresado.
float? R = 0; //Aqui se almacenara el resultado de la operacion.
string? resp = "";

do
{
Console.WriteLine("Presione el simbolo para realizar la operacion:");
                Console.WriteLine("+ para sumar");
                Console.WriteLine("- para restar");
                Console.WriteLine("* para multiplicar");
                Console.WriteLine("/ para dividir");
                Console.WriteLine("C para elevar al cuadrado");
                Console.Write("Eliga Una Opcion: "); //Aqui es donde indicaremos que operacion vamos a realizar
                resp = Console.ReadLine();
                string eleccion = Convert.ToString(resp);
                //Aqui se agregaran los mensajes para poder ingresar los datos.
                Console.WriteLine("Ingrese sus dos numerosn");
                Console.Write("Valor 1: ");
                valor1 = float.Parse(Console.ReadLine());
                Console.Write("Valor 2: ");
                valor2 = float.Parse(Console.ReadLine()); // pasa a entero lo que se ingrese como string
                Console.WriteLine();
 
                switch (eleccion)
                {
                    case "+":
                        Console.WriteLine("El resultado de la suma es:");
                        R = valor1 + valor2;
                       Console.WriteLine("{0} + {1} = {2}", valor1, valor2, R);
                        break;
                    case "-":
                        Console.WriteLine("El resultado de la resta es:");
                        R = valor1 - valor2;
                        Console.WriteLine("{0} - {1} = {2}", valor1, valor2, R);
                        break;
                    case "*":
                        Console.WriteLine("El resultado de la multiplicacion es:");
                        R = valor1 * valor2;
                        Console.WriteLine("{0} * {1} = {2}", valor1, valor2, R);
                        break;
                    case "/":
                        Console.WriteLine("El resultado de la division es:");
                        R = valor1 / valor2;
                        Console.WriteLine("{0} / {1} = {2}", valor1, valor2, R);
                        break;
                }
                Console.Write("¿Desea Continuar? si/no: "); //Si para realizarlo de nuevo y no para salir.
                resp = Console.ReadLine();
    
} while (resp == "si");










