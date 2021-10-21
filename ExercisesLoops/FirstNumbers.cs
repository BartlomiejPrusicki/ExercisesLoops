using System;

namespace ExercisesLoops
{
    class FirstNumbers
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Licznik liczb pierwszych");
           
            
            

            //for (byte i = 0; i < 20; i++)
            //{
                

            //    if (i%2 == 0) 
            //    {
            //        Console.WriteLine(i);
            //    }
            //    //else if (i == 5)
            //    //{
            //    //    double b = Math.Sqrt(i);
            //    //    Console.WriteLine("to nie to"+ b);
            //    //}
            //    //Console.WriteLine(i);
            //}
            
            
            
            //2. Napisz program, w którym za pomocą pętli do...while znajdziesz wszystkie liczby parzyste z zakresu 0 – 1000. 
            //Warning! Jak zwykle robię po swojemu.

            Console.WriteLine("Wyszukiwanie wszystkich liczb parzystych lub nieparzystych z wybranego zakresu");
            Console.WriteLine("Wypisywać nieparzyste (wpisz 1) czy parzyste (wpisz 2)?");
            byte choice;
            
            do
            { 
                choice = byte.Parse(Console.ReadLine());
                if (choice != 1 && choice != 2)
                {
                    Console.WriteLine("ERROR! Podaj 1 lub 2");
                }
            }
            while (choice != 1 && choice != 2);

            Console.WriteLine("Podaj ten zakres.");
            Console.Write("Zakres od ");
            int startOfRange, endOfRange;
            startOfRange = int.Parse(Console.ReadLine());
            Console.Write("do "); endOfRange = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("START");



            //if (choice == 1)                          //Po długich godzinach przeciążania różnorakich narzadów... doszedłem do niniejszej pierwszej opcji rozwiązania problemu.
            //{                                         //Co poszło nie tak? H*j go wie! Acz napewno trzeba przyjżeć sie logidzę działanie tej części.
                                                        //Jeżeli zmienna strartOfRange przyjmię wartość parzystą kod sprawi że pierwsza liczba parzysta zostanie
            //    while (startOfRange <= endOfRange)    //uwzględniona, a do poprawnego działania przejdzie dopiero po trój liczbowym skoku.
            //    {                                     //W przecinym wypadku wszystko będzie dobrze. Z racji po kolejnym dłuższym czasie dojścia do
            //        Console.WriteLine(startOfRange);  //poprawniejszego rozwiązania (czy wydajniejszego to wątpie) postanowłem z niego skorzystać w całym programie.

                //        if (startOfRange % 2 == 5)
                //        {
                //            startOfRange += 2;
                //        }
                //        else if (startOfRange % 2 == 0)
                //        {
                //            startOfRange++;
                //        }
                //        startOfRange += 2; //brak tej linijki skutkuje wpadnięcie w pętle while(true)
                //    }
                //}
            if (choice == 1)
            {
                if (startOfRange % 2 == 5)
                {
                    while (startOfRange <= endOfRange)
                    {
                        Console.WriteLine(startOfRange);
                        startOfRange += 2;
                    }
                }

                else
                {
                    startOfRange++;
                    while (startOfRange <= endOfRange)
                    {
                        Console.WriteLine(startOfRange);
                        startOfRange += 2;
                    }

                }
            }
            else if (choice == 2)
            {
                if (startOfRange % 2 == 0)
                {
                    while (startOfRange <= endOfRange)
                    {
                        Console.WriteLine(startOfRange);
                        startOfRange += 2;
                    }
                }

                else
                {
                    startOfRange++;
                    while (startOfRange <= endOfRange)
                    {
                        Console.WriteLine(startOfRange);
                        startOfRange+=2;
                    }
                    
                }
            }
            Console.ReadKey();
        }
    }
}

