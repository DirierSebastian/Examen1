using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Examen1
{
    internal class Examen
    {
        public string Numeros(int inicio, int final)
        {
            if (final <= inicio)
            {
                Console.WriteLine("La secuencia de los números es " + inicio);
                if (inicio == final)
                {
                    return "Los números son iguales";
                }
                return Numeros(--inicio, final);
            }
            else
            {
                Console.WriteLine("La secuencia de los números es " + inicio);
                if (inicio == final)
                {
                    return "Los números son iguales";
                }
                return Numeros(++inicio, final);

            }

        }
        public string Numeros2(int inicio, int final)
        {
            if (inicio == final)
            {
                return "El numero es igual";
            }
            while (final >= inicio)
            {
                Console.WriteLine("La secuencia de los números es " + inicio);
                if (inicio == final)
                {
                    return "";
                }
                ++inicio;
            }
            while(final <= inicio)
            {
                Console.WriteLine("La secuencia de los números es " + inicio);
                if (inicio == final)
                {
                    return "";
                }
                --inicio;

            }
            return "";

        }
        public string Tablas(int inicio, int final, int tabla)
        {
            if (tabla != inicio && inicio != final)
            {
                Console.WriteLine($"{tabla} x {inicio} = {tabla * inicio}");
                return Tablas(++inicio, final, tabla);
            }
            if (tabla ==  inicio && inicio == final)
            {
                Console.WriteLine($"{tabla} x {inicio} = {tabla * inicio}");
                return "Has llegado al final";
            }
            if( inicio != final)
            {
                Console.WriteLine($"{tabla} x {inicio} = {tabla * inicio}");
                return Tablas(++inicio, final, tabla);
            }
            if (final == inicio)
            {
                Console.WriteLine($"{tabla} x {inicio} = {tabla * inicio}");

                return Tablas(inicio-9, final, ++tabla);
            }
            return "";
        }

    }
}
