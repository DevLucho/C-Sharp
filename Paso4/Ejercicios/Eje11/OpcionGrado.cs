using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje11
{
    class OpcionGrado
    {
        string[] opcion1; // opciones de grado 75% aprobado
        string[] opcion2; // opciones de grado 90% aprobado
        string[,] carreras; // carreras | cantidad de creditos
        double porcentaje;
        int numCreditos;
        int opCarrera;
        public OpcionGrado()
        {
            this.numCreditos = 0;
            this.porcentaje = 0.0;
            this.opcion1 = new string[] { "Proyecto aplicado", "Proyecto de investigación", "Monografía" };
            this.opcion2 = new string[] { "Diplomado de profundización", "Créditos de posgrado" };
            this.carreras = new string[,]
            {
                { "Ing. De sistemas","149" },
                { "Ing. Electrónica", "170"},
                { "Ing. De Telecomunicaciones"," 158"},
                { "Ing. Industrial", "160" },
                { "Ing. Multimedia","152" }
            };
        }

        public void CalcularPorcentaje(int numCreditos, int opcCarrera)
        {
            if (opcCarrera >= 1 && opcCarrera <= 5)
            {
                this.porcentaje = ((numCreditos * 100) / double.Parse(this.carreras[opcCarrera - 1, 1])); // (creditos aprobados * 100) / creditos carrera escogida
            }
        }
        // Imprime las opciones de grado segun el porcentaje
        public void MostrarOpciones()
        {
            Console.WriteLine($"\nCarrera seleccionada: {this.carreras[opCarrera - 1, 0]}");
            Console.WriteLine($"El porcentaje teniendo en cuenta el número de c. aprobados ({this.numCreditos} de {this.carreras[opCarrera - 1, 1]} posibles) es: {this.porcentaje} %");
            if (this.porcentaje >= 75 && this.porcentaje <= 100)
            {
                Console.WriteLine("Por lo tanto tus opciones de grado son las siguientes:\n");
                for (int i = 0; i < this.opcion1.Length; i++) Console.WriteLine("-> " + this.opcion1[i]); // Recorre y imprime array con opciones de grado. 75% aprobado 
                if (this.porcentaje >= 90 && this.porcentaje <= 100)
                {
                    for (int i = 0; i < this.opcion2.Length; i++)
                    {
                        Console.WriteLine("-> " + this.opcion2[i]); // Recorre y imprime array con opciones de grado. 90% aprobado
                    }
                }
            }
            else Console.WriteLine("Por lo tanto aún no puede optar por una opción de grado.");
        }
        // Imprime carreras con sus respectivos creditos
        public void MostrarCarreras()
        {
            Console.WriteLine();
            for (int i = 0; i < this.carreras.GetLength(0); i++) // Recorre matriz
            {
                Console.WriteLine($"{i + 1}. " + this.carreras[i, 0] + " - Cantidad creditos: " + this.carreras[i, 1]);
            }
        }

        public void PedirDatos()
        {
            Console.WriteLine("\nSelecciona la carrera. (1, 2, 3, 4 o 5)");
            bool error; // validacion para que cuando se capture una excepcion no se frene la aplicacion
            do
            {
                error = false;
                try
                {
                    OpCarrera = int.Parse(Console.ReadLine());
                    if (OpCarrera < 1 || OpCarrera > 5) Console.WriteLine("El número digitado no se especifica en el menú de opciones."); 
                }
                catch (Exception ex)
                {
                    error = true;
                    Console.WriteLine(ex.Message + "Selecciona una opción del menú");
                }

            } while (OpCarrera < 1 || OpCarrera > 5 || error); // valida que no se escogan otros numeros a partes del menu de opciones.
            Console.WriteLine("\nIngresa la cantidad de creditos aprobados.");

            do
            {
                error = false;
                try
                {
                    NumCreditos = int.Parse(Console.ReadLine());
                    if (NumCreditos < 0 || NumCreditos > int.Parse(this.carreras[OpCarrera - 1, 1]))
                    Console.WriteLine($"Error. La cantidad de creditos debe estar entre 0 y {int.Parse(this.carreras[OpCarrera - 1, 1])}"); 
                }
                catch (Exception ex)
                {
                    error = true;
                    Console.WriteLine(ex.Message);
                }

            } while (NumCreditos < 0 || NumCreditos > int.Parse(this.carreras[OpCarrera - 1, 1]) || error); // Valida que los creditos no excedan los de la carrera escogida.
        }

        public int NumCreditos { get => numCreditos; set => numCreditos = value; }
        public int OpCarrera { get => opCarrera; set => opCarrera = value; }
    }
}
