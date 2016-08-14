using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace numerosRomanos
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            NumerosRomanos Ob = new NumerosRomanos();
              do {
                     Console.Write("Introduce un número entre 1 y 3500: ");
                     N = Convert.ToInt32(Console.ReadLine());
              } while (N < 1 || N > 3500);
              Console.WriteLine();
              Console.Write(N + "Numero decimal: " + N + " Numeros romanos: " + Ob.convRomanos(N));
              Console.ReadLine();
        }
        public class NumerosRomanos
        {
            public String convRomanos(int num)
            {
                int i, thousands, hundreds, dozens, units;
                String newRom = "";
                thousands = num / 1000;
                hundreds = num / 100 % 10;
                dozens = num / 10 % 10;
                units = num % 10;
                
                for (i = 1; i <= thousands; i++)
                {
                    newRom = newRom + "M";
                }
                if (hundreds == 9)
                {
                    newRom = newRom + "CM";
                }
                else
                {
                    if (hundreds >= 5)
                    {
                        newRom = newRom + "D";
                        for (i = 6; i <= hundreds; i++)
                        {
                            newRom = newRom + "C";
                        }
                    }
                    else
                        if (hundreds == 4)
                        {
                            newRom = newRom + "CD";
                        }
                        else
                        {
                            for (i = 1; i <= hundreds; i++)
                            {
                                newRom = newRom + "C";
                            }
                        }
                }
                if (dozens == 9)
                {
                    newRom = newRom + "XC";
                }
                else
                {
                    if (dozens >= 5)
                    {
                        newRom = newRom + "L";
                        for (i = 6; i <= dozens; i++)
                        {
                            newRom = newRom + "X";
                        }
                    }
                    else
                        if (dozens == 4)
                        {
                            newRom = newRom + "XL";
                        }
                        else
                        {
                            for (i = 1; i <= dozens; i++)
                            {
                                newRom = newRom + "X";
                            }
                        }
                }
                if (units == 9)
                {
                    newRom = newRom + "IX";
                }
                else
                {
                    if (units >= 5)
                    {
                        newRom = newRom + "V";
                        for (i = 6; i <= units; i++)
                        {
                            newRom = newRom + "I";
                        }
                    }
                    else
                        if (units == 4)
                        {
                            newRom = newRom + "IV";
                        }
                        else
                        {
                            for (i = 1; i <= units; i++)
                            {
                                newRom = newRom + "I";
                            }
                        }
                }
                return newRom;
            }
        }
    }
}

