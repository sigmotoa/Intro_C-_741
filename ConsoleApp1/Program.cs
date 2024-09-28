// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, Escribe tu nombre!");
String name; //Declaracion
name = Console.ReadLine(); //Asignacion
Console.WriteLine("Hola y Bienvenido " + name + " no olvides que C# es divertido");
Console.WriteLine("Ingresa tu año de nacimiento");
int actual = 2024; //Declaración y Asignación
int nacimiento = Convert.ToInt16(Console.ReadLine());
//Console.WriteLine(2024-nacimiento+" años es lo que tienes ");


//Variables
//Esto no lo va a leer el compilador
//

///////Tipos de variables
/*
 * int
 * double
 * char
 * boolean
 * float
 * long
 * byte
 * String
 *
 *
 * Ejercicios
 *
 * Sumar 2 numeros
 * Sumar 3 numeros
 * Multiplicar 2 numeros
 * Multiplicar 3 numeros
 * Mostrar la edad con la fecha de nacimiento
 * Mostrar cuantos días faltan para cumplir años
 *
 */

//Decisiones/Bifurcaciones -> IF
int edad;
edad = actual - nacimiento;
/*
if (edad > 18)
{
    Console.WriteLine("Puede entrar al sitio de mayores");

}
else
{
    if (edad >= 15)
    {
        Console.WriteLine("Puede entrar si trae un amigo de 18");
    }
    else
    {
        Console.WriteLine("No entra");
    }
}

//Switch Case

switch (edad)
{
    case (16|17):
        Console.WriteLine("Traiga un amigo mayor");
        break;

    case 18:
        Console.WriteLine("Bienvenido");
        break;

    default:
        if (edad>18)
        {
            Console.WriteLine("Super bienvenido");
        }
        else
        {
            Console.WriteLine("Para afuera");
        }
        break;

}

*/

//Ejercicios
/*
 *Usar el MOD -> %
 *
 * Validador de numero par
 * Validador de multiplo de tres
 * Validador de multiplo de 5
 *
 * Validador multiplo de 7
 * Mostrar los dias de nacido
 *
 * Piedra papel tijera
 *
 *
 * Switch
 * Recibir fecha nacimiento entregar signo zodiaco
 *
 * Recibir fecha nacimiento y mostrar la generación a la que pertenece
 *
 *

//Ciclos o Iteraciones

//Repetir/Mientras/Para
//Mientras->While

while (edad<18)
{
    //edad -> variable de control o de iteracion
    Console.WriteLine("=========="+actual+"==========");
    Console.WriteLine(name+" Aún no puede entrar");
    Console.WriteLine("Venga el otro año");
    Console.ReadLine();
    Console.ReadLine();
    actual++; //actual = actual+1
    edad = actual - nacimiento;

}

Console.WriteLine("Bienvenido es el año: "+actual);


//Otro while

double control = 0;
var rand = new Random();
while (control < 4.2)
{
    Console.WriteLine("===============");
    Console.WriteLine(control);
    control = rand.NextDouble()*5;
    Console.WriteLine("===============");
    Console.WriteLine();
}

//Pedir al usuario por teclado
//ingresar letras hasta que pulse la "h"

String letra = "";
while (letra != "h")
{
    Console.WriteLine("----------");
    Console.WriteLine("Pulse una letra");
    letra = Console.ReadLine();
}
*/
//Ejercicios Ciclos While
//Mostrar numeros en pantalla que
//sean divisibles por 3 desde 0 hasta n -> usuario
//Mostrar la tabla de multiplicar para el numero por el usuario
//Mostrar el factorial de un numero ingresado por el usuario
//Pedir las notas de los estudiantes y mostrar el promedio