using System;

namespace Frase_palindroma_usando_Pilas_estaticas__LIFO_
{
    class Pila
    {
        char[] arreglo;
        int cantidad = 0;
        public Pila(int longitud = 0)
        {
            arreglo = new char[longitud];
        }
        public bool Empty()
        {
            bool band = false;
            if (cantidad == 0)
                band = true;
            return band;
        }
        public void Print()
        {
            for (int i = 0; i <cantidad ; i++)
                Console.WriteLine($"[ {arreglo[i]} ] ");
        }
        public bool Push(char dato)
        {
            bool band = false;
            if (cantidad < arreglo.Length)
            {
                arreglo[cantidad] = dato;
                cantidad++;
                band = true;
            }
            return band;
        }

        public char Pop()
        {
            char retorno = arreglo[cantidad-1];
            for (int i = cantidad; i < cantidad; i++)
                arreglo[i] = arreglo[i+1];
            cantidad--;
            return retorno;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string frase="",oracion;
            Console.Write("Ingrese frase : ");oracion = Console.ReadLine();
            for(int i = 0;i < oracion.Length; i++)
            {
                if (oracion[i] != ' ')
                    frase += oracion[i];
            }
            Pila pila1 = new Pila(frase.Length);
            Pila pila2 = new Pila(frase.Length);
            
            for(int i = 0;i < frase.Length; i++)
                pila1.Push(frase[i]);

            for (int i = frase.Length - 1; i >= 0; i--)
                pila2.Push(frase[i]);
            
            bool band = false;
            while (!pila1.Empty() && !pila2.Empty())
            {
                if (pila1.Pop() != pila2.Pop())
                    band = true;
            }

            if (band .Equals(false))
                Console.WriteLine("Palidromo");
            else
                Console.WriteLine("no es Palidromo");

            Console.ReadKey();
        }
    }
}
