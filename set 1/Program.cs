using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opt;
            bool e=true;
            Console.WriteLine("Lista exercitii:");
            Console.Write("0,");
            Console.Write("1,");
            Console.Write("2,");
            Console.Write("3,");
            Console.Write("4,");
            Console.Write("5,");
            Console.Write("6,");
            Console.Write("7,");
            Console.Write("8,");
            Console.Write("9,");
            Console.Write("10,");
            Console.Write("11,");
            Console.Write("12,");
            Console.Write("13,");
            Console.Write("14,");
            Console.Write("15,");
            Console.Write("16,");
            Console.Write("17,");
            Console.Write("18,");
            Console.Write("19,");
            Console.Write("20,");
            Console.WriteLine("21");

            while (e)
            {
                Console.Write("Introduceti exercitiul:");
                opt=int.Parse(Console.ReadLine());

                switch (opt)
                { case 0:Console.WriteLine("Iesire");
                        e = false;
                        break;

                    case 1:
                        {
                            E1(); break;
                        }
                    case 2:
                        {
                            E2(); break;
                        }
                    case 3:
                        {
                            E3(); break;
                        }
                    case 4:
                        {
                            E4(); break;
                        }
                    case 5:
                        {
                            E5(); break;
                        }
                    case 6:
                        {
                            E6(); break;
                        }
                    case 7:
                        {
                            E7(); break;
                        }
                    case 8:
                        {
                            E8(); break;
                        }
                    case 9:
                        {
                            E9(); break;
                        }
                     case 10:
                        {
                            E10(); break;
                        }
                     case 11:
                        {
                            E11(); break;
                        }
                     case 12:
                        {
                            E12(); break;
                        }
                     case 13:
                        {
                            E13(); break;
                        }
                     case 14:
                        {
                            E14(); break;
                        }
                     case 15:
                        {
                            E15(); break;
                        }
                     case 16:
                        {
                            E16(); break;
                        }
                     case 17:
                        {
                            E17(); break;
                        }
                    case 18:
                        {
                            E18(); break;
                        }
                    case 19:
                        {
                            E19(); break;
                        }
                    case 20:
                        {
                            E20(); break;
                        }
                    case 21:
                        {
                            E21(); break;
                        }
                }
               
            }
        }

        private static void E21()
        {
            
            Random rd = new Random();
            int n = rd.Next(1, 1024);
            int caz;
            int x;
            Console.Write("Dati un nr x=");
            x = int.Parse(Console.ReadLine());

            while (x != n)
            {
                
                if (x < n)
                {
                    caz = 0;
                }
                else
                {
                    if (x > n)
                        caz = 1;
                    else
                        caz = 2;
                }
                switch (caz)
                {
                    case 0:
                        Console.WriteLine("Numarul dat este mai mic decat n");
                        break;
                    case 1:
                        Console.WriteLine("Numarul dat este mai mare decat n");
                        break;
                    case 2:
                        Console.WriteLine("Ati gasit numarul n");
                        break;
                }
                Console.Write("Dati un nr x=");
                x = int.Parse(Console.ReadLine());               
            }
            Console.WriteLine("Ati gasit numarul n");
            Console.ReadKey();
        }

        private static void E20()
        {
            int n, a, m;
            bool i= false;
            Console.WriteLine("Dati doua numere pentru fractia m/n");
            Console.Write("m=");
            m = int.Parse(Console.ReadLine());
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            a = n;
            if((n % 2 != 0) && (n % 5 != 0))
            {
                Console.WriteLine("Functia e periodica simpla");
            }

            while(a%2==0)
            {
                a /= 2;
            }
            while(a%5==0)
            {
                a /= 5; 
            }
            if (a == 1)
                i = true;
            if(i==true)
                Console.WriteLine("Functia e neperiodica");

            if((n % 2 == 0 || n % 5 == 0) && i==false)
                Console.WriteLine("Functia e periodica mixta");

            Console.ReadKey();
        }

        private static void E19()
        {
            int a, b, n;
            Console.WriteLine("Dati un nr n:");
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            a = n % 10;
            n = n / 10;
            while (n % 10 == a)
            {
                n = n / 10;
            }
            b = n % 10;
            n = n / 10;
            while((n % 10 == b || n %10 == a) && n != 0)
            {
                n = n / 10;
            }
            if (n == 0)
                Console.WriteLine("Numarul este format doar din 2 cifre");
            else
                Console.WriteLine("Numarul NU este format doar din 2 cifre");

            Console.ReadKey();
        }

        private static void E18()
        {
            int n, c, r;
            Console.WriteLine("Dati un nr n:");
            Console.WriteLine("n=");
            n=int.Parse(Console.ReadLine());
            Console.Write("Descompunerea in factori primi a numarului n este:");
            for(c=2;c<=n;c++)
            {
                r = 0;
                if(n%c==0)
                {
                    Console.Write(c);
                }
                while(n%c==0)
                {
                    n = n / c;
                    r = r + 1;
                }
                if(r!=0)
                Console.Write("^" + r + ",");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        private static void E17()
        {
            int a, b;
            Console.WriteLine("Dati 2 numere a si b:");
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            
            int m = a, n = b;
            while (m != n)
            {
                if (m > n)
                    n = n + b;
                else
                    m = m + a;
            }
            Console.WriteLine("cmmmc dintre a si b este " + m);

            while (a != b)
            { if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            Console.WriteLine("cmmdc dintre a si b este " + a);
            Console.ReadKey();

        }

        private static void E16()
        {
            int a, b, c, d, e;
            Console.WriteLine("Dati 5 numere a,b,c,d,e:");
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            c = int.Parse(Console.ReadLine());
            Console.Write("d=");
            d = int.Parse(Console.ReadLine());
            Console.Write("e=");
            e = int.Parse(Console.ReadLine());

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4 - i; j++)
                {

                    if (a > b)
                    {
                        int aux = a;
                        a = b;
                        b = aux;
                    }
                    if (b > c)
                    {
                        int aux = b;
                        b = c;
                        c = aux;
                    }
                    if (c > d)
                    {
                        int aux = c;
                        c = d;
                        d = aux;
                    }
                    if (d > e)
                    {
                        int aux = d;
                        d = e;
                        e = aux;
                    }

                }

            }

            Console.WriteLine("Cele 5 numere in ordine crescatoare sunt:");
            Console.Write(a + "," + b + "," + c + "," + d + "," + e);
            Console.WriteLine();
            Console.ReadKey();
        }

        private static void E15()
        {
            int a, b, c;
            Console.WriteLine("Dati 3 numere a,b,c:");
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            c = int.Parse(Console.ReadLine());

            int caz;
            if (a < b && a < c)
            {
                caz = 0;
            }
            else if (b < a && b < c)
            {
                caz = 1;
            }
            else
            {
                caz = 2;
            }

            Console.WriteLine("Cele 3 numere in ordine crescatoare sunt:");

            switch (caz)
            {
                case 0:
                    if (b < c)
                        Console.Write(a + "," + b + "," + c);
                    else
                        Console.Write(a + "," + c + "," + b);
                    break;
                case 1:
                    if (a < c)
                        Console.Write(b + "," + a + "," + c);
                    else
                        Console.Write(b + "," + c + "," + a);
                    break;
                case 2:
                    if (a < b)
                        Console.Write(c + "," + a + "," + b);
                    else
                        Console.Write(c + "," + b + "," + a);
                    break;
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        private static void E14()
        {
            int n, a, b=0;
            Console.WriteLine("Dati un nr n:");
            n = int.Parse(Console.ReadLine());
            a = n;
            while (a > 0)
            {
                b = b * 10 + a % 10;
                a = a / 10;
            }
            if (b == n)
                Console.WriteLine("Nr este palindrom");
            else
                Console.WriteLine("Nr NU este palindrom");

            Console.ReadKey();
        }

        private static void E13()
        {
            int an1, an2, b=0;
            Console.WriteLine("Dati 2 ani:");
            Console.Write("an1=");
            an1=int.Parse(Console.ReadLine());
            Console.Write("an2=");
            an2=int.Parse(Console.ReadLine());
            for(int i = an1; i <= an2; i++)
            {
                if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0)
                    b = b + 1; ;
            }
            Console.WriteLine("Intre " + an1 + " si " + an2 + " exista " + b + " de ani bisecti");
            Console.ReadKey();
        }

        private static void E12()
        {
            int a, b, n;
            Console.WriteLine("Dati capetele intervalului [a,b]:");
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati un nr n:");
            Console.Write("n=");
            n =int.Parse(Console.ReadLine());
            Console.WriteLine("Numerele divizibile cu n din intervalul [a,b] sunt:");

            for (int i = a; i <= b; i++)
            {
                if (i % n == 0)
                Console.Write(i + ",");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        private static void E11()
        {
            int n,i = 0;
            Console.WriteLine("Dati un nr n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Inversul numarului n este:");
                while (n > 0)
            { 
                i = i * 10 + n % 10;
                n = n / 10;
            }
            Console.WriteLine(i);
            Console.ReadKey();
        }

        private static void E10()
        {
            int n;
            bool e=true;
            Console.WriteLine("Dati un nr n:");
            n = int.Parse(Console.ReadLine());
            for(int i = 2; i <= n/2;i++)
            {
                if (n % i == 0)
                    e = false;
            }
            if (e == true) Console.WriteLine("Nr este prim");
            else Console.WriteLine("Nr NU este prim");
            Console.ReadKey();
        }

        private static void E9()
        {
            int n, c;
            Console.WriteLine("Dati un nr n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Divizori lui n sunt:");
            for(c=1; c<=n; c++)
            {
                if(n%c==0)
                {
                    Console.Write(c + ",");
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        private static void E8()
        {
            int a, b;
            Console.WriteLine("Dati 2 nr a si b");
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Valorile inversate sunt:");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.ReadKey();
        }

        private static void E7()
        {
            int a, b, c;
            Console.WriteLine("Dati 2 nr a si b");
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            c = a;
            a = b;
            b = c;
            Console.WriteLine("Valorile inversate sunt:");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.ReadKey();
        }

        private static void E6()
        {
            int a, b, c;
            Console.WriteLine("Dati lungimea a 3 laturi a,b,c");
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            c = int.Parse(Console.ReadLine());

            if((b+c)>a)
            {
                Console.WriteLine("Cele 3 laturi pot forma un triunghi");
            }
            else
            {
                Console.WriteLine("Cele 3 laturi NU pot forma un triunghi");
            }
            Console.ReadKey();
        }

        private static void E5()
        {
            Console.WriteLine("Dati 2 nr n si k:");
            int n, k;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("k=");
            k = int.Parse(Console.ReadLine());

            while(k>1)
            {
                n=n/10;
                k--;
            }
            Console.WriteLine("A k-a cifra de la sfarsitul numarului este:" + n % 10);
            Console.ReadKey();
        }

        private static void E4()
        {
            int n;
            Console.Write("Dati un an:");
            n = int.Parse(Console.ReadLine());

            if ((n % 4 == 0 && n % 100 != 0) || n % 400 == 0)
            {
                Console.WriteLine("Anul este bisect");
            }
            else 
            {
                Console.WriteLine("Anul NU este bisect");
            }
            Console.ReadKey();
        }

            private static void E3()
        {
            Console.WriteLine("Dati 2 nr n si k:");
            int n, k;
            Console.Write("n=");
            n=int.Parse(Console.ReadLine());
            Console.Write("k=");
            k=int.Parse(Console.ReadLine());
            if (n % k == 0)
            {
                Console.WriteLine("k divide pe n");
            }
            else
            {
                Console.WriteLine("k NU divide pe n");
            }
            Console.ReadKey();
        }

        private static void E2()
        {
            int a, b, c;
            float d;
            Console.WriteLine("Dati a,b,c in ec de grad 2 ax^2+bx+c");
            Console.Write("a=");
            a=int.Parse(Console.ReadLine());
            Console.Write("b=");
            b =int.Parse(Console.ReadLine());
            Console.Write("c=");
            c =int.Parse(Console.ReadLine());

            d = (b ^ 2) - 4 * a * c;

            if (d > 0)
            {
                Console.WriteLine("x1=" + (-b + Math.Sqrt(d)) / (2 * a));
                Console.WriteLine("x2=" + (-b - Math.Sqrt(d)) / (2 * a));
            }
            else
            {
                if (d == 0)
                {
                Console.WriteLine("x=" + (-b) / (2 * a));

                }
                else
                {
                    d = d * (-1);
                    Console.WriteLine("x1=" + (-b + Math.Sqrt(d)) / (2 * a) + "i");
                    Console.WriteLine("x2=" + (-b - Math.Sqrt(d)) / (2 * a) + "i");
                }
            }

            Console.ReadKey();

        }

        private static void E1()
        {
            Console.WriteLine("Dati a,b in ecuatia ax+b");
            int a,b;
            float x;
            Console.Write("a=");
            a=int.Parse(Console.ReadLine());
            Console.Write("b=");
            b=int.Parse(Console.ReadLine());
            x = -b / a;
            Console.WriteLine("x=" + x);
            Console.ReadKey();
        }
    }
}
