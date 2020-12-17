using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*5
 * Estudiante: Luis David Huertas Redondo
 * Grupo: 17
 * Programa: Ingenieria de sistemas
 * Codigo fuente: Autoria propia
 * 
 * Ejercicio 12 - Paso 4
 * Desarrolle una solución básica de programación que permita
 * determinar si una persona ya puede ingresar a un juego en el parque
 * de diversiones debe recibir como parámetro la altura, peso, edad y
 * género, con base en lo anterior retornar un mensaje indicando si puedo o no ingresar
 * 
 */
namespace Eje12
{
    class Program
    {
        static void Main(string[] args)
        {
            ParqueDiversion pd = new ParqueDiversion();
            pd.PedirDatos();
            if (pd.DeterminaJuego(pd.Altura, pd.Peso, pd.Edad, pd.Genero).Equals("")) Console.WriteLine("\nNo puedes ingresar a ningun parque de diversión.");
            else Console.WriteLine($"\nPuedes ingresar al siguiente parque de diversión: {pd.DeterminaJuego(pd.Altura, pd.Peso, pd.Edad, pd.Genero)}.");
            Console.ReadKey();
        }
    }
}
