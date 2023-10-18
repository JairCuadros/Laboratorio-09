using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Program
    {
        static double cantidadVentaLimpieza = 0;
        static void Main(string[] args)
        {
            Inicio();
            Console.ReadKey();


        }
        public static void Inicio()
        {
            Console.Clear();
            print("================================\n");
            print("Tienda de Don Lucas\n");
            print("================================\n");
            print("1: Registrar venta\n");
            print("2: Registrar devolución\n");
            print("3: Cerrar Caja\n");
            print("================================\n");
            print("Ingrese una opción: ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1: RegistrarVenta(); break;
                case 2: RegistrarDevolucion(); break;
                case 3: CerrarCaja(); break;
            }
        }
        public static void RegistrarVenta()
        {
            Console.Clear();
            print("================================\n");
            print("Registrar Venta de:\n");
            print("================================\n");
            print("1: Limpieza\n");
            print("2: Abarrotes\n");
            print("3: Golosinas\n");
            print("4: Electrónicos\n");
            print("5: <- Regresar\n");
            print("================================\n");
            print("Ingrese una opción: ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1: RegistrarProductosVenta("limpieza"); break;
                case 2: RegistrarProductosVenta("abarrotes"); break;
                case 3: RegistrarProductosVenta("golosinas"); break;
                case 4: RegistrarProductosVenta("electrónicos"); break;
                case 5: Inicio(); break;
            }
        }
        public static void RegistrarProductosVenta(string text)
        {
            Console.Clear();
            print("================================\n");
            print($"Registrar venta de {text}\n");
            print("================================\n");
            print("Ingrese cantidad (unidades): \n");
            double cantidadVentaLimpieza = Convert.ToDouble(Console.ReadLine());
            print("Ingrese precio: \n");
            print("S/"); double precioVentaLimpieza = Convert.ToDouble(Console.ReadLine());
            print("================================\n");
            print($"Se han ingresado {cantidadVentaLimpieza} unidades\n");
            print($"Se han ingresado S/{cantidadVentaLimpieza * precioVentaLimpieza} en caja\n");
            print("================================\n");
            print($"1: Registrar más productos de {text}\n");
            print("2: < -Regresar\n");
            print("================================\n");
            print("Ingrese una opción:\n");
            int opcion=int.Parse(Console.ReadLine());
            switch(opcion)
            {
                case 1: RegistrarProductosVenta(text); break;
                case 2: Inicio(); break;
            }
        }
        public static void RegistrarDevolucion()
        {
            Console.Clear();
            print("================================\n");
            print("Registrar devolución de:\n");
            print("================================\n");
            print("1: Limpieza\n");
            print("2: Abarrotes\n");
            print("3: Golosinas\n");
            print("4: Electrónicos\n");
            print("5: <- Regresar\n");
            print("================================\n");
            print("Ingrese una opción: ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1: RegistrarDevolucionProductos("Limpieza"); break;
                case 2: RegistrarDevolucionProductos("Abarrotes"); break;
                case 3: RegistrarDevolucionProductos("Golosinas"); break;
                case 4: RegistrarDevolucionProductos("Electrónicos"); break;
                case 5: Inicio(); break;
            }
        }
        public static void RegistrarDevolucionProductos(string text)
        {
            Console.Clear();
            print("================================\n");
            print($"Registrar devolución de {text}\n");
            print("================================\n");
            print("Ingrese cantidad(unidades):\n");
            double cantidadDevolucionLimpieza = Convert.ToDouble(Console.ReadLine());
            print("Ingrese precio: \n");
            print("S/"); double precioDevolucionLimpieza = Convert.ToDouble(Console.ReadLine());
            print("================================\n");
            print($"Se han regresado {cantidadDevolucionLimpieza} unidades\n");
            print($"Se han devuelto S/{cantidadDevolucionLimpieza*precioDevolucionLimpieza} de caja\n");
            print("================================\n");
            print($"1: Devolver más productos de {text}\n");
            print("2: < -Regresar\n");
            print("================================\n");
            print("Ingrese una opción:\n");
            int opcion=int.Parse(Console.ReadLine());
            switch(opcion)
            {
                case 1: RegistrarDevolucionProductos(text); break;
                case 2: Inicio(); break;
            }
        }
        public static void CerrarCaja()
        {
            Console.Clear();
            print("================================\r\n" +
                "Cerrando Caja\r\n" +
                "================================\r\n" +
                "Totales\r\n" +
                "================================\r\n" +
                "          | 15 vendidos\r\n" +
                "Limpieza  | 10 devueltos\r\n" +
                "          | 5 en total\r\n" +
                "          | S/ 35.00 en caja\r\n" +
                "================================\r\n" +
                "          | 4 vendidos\r\n" +
                "Abarrotes | 0 devueltos\r\n" +
                "          | 4 en total\r\n" +
                "          | S/ 12.00 en caja\r\n" +
                "================================\r\n" +
                "          | 6 vendidos\r\n" +
                "Golosinas | 2 devueltos\r\n" +
                "          | 4 en total\r\n" +
                "          | S/ 8.00 en caja\r\n" +
                "================================\r\n" +
                "          | 6 vendidos\r\n" +
                "Eletro    | 0 devueltos\r\n" +
                "          | 6 en total\r\n" +
                "          | S/ 89.00 en caja\r\n" +
                "================================\r\n" +
                "Queda en caja S/144.00");
        }
        public static void print(string text)
        {
            Console.Write(text);
        }
    }
}
