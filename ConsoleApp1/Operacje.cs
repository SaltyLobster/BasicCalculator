using System;

namespace Kalkulator
{
    public class Operacje
    {
        public static Func<double, double, double> dodaj = (a, b) => a + b;

        public static Func<double, double, double> odejmij = (a, b) => a - b;

        public static Func<double, double, double> pomnoz = (a, b) => a * b;

        public static Func<double, double, double> podziel = (a, b) => a / b;

        public static Func<double, double, double> procent = (a, b) => (a * b) / 100 ;
    }
}