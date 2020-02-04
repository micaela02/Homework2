using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class Program
    {
        public static void Main(string[] args)
        {



            //Ex1//

            // Fie urmatoarea secventa de cod:"...". Ce va afisa aceasta la executie si de ce?

            /*
             * 
            int a = 3;
            int b = (a = 2) * a;
            int c = b * (b = 5); 
            Console.WriteLine("a =" + a + ", b =" + b + ", c =" + c);

            */

            /*Rezolvare

            Programul afiseaza: a = 2, b = 5, c = 20
            De ce: 
         - Valoarea initiala a lui "a" este 3, insa ulterior i se atribuie valoarea 2 (a = 2) => la final "a" va avea valoarea 2; 
         - Valoarea initiala a lui "b" este (a = 2) * a ceea ce ar insemna ca b = 2 * 2 = 4; insa ulterior lui "b" i se atribuie valoarea 5 si astfel, la final "b" = 5;
         - Valoarea lui "c" este b * (b = 5); practic, "c" = "valoarea initiala a lui "b" (a = 2)*a = 4" inmultit cu noua valoare atribuita lui "b" (valoarea 5) => la final "c" = 20;
           */


            //Ex2//

            // Fie urmatorul subprogram:"...". Ce se poate spune despre acesta? Se compileaza? Ce afiseaza?

            /*

            double d = 2.95;
            int i = 4;
            Console.WriteLine(++d > i ? d : i);

            */

            /*Rezolvare

              Se complileaza?: - Da;
              Ce afiseaza?/; - Valoarea 4
              Descriere: Valoarea initiala a lui "d" este 2.95;
              Problema cere sa se afiseze: 
                 Daca ++d (3.95 deoarece intai s-a incrementat valoarea) este mai mare ca 4 atunci afiseaza "d" (si anume noua valoare atribuita, cea incrementata);
                     altfel, afiseaza i (adica valoarea 4).

             3.95 < 4 => Valoarea afisata este i = 4.
             */

            //Ex3//

            //Fie urmatorul subprogram:"...". Ce se afisa si de ce?

            /*

            int a = 3;
            if (++a < 4)
                if (a++ < 4)
                    Console.WriteLine(a);
                else
                    Console.WriteLine(a);

            */

            /*Rezolvare
             In primul "if" valoarea lui "a" devine 4 dupa incrementare; 4 < 4 => Fals
             In acest caz, programul se incheie practic dupa primul If pentru ca a returnat fals. Urmatorul If + Else nu se executa.
             Neavand un al doilea Else, la final programul nu va afisa nici un raspuns.
             */



            //Ex4//

            //Fie urmatorul subprogram:"...". 

            /*

            int suma = 0;
            for (int i = 1; i < 10; i++)
            {
                suma = suma + i;
            }
            Console.WriteLine("Suma este: " +suma);

            */

            /*Rezolvare

            Programul afiseaza: Suma este: 45
            Descriere: Daca "i" = 1, pentru i < 10 cu increment de 1, afiseaza "Suma este: " +suma
            suma = 0 + valoarea initiala a lui "i" (i = 1) + "i" incrementat cu 1 pana la 10;
            suma = 0 + 1 + ... + 9 = 45
            */

            //Ex5//

            //Scrieti un program care sa returneze n! (adica n = 1 * 2 * 3 * … * n), unde n < 13 este un numar natural.

            /*
            int inmultire = 1;
            for (int n = 1; n < 13; n++)
            {
                inmultire = inmultire * n;
            }
            Console.WriteLine(inmultire);

            */

            //Rezolvare: n = valoarea lui "n" pornind de la valoarea 1 si incrementata cu 1 pana la n < 13.


            //Ex6//

            //Scrieti un program care sa returneze minimum a trei numere intregi , folosind instructiunea if - else.


            //Rezolvare 1 - cu If - Else

            /*

            int a = 3;
            int b = 2;
            int c = 4;

            if (a < b && a < c)
                Console.WriteLine(a);
           else if (b < c)
                Console.WriteLine(b);
            else
                Console.WriteLine(c);

            */

            //Rezolvare 2 - fara Il - Else

            /*
            int a = 7;
            int b = 3;
            int c = 4;

            Console.WriteLine("Lowest of three: " + Math.Min(a, Math.Min(b, c)));
            */



            //Ex7//

            // Determinati daca un numar este par sau impar.

            /*
            int a = 7;
            if (a % 2 == 0)

                Console.WriteLine("Number is even");

            else

                Console.WriteLine("Number is odd");
            */

            //Rezolvare/: Am folosit operatorul "%" pentru a determina restul impartirii;
            //Restul se compara cu 0 => daca este 0, atunci numarul este par, daca nu, numarul este impar.

            //Ex8//

            /*
            Folosind instructiunea switch scrieti un program care sa afiseze ziua saptamanii in functie de numarul acesteia. 
            De exemplu : ziua 1 este echivalenta zilei “Luni”, ziua 2 este “Marti” etc.
            */

            /*
            {
                int caseSwitch = 5;

                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("Luni");
                        break;
                    case 2:
                        Console.WriteLine("Marti");
                        break;
                    case 3:
                        Console.WriteLine("Miercuri");
                        break;
                    case 4:
                        Console.WriteLine("Joi");
                        break;
                    case 5:
                        Console.WriteLine("Vineri");
                        break;
                    case 6:
                        Console.WriteLine("Sambata");
                        break;
                    case 7:
                        Console.WriteLine("Duminica");
                        break;
                    default:
                        Console.WriteLine("Nu este o zi a saptamanii!");
                        break;

                }
            } 
            */

            //Teme seria 2:

            //Ex1: Scrieti un program care afiseaza primele 4 numere naturale care sunt egale cu suma divizorilor lor.
            //Exemplu: 28 = 1 + 2 + 4 +7 +14 este un numar valid.

            /*
             
            int numar = 31;
            int sum = 0;
            int cateAmGasit = 0;


                for (int i = 1; i < numar; i++)
                {
                    //numar++;

                    if (numar % i == 0)
                    {
                        sum += i;
                    }
                }

                if (sum == numar)
                {
                    cateAmGasit++;
                    Console.WriteLine("numarele sunt: " + sum);
                }
                
                */


            // Ex 2: Presupunem ca depunem o suma (depozit la termen) intr-o banca ce ofera o dobanda de 25% pe an. 
            //Sa se calculeze suma finala dupa un anumit numar de ani (se va tine cont de “dobanda la dobanda”).

            /*

            double suma = 100;
            double dobanda = 0.25;
            int b = 10;


            for (int i = 0; i <= b; i++)
            {
                suma = suma + (suma * dobanda);
                Console.WriteLine("anu " + i + "total: " + suma);
            }
            */

            /*
            Ex 3: Scrieti un program care primeste la intrare (declarati voi ca variabila) un numar de secunde 
            si afiseaza maximul de ore, minute, secunde care este echivant ca timp cu numarul initial de secunde.
            De exemplu: 7384 secunde este echivalent cu 2 ore 3 minute si 4 secunde.
            */

            /*
            int nr = 3599;

            int secunde;
            int minute;
            int ore;

            secunde = nr % 60;
            minute = nr / 60;

            if (minute >= 60)
            {
                ore = minute / 60;
                minute = minute % 60;
                Console.WriteLine(secunde + " " + minute + " " + ore);
            }

            else
            {
                ore = 0;
                Console.WriteLine(secunde + " " + minute + " " + ore);
            }

            */


        }

    }
}

