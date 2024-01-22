using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
namespace PoPRefactoring;

public class PopProject
{
    public static void Main(string[] args)
    {
        int dia;
        int mes;
        int any;
        bool validat;
        Console.WriteLine("Introdueix el dia, mes i any");
        dia = Convert.ToInt32(Console.ReadLine());
        mes = Convert.ToInt32(Console.ReadLine());
        any= Convert.ToInt32(Console.ReadLine());
        validat = valida(dia, mes, any);

        Console.WriteLine(!validat?"El format no és correcte": "La data és correcta {0}", validat);
    
    }

    public static bool valida(int day, int month, int year)
    {

        if (day < 1 || day > 31)

            return false;

        if (month < 1 || month > 12)

            return false;

        // determinem la quantitat de dies del mes:

        int totalDaysMonth = 0;

        switch (month)
        {

            case 1: totalDaysMonth = 31; break;

            case 3: totalDaysMonth = 31; break;

            case 5: totalDaysMonth = 31; break;

            case 7: totalDaysMonth = 31; break;

            case 8: totalDaysMonth = 31; break;

            case 10: totalDaysMonth = 31; break;

            case 12: totalDaysMonth = 31; break;

            case 4: totalDaysMonth = 30; break;

            case 6: totalDaysMonth = 30; break;

            case 9: totalDaysMonth = 30; break;

            case 11: totalDaysMonth = 30; break;

            case 2: // verifica l'any de traspàs

                if ((year % 400 == 0) ||

                ((year % 4 == 0) && (year % 100 != 0)))
                    totalDaysMonth = 29;

                else totalDaysMonth = 28;

                break;

        }

        if (day > totalDaysMonth)

            return false;

        else return true;

    }
}