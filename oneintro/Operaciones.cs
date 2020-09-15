using System;  // Usando una Libreria genérica

namespace oneintro  // Espacio de nombre (carpeta del proyecto)
{
    class Operaciones  // El archvo donde estoy codificando alguna funcionalidad específica
    {
        // Atributos (propiedades)
        public                   int                numeroUno                  { get; set; }
        //Modificador de acceso  tipo de variable   nombrePropiedad(attr)      Metodos para recibir (set) y para entregar (get) el valor de la propiedad
        public int numeroDos { get; set; }

        // Metodos (funciones)
       /* public         void          nuestraSuma(int n1, int n2)
        {
        // Mod acc   tipo retorno   Nombre del método  (args o parametros)
        int suma = n1 + n2;
        Console.WriteLine($"La suma de {n1} y {n2} es {suma} ");
        }*/

        //Separar respónsabilidades en los metodos
        public int calcularSuma(int n1, int n2)
        {
          int resultadoSuma = 0;

          resultadoSuma = n1 + n2;  

          return resultadoSuma;
        
        }

        public void imprimirSuma(){
            Console.WriteLine("La suma es " + calcularSuma(numeroUno, numeroDos));
        }
    }

}    