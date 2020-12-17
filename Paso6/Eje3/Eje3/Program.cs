using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eje3
{
    /*
      * Estudiante: Luis David Huertas Redondo
      * Grupo: 17
      * Programa: Ingenieria de sistemas
      * Codigo fuente: Autoria propia
      * Problema Seleccionado: 3
      * Código Fuente: autoría propia
      * Estructuras de control utilizadas: 
      * if, else if, else, foreach
      * Metodos utilizados:
      * Any, Add, Show, Count, Equals, ToString, Checked, Text, Now, Year, Value, Message
     */

    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAccidente());
        }
    }
}
