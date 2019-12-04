using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego.src.LibreriasJuego
{
    class Dummy
    {
        public static void Main() {

           // pintarEvaluacion(cuadrado,4);    
        }

        public static int cuadrado (int x)
        {
            return x * x;

        }
        public static void pintarEvaluacion(Func<int,int> funcion,int x) {
            Console.WriteLine("funcion:" + funcion.Method.Name);
            int resultado = funcion(x);
            Console.WriteLine("Resultado:" + resultado);
        }
    }
}
