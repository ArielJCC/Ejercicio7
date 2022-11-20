/*Escribir un programa que lea tres números e indique el tipo de triángulo que forman 
(isósceles, equilatero, escaleno). Permitir que se pueda repetir indefinidamente si el usuario lo desea 
(que el ordenador pregunte ¿Quiere continuar? y la persona pueda responder S ó N) */

internal class Program
{
    private static void Main(string[] args)
    {
        int num1; int num2; int num3;
        string salir = "S";

        do
        {
        Console.WriteLine("Digite el primer número");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite el segundo número");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite el tercer número");
        num3 = int.Parse(Console.ReadLine());

         if(num1 == num2 && num1 == num3)
        {
            Console.WriteLine("El triángulo es equilatero");
        }
        else
        {
            if(num1 == num2 || num1 == num3 || num3 == num2)
            Console.WriteLine("El triángulo es isósceles");
            else
            {
                 if(num1 != num2 || num2 != num3 || num3 != num1)
                    Console.WriteLine("El triángulo es escaleno");

            }
        }
        Console.WriteLine("¿Quiere continuar?"+" S = Si "+" N = No");
        salir = Console.ReadLine();
        Console.WriteLine("Finalizado");  

        }while(salir != "N");    
    }
}