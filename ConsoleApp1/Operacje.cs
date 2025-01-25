using System;

namespace Kalkulator
{
    public class Operacje
    {
        public static Func<int, int, int> dodaj = (a, b) => a + b;
        public static Func<int, int, int> odejmij = (a, b) => a - b;
        public static Func<int, int, int> pomnoz = (a, b) => a * b;
        public static Func<int, int, int> podziel = (a, b) => a / b;
        public static Func<int, int, int> procent = (a, b) => (a * b) / 100 ;
    }
}