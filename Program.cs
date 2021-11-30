using System;

namespace MetodosDemo
{
    class Program
    {
        static string nombre = "Katty";

        static void Main(string[] args)
        {

           

            /*  
            int cociente = 0;
            int residuo = 0;
            Console.WriteLine("¡HOLA MUNDO!");
            //forma 1 de llamar los datos de la tupla
            (cociente, residuo) =  Division(100, 2);
            Console.WriteLine($"Cociente:{cociente} \n Reciduo:{residuo}");

            (cociente, residuo) =  Division(2, 200);
            Console.WriteLine($"Cociente:{cociente} \n Reciduo:{residuo}");

            //forma 2
            (int cocientef2, int residuof2) data = Division(88, 7);
            Console.WriteLine($"Cociente:{data.cocientef2} \n Reciduo:{data.residuof2}");
            */
        }

        static int Multiplicar(int numero1, int numero2) 
        {
            return numero1 + numero2;
        }

        static double Multiplicar(double numero1, double numero2) 
        {
            return numero1 + numero2;
        }

        

        static void Saludar() => Console.WriteLine(nombre);

        static (int, int) Division(int num1, int num2)
        {
            int divisor = 0;
            int dividendo = 0;
            int cociente = 0;
            int residuo = 0;
            (dividendo, divisor) =  OrdenarNumeroAcendente(num1, num2);
            cociente = dividendo / divisor;
            residuo = dividendo % divisor;
            return (cociente,residuo);
        }

        static (int, int) OrdenarNumeroAcendente(int num1, int num2)
        {
            if (num1 > num2)
            {
                return (num1, num2);
            }
            else if(num1 < num2)
            {
                return (num2, num1);
            }
            return (num1, num2);
        }

       

        /*
        static void Saludar(string nombre)
        {
            Console.WriteLine("Hola" + nombre);
            BorrarConsola();
        }

        // Tipo de dato a retornar + nombre del metodo(que el nombre ejemplicique una accion) + parametro
        static void BorrarConsola ()
        {
            Console.ReadLine();
            Console.Clear();
            Console.Beep();
        }
        */
    }
}

