// See https://aka.ms/new-console-template for more information
// Variables
int option;
double A;
double B;
double resultado;
string mensaje;

//Dibujar menu 
console.WriteLine("****Calculadora****");
console.WriteLine("1. Sumar.");
console.WriteLine("2. Restar.");
console.WriteLine("3. Multiplicar.");
console.WriteLine("4. Dividir.");
console.WriteLine("5. Elevar a la potencia.");
console.WriteLine("Seleccione una opcion (1-5):");

//Guardar variables
option = int.parse(Console.Readline());
//Ahora pedimos los numeros 
Console.WriteLine("Ingrese el primer numero: ");
A = double.Parse(Console.Readline());


Console.WriteLine("Ingrese el segundo numero: ");
B = double.Parse(Console.Readline());


