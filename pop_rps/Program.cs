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

        string Jump = "A.Saltar";
        string Run = "B.Córrer";
        string Down = "C.Ajupir-se";
        string Hide = "D.Amagar-se";
        validat = valida(dia, mes, any);

        Console.WriteLine(!validat?"El format no és correcte": "La data és correcta {0}", validat);

        Console.WriteLine(Jump);
        Console.WriteLine(Run);
        Console.WriteLine(Down);
        Console.WriteLine(Hide);
        string option;
        do
        {
            option=Console.ReadLine().ToUpper();
        }while(!(option=="A" || option=="B" || option=="C" ||option=="D"));
        Action(option);
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

    public static void Action(string action)
    {
        if (action == "A")
        {
            Console.WriteLine("Saltar");
        }
        else if (action == "B")
        {
            Console.WriteLine("Córrer");
        }
        else if (action == "C")
        {
            Console.WriteLine("Ajupir-se");
        }
        else if(action == "D")
        {
            Console.WriteLine("Amagar-se");
        }
    }
    

}