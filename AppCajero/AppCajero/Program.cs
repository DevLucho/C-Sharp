using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCajero
{
    /*
     * Autor: Luis David Huertas Redondo
     * 
      * El ejercicio consiste en simular la función de un cajero automático en 
      * donde el cliente debe autenticarse ante el sistema para que le permita 
      * realizar cualquier tipo de operación.
      * Las operaciones disponibles en el cajero corresponden a: 
      * Consulta de saldo.
      * Retiros, solo si el saldo es mayor a la cantidad solicitada y si no supera 
      * el tope diario de retiros establecidos por el banco. 
      * Es decir que no podrá retirar más de dos millones de pesos diarios.
      * Transferencias entre cuentas del mismo banco, para ello debe validar si existe la cuenta destino.
      * Consulta de puntos ViveColombia
      * Canje de puntos ViveColombia
      * 
      * Se debe diseñar bajo el paradigma de la Programación Orientada a 
      * Objetos utilizando métodos, herencia y excepciones en un lenguaje de 
      * Programación Orientada a Objetos.
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
            Application.Run(new FormLogin());
        }
    }
}
