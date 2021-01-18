using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemele_cu_secvente
{
   

namespace Probleme_cu_secvente
    {
        class Program
        {
            static void Main(string[] args)
            {
                //nrPare();
                //nrNegPozNule();
                //sumaProdus1LaN();
                //ordineCrescatoare();
                //ceaMaiMicaMareVal();
                //pozitiaUnuiNr();
                //egaleCuPozitia();
                // minMax();
                //Fibonaci();
                //monotonCrescDescresc();
                //maxNrConsecutive();
                //inversul();
                //problema12();
                // problema13();
                problema15();
            }
            /// <summary>
            ///O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. 
            ///De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica. 
            /// </summary>
            private static void problema15()
            {
                int n;
                int a, b;
                n = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                int i;
                for (i = 0; i < n - 1; i++)
                {
                    a = b;
                    b = int.Parse(Console.ReadLine());

                    if (a > b)
                        break;
                }
                i++;
                if (i != n)
                {
                    for (; i < n - 1; i++)
                    {
                        a = b;
                        b = int.Parse(Console.ReadLine());
                        if (a > b)
                            break;
                    }
                    i++;
                }

                Console.WriteLine($"Secventa de numere {(i == n ? "" : "nu ")}este o secventa bitonica.");
                Console.ReadKey();
            }

            /// <summary>
            /// O secventa crescatoare rotita este o secventa de numere care este in ordine crescatoare sau poate fi transformata
            /// intr-o secventa in ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie
            /// spre stanga si primul element devine ultimul). Determinati daca o secventa de n numere este o secventa crescatoare rotita. 
            /// </summary>
            private static void problema13()
            {
                int n = int.Parse(Console.ReadLine());
                int x = int.Parse(Console.ReadLine());
                bool crescator = true;
                int a = 0;
                for (int i = 0; i < n - 1; i++)
                {
                    int b = int.Parse(Console.ReadLine());
                    if (x > b)
                    {
                        crescator = false;
                    }
                    int minimul = x;
                    if (x > b && minimul > b)
                    {
                        a++;
                    }
                    x = b;
                }
                if (crescator == true || a == 1)
                    Console.WriteLine("Secventa de numere este rotita crescatoare");
                else
                    Console.WriteLine("Secventa de numere nu este rotita crescatoare");
                Console.ReadKey();
            }

            /// <summary>
            /// Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere.
            /// Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte.
            /// De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. 
            /// </summary>
            private static void problema12()
            {
                int n, a, b;
                int i;
                Console.WriteLine("Introduceti n= ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduceti a= ");
                a = int.Parse(Console.ReadLine());
                int Secventa = 0;
                bool c = false;
                b = int.Parse(Console.ReadLine());
                a = b;

                for (i = 1; i < n; i++)
                {
                    a = b;
                    b = int.Parse(Console.ReadLine());

                    if (a == 0 && b != 0)
                        c = true;

                    if (a != 0 && b == 0 && c == true)
                        Secventa++;

                    else if (a > b)
                        c = false;
                }
                if (c == true)
                    Secventa++;

                Console.WriteLine($"In secventa sunt {Secventa} grupuri de numere consecutive diferite de zero.");
                Console.ReadKey();
            }

            /// <summary>
            /// Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. 
            /// </summary>
            private static void inversul()
            {
                Console.WriteLine("n");
                int n = int.Parse(Console.ReadLine());
                int s = 0;
                int invers;
                for (int i = 0; i < n; i++)
                {
                    int a = int.Parse(Console.ReadLine());
                    invers = 0;
                    while (a != 0)
                    {
                        invers = invers * 10 + a % 10;
                        a = a / 10;
                    }
                    s += invers;
                }
                Console.WriteLine(s);
            }

            /// <summary>
            /// Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 
            /// </summary>
            private static void maxNrConsecutive()
            {
                int n, b;
                n = int.Parse(Console.ReadLine());


                int nr = 0, max = 1, rez2 = 1, i;

                for (i = 1; i < n; i++)
                {

                    b = int.Parse(Console.ReadLine());
                    if (b == nr)
                        max++;
                    else
                    {
                        if (max > rez2)
                            rez2 = max;
                        max = 1;
                        nr = b;
                    }
                    if (max > rez2)
                        rez2 = max;
                    Console.WriteLine($"Numarul maxim de numere consecutive este  {max}");
                    Console.ReadKey();

                }
            }

            /// <summary>
            /// Sa se determine daca o secventa de n numere este monotona. 
            /// Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 
            /// </summary>
            private static void monotonCrescDescresc()
            {
                int n, a, b;
                int crescator = 0;
                int descrescator = 0;
                n = int.Parse(Console.ReadLine());
                a = int.Parse(Console.ReadLine());
                for (int i = 0; i < n - 1; i++)
                {
                    b = int.Parse(Console.ReadLine());

                    if (a < b)
                        crescator++;
                    else
                        descrescator++;
                    b = a;
                }
                if (crescator == 0)
                    Console.WriteLine("Secventa este monoton descrescatoare");
                else
                    if (descrescator == 0)
                    Console.WriteLine("Secventa este monoton crescatoare");
                else
                    Console.WriteLine("Secventa nu este monotona");
                Console.ReadKey();


            }


            private static void Fibonaci()
            {
                int n, i, a, b, c;
                Console.WriteLine("Introduceti n= ");
                n = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
                if (n == 1 || n == 2)
                    Console.WriteLine(1);
                else
                {

                    a = 1;
                    b = 1;
                    for (i = 3; i <= n; ++i)
                    {
                        c = a + b;
                        a = b;
                        b = c;
                    }
                    Console.WriteLine(c + " ");
                }
                Console.ReadKey();
            }

            /// <summary>
            /// Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 
            /// </summary>
            private static void minMax()
            {
                int i, max, min, n, nr;
                Console.WriteLine("Introduceti n= ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduceti nr= ");
                nr = int.Parse(Console.ReadLine());
                max = nr;
                min = nr;

                for (i = 1; i < n; i++)

                {
                    int a = int.Parse(Console.ReadLine());
                    if (a > max)
                        max = a;

                    if (a < min)
                        min = a;
                }
                Console.WriteLine($"Minimul este {min}, iar maximul este {max}");

                Console.ReadKey();

            }
            /// <summary>
            /// Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. 
            /// Se considera ca primul element din secventa este pe pozitia 0. 
            /// </summary>
            private static void egaleCuPozitia()
            {
                Console.WriteLine("Introduceti n");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduceti a");
                int a = int.Parse(Console.ReadLine());
                int pozitie = 0;
                int x;
                x = int.Parse(Console.ReadLine());

                int contor = 0;

                for (int i = 0; i < n; i++)
                {

                    if (i == pozitie)
                    {
                        contor++;

                    }

                }
                Console.WriteLine(contor);
                Console.ReadKey();


            }



            /// <summary>
            /// Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a.
            /// Se considera ca primul element din secventa este pe pozitia zero.
            /// Daca numarul nu se afla in secventa raspunsul va fi -1. 
            /// </summary>
            private static void pozitiaUnuiNr()
            {
                Console.WriteLine("Introduceti n");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduceti a");
                int a = int.Parse(Console.ReadLine());
                int pozitie = 0;
                int ok = 0;



                for (int i = 0; i < n; i++)
                {
                    if (i == a)
                    {
                        ok = 1;
                        pozitie = i + 1;
                    }
                }
                if (ok == 1)

                    Console.WriteLine($"{pozitie}", pozitie);

                else
                    Console.WriteLine(-1);

                Console.ReadKey();
            }



            /// <summary>
            /// Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare.
            /// </summary>
            private static void ordineCrescatoare()
            {
                int n, a, b;
                n = int.Parse(Console.ReadLine());
                bool crescator = true;
                a = int.Parse(Console.ReadLine());



                for (int i = 0; i < n - 1; i++)
                {
                    b = int.Parse(Console.ReadLine());
                    if (a > b)
                    {
                        crescator = false;
                    }
                    a = b;
                }
                if (crescator)


                    Console.WriteLine("Numerele sunt in ordine crescatoare");

                else
                    Console.WriteLine("Numerele nu sunt in ordine crescatoare");
                Console.ReadKey();
            }


            /// <summary>
            /// Calculati suma si produsul numerelor de la 1 la n. 
            /// </summary>
            private static void sumaProdus1LaN()
            {
                int x, n, p = 1, s = 0;
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduceti numerele pana la n");
                for (int i = 1; i <= n; i++)

                {
                    x = int.Parse(Console.ReadLine());
                    p = x * p;
                    s = x + s;

                }
                Console.WriteLine($"Produsul este  {p}, iar suma este    {s}");
                Console.ReadKey();
            }

            /// <summary>
            /// Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive.
            /// </summary>
            private static void nrNegPozNule()
            {
                int n = int.Parse(Console.ReadLine());
                int x;

                int neg = 0;
                int poz = 0;
                int zero = 0;
                for (int i = 0; i < n; i++)
                {
                    x = int.Parse(Console.ReadLine());

                    if (x > 0)
                    {
                        poz++;
                    }

                    if (x < 0)
                    {
                        neg++;
                    }
                    if (x == 0)
                    {
                        zero++;
                    }

                }
                Console.WriteLine($"Ati introdus:{poz} nr pozitive, {neg} numere negative si {zero} nr de zero");
                Console.ReadKey();
            }

            /// <summary>
            /// Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 
            /// </summary>
            private static void nrPare()
            {
                int n = int.Parse(Console.ReadLine());
                int x;
                int contor = 0;
                for (int i = 0; i < n; i++)
                {
                    x = int.Parse(Console.ReadLine());


                    if (x % 2 == 0)
                        contor++;
                }
                if (contor == 0)
                    Console.WriteLine("Nu exista");
                else
                    Console.WriteLine(contor);
                {
                    Console.WriteLine($"Numarul de numere pare este {contor}");
                    Console.ReadKey();

                }
            }
        }
    }

}