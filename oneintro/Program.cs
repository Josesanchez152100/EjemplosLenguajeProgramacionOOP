using System;  // Usando una Libreria genérica

namespace oneintro  // Espacio de nombre (carpeta del proyecto)
{
    class Program  // El archvo donde estoy codificando alguna funcionalidad específica
    {
        // Atributos (propiedades)
        // Color, marca, placa, modelo, etc

        // Metodos (funciones)
        // Arrancar, Acelerar, frenar, etc
        static void Main(string[] args) // Un método
        {
            Console.WriteLine("Hola a todos, como van pues!"); // instrucciones, pasos, tareas, actividades, etc

            Console.WriteLine("Número uno");

            int numUno = int.Parse(Console.ReadLine());

            Console.WriteLine("Número dos");

            int numDos = int.Parse(Console.ReadLine());

           /* Forma estructurada    

            Console.WriteLine("El número es: " + numUno);
            Console.WriteLine($"El número es: {numUno}");

            //int suma = numUno + numDos;

            //Console.WriteLine($"La suma de {numUno} y {numDos} es {suma} ");
            Console.WriteLine($"La suma de {numUno} y {numDos} es {numUno + numDos} ");
            */

            //Forma Orientada a Obejetos
            //Instanciar la class Operaciones
            //Class     Obejto(instancia) (=new)palabras reservadas  constructor
            var myOperacion = new Operaciones(){
                numeroUno = numUno,
                numeroDos = numDos                
            };
            
            //verificar el valor que tiene almacenado
            //Console.WriteLine(myOperacion.numeroUno);

            //Llevar el valor como parametro a un metodo
            //Para hacer esto llamar el metodo de la class
            //mediante su instancia (un objeto)

            //myOperacion.nuestraSuma(myOperacion.numeroUno, myOperacion.numeroDos);
            myOperacion.imprimirSuma();


        }
    }
}
