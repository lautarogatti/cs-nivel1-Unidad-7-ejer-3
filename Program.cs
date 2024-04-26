using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
            CADENA FUENTE: “La mar estaba serena"
            CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            CADENA RESULTADO: “Li mir estibi sereni"*/

            char[] cadena = new char [20];
            char a, b, c;
            int indice = 0;
            Console.WriteLine("Ingrese una oracion ");
            c = char.Parse(Console.ReadLine());

            while(c != '.'){
                cadena[indice] = c;
                indice++;
                c = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingrese que letra quiere sacar ");
            a = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese que letra quiere agregar ");
            b = char.Parse(Console.ReadLine());

            cadena [indice] = '\0';

            for (int i = 0; i < 20; i++)
            {

                if(cadena [i] == a){
                    cadena [i] = b;
                }
            }
            indice = 0;
            while(cadena[indice] != '\0'){
                Console.Write(cadena[indice]);
                indice++;
            }
            Console.Write(" pepino");
            
        }
    }
}
