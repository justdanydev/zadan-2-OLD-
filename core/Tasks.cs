using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_practice2.core
{
    internal class Tasks
    {
        public void Task1()
        {
            double G, e, y, f;

            e = 2.7;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение f: ");
            f = Convert.ToDouble(Console.ReadLine());

            G = (Math.Pow(e, 2 * y) + Math.Sin(f)) / (Math.Log(3, 8 * y + f));

            Console.WriteLine($"G = {G}");
        }
        public void Task2()
        {
            double F, d, y;

            Console.WriteLine("Введите значение d: ");
            d = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            F = Math.Log(d) + (3.5 * Math.Pow(d, 2) + 1) / (Math.Cos(2 * y));

            Console.WriteLine($"F = {F}");

        }
        public void Task3()
        {
            double U, k, y, e;

            e = 2.7;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение k: ");
            k = Convert.ToDouble(Console.ReadLine());

            U = (Math.Log(k - y) + Math.Pow(y, 4)) / (Math.Pow(e, 4) + 2.355 * Math.Pow(k, 2));

            Console.WriteLine($"U = {U}");
        }
        public void Task4()
        {
            double G, w, y;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение w: ");
            w = Convert.ToDouble(Console.ReadLine());

            G = (9.33 * Math.Pow(w, 3) + Math.Sqrt(w)) / (Math.Log(y + 3.5) + Math.Sqrt(y));

            Console.WriteLine($"G = {G}");
        }
        public void Task5()
        {
            double D, a, t, e, y;

            e = 2.7;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение t: ");
            t = Convert.ToDouble(Console.ReadLine());

            D = (7.8 * Math.Pow(a, 2) + 3.52 * t) / (Math.Log(a + 2 * y) + Math.Pow(e, y));

            Console.WriteLine($"D = {D}");
        }
        public void Task6()
        {
            double L, i, y;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение i: ");
            i = Convert.ToDouble(Console.ReadLine());

            L = (0.81 * Math.Cos(i)) / (Math.Log(y) + 2 * Math.Pow(i, 2));

            Console.WriteLine($"L = {L}");
        }
        public void Task7()
        {
            double N, m, y;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение m: ");
            m = Convert.ToDouble(Console.ReadLine());

            N = (Math.Pow(m, 2) + 2.8 * m + 0.355) / (Math.Cos(2 * y) + 3.6);

            Console.WriteLine($"N = {N}");
        }
        public void Task8()
        {
            double T, t, y;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение t: ");
            t = Convert.ToDouble(Console.ReadLine());

            T = (2.37 * Math.Sin(t + 1)) / (Math.Sqrt(4 * Math.Pow(y, 2) - 0.1 * y + 5));

            Console.WriteLine($"T = {T}");
        }
        public void Task9()
        {
            double V, y, w;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение w: ");
            w = Convert.ToDouble(Console.ReadLine());

            V = (Math.Pow(y + 2 * w, 3)) / (Math.Log(y + 0.75));

            Console.WriteLine($"V = {V}");
        }
        public void Task10()
        {
            double Z, t, y;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение t: ");
            t = Convert.ToDouble(Console.ReadLine());

            Z = (2 * t + y * Math.Cos(t)) / (Math.Sqrt(y + 4.831));

            Console.WriteLine($"Z = {Z}");
        }
        public void Task11()
        {
            double D, y, n;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение n: ");
            n = Convert.ToDouble(Console.ReadLine());

            D = Math.Pow(y, 2) + (0.5 * n + 4.8) / (Math.Sin(y));

            Console.WriteLine($"D = {D}");
        }
        public void Task12()
        {
            double R, t, y;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение t: ");
            t = Convert.ToDouble(Console.ReadLine());

            R = (Math.Sin(Math.Pow(2 * t + 1, 2)) + 0.3) / (Math.Log(t + y));

            Console.WriteLine($"R = {R}");
        }
        public void Task13()
        {
            double A, y, e, h;

            e = 2.7;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение h: ");
            h = Convert.ToDouble(Console.ReadLine());

            A = (Math.Sin(2 * y + h) + Math.Pow(h, 2)) / (Math.Pow(e, h) + y);

            Console.WriteLine($"A = {A}");
        }
        public void Task14()
        {
            double P, e, y, h;

            e = 2.7;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение h: ");
            h = Convert.ToDouble(Console.ReadLine());

            P = (Math.Pow(e, y + 25) + 7.1 * Math.Pow(h, 3)) / (Math.Log(Math.Sqrt(y + 0.04 * h)));

            Console.WriteLine($"P = {P}");
        }
        public void Task15()
        {
            double F, y, j;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение j: ");
            j = Convert.ToDouble(Console.ReadLine());

            F = (2 * Math.Sin(0.354 * y + 1)) / (Math.Log(y + 2 * j));

            Console.WriteLine($"F = {F}");
        }
        public void Task16()
        {
            double W, t, r, y, e;

            Console.WriteLine("Введите значение t: ");
            t = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение r: ");
            r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            e = 2.7;

            W = (4 * Math.Pow(t , 3) + Math.Log(r)) / (Math.Pow(e , y + r) + 7.2 * Math.Sin(r));

            Console.WriteLine($"w = {W}");


        }
        public void Task17()
        {
            double H, y, n;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение n: ");
            n = Convert.ToDouble(Console.ReadLine());

            H = (Math.Pow(y , 2) - 0.8 * y + Math.Sqrt(y)) / (23.1 * Math.Pow(n , 2) + Math.Cos(n));

            Console.WriteLine($"H = {H}");
        }
        public void Task18()
        {
            double R, y, k;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение k: ");
            k = Convert.ToDouble(Console.ReadLine());

            R = (Math.Sqrt(Math.Sin(Math.Pow(y , 2)) + 6.835)) / (Math.Log(y + k) + 3 * Math.Pow(y , 2));

            Console.WriteLine($"R = {R}");
        }
        public void Task19()
        {
            double E, y, q;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение q: ");
            q = Convert.ToDouble(Console.ReadLine());

            E = (Math.Log(0.7 * y + 2 * q)) / (Math.Sqrt(3 * Math.Pow(y, 2) + 0.5 * y + 4));

            Console.WriteLine($"E = {E}");
        }
        public void Task20()
        {
            double K, t, l, y, e;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение t: ");
            t = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение l: ");
            l = Convert.ToDouble(Console.ReadLine());

            e = 2.7;

            K = (2 * Math.Pow(t , 2) + 3 * l + 7.2) / (Math.Log(y) + Math.Pow(e , 2 * t));

            Console.WriteLine($"K = {K}");
        }
        public void Task21()
        {
            double Q, k, p, x, d;

            Console.WriteLine("Введите значение k: ");
            k = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение p: ");
            p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение d: ");
            d = Convert.ToDouble(Console.ReadLine());

            Q = (Math.Sqrt(k + 2.6 * p * Math.Sin(k))) / (x - Math.Pow(d, 3));

            Console.WriteLine($"Q = {Q}");
        }
        public void Task22()
        {
            double S, y, t;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение t: ");
            t = Convert.ToDouble(Console.ReadLine());

            S = (4.351 * Math.Pow(y , 3) + 2 * t * Math.Log(t)) / (Math.Sqrt(Math.Cos(2) * y + 4.351));

            Console.WriteLine($"S = {S}");
        }
        public void Task23()
        {
            double R, d, e, y;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение d: ");
            d = Convert.ToDouble(Console.ReadLine());

            e = 2.7;

            R = (Math.Sin(Math.Pow(y , 2)) + 0.3 * d) / (Math.Pow(e, y) + Math.Log(d));
            Console.WriteLine($"R = {R}");
        }
        public void Task24()
        {
            double U, k, e, y;

            e = 2.7;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение k: ");
            k = Convert.ToDouble(Console.ReadLine());

            U = (Math.Log(2 * k + 4.3)) / (Math.Pow(e, k+y) + Math.Sqrt(y));

            Console.WriteLine($"U = {U}");
        }
        public void Task25()
        {
            double L, c, t;

            Console.WriteLine("Введите значение c: ");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение t: ");
            t = Convert.ToDouble(Console.ReadLine());

            L = Math.Cos(Math.Pow(c, 2)) + (3 * Math.Pow(t , 2) + 4) / (Math.Sqrt(c + t));

            Console.WriteLine($"L = {L}");
        }
        public void Task26()
        {
            double T, u, y;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение u: ");
            u = Convert.ToDouble(Console.ReadLine());

            T = (Math.Sin(2 * u)) / (Math.Log(2 * y + u));

            Console.WriteLine($"T = {T}");
        }
        public void Task27()
        {
            double Z, p, y;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение p: ");
            p = Convert.ToDouble(Console.ReadLine());

            Z = (Math.Sin(Math.Pow(p + 0.4 , 2))) / (Math.Pow(y , 2) + 7.325 * p);

            Console.WriteLine($"Z = {Z}");
        }
        public void Task28()
        {
            double W, v, e, y;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение v: ");
            v = Convert.ToDouble(Console.ReadLine());

            e = 2.7;

            W = (0.004 * v + Math.Pow(e , 2*y)) / (Math.Pow(e , y/2));

            Console.WriteLine($"W = {W}");
        }
        public void Task29()
        {
            double T, h, e, y;

            e = 2.7;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение h: ");
            h = Convert.ToDouble(Console.ReadLine());

            T = (0.355 * Math.Pow(h , 2) - 4.355) / (Math.Pow(e, y+h) + Math.Sqrt(2.7 * y));

            Console.WriteLine($"T = {T}");
        }
        public void Task30()
        {
            double N, y, p, e;

            e = 2.7;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение p: ");
            p = Convert.ToDouble(Console.ReadLine());

            N = (3* Math.Pow(y , 2) + Math.Sqrt(y + 1)) / (Math.Log(p + y) + Math.Pow(e, p));

            Console.WriteLine($"N ={N}");
        }
    }
}
