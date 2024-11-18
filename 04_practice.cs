namespace _04_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Feladat: Pozitív vagy negatív szám :D
            //Console.Write("Adj meg egy számot: ");
            ////Adatbekérés
            //int szam = int.Parse(Console.ReadLine());
            //if (szam == 0)
            //{
            //    Console.WriteLine("A szám nulla");
            //}
            //else if (szam > 0) 
            //{
            //    Console.WriteLine("A szám pozitív");
            //}
            //else
            //{
            //    Console.WriteLine("A szám negatív");
            //}

            //2. Feladat: Páros vagy páratlan
            //Console.Write("Adj meg egy számot: ");
            ////Adatbekérés
            //int szam = int.Parse(Console.ReadLine());
            //if (szam % 2 == 0 )
            //{
            //    Console.WriteLine("A szám páros");
            //}
            //else 
            //{ 
            //    Console.WriteLine("A szám páratlan"); 
            //}

            //3. Feladat: Számok oszthatósága 3-mal és 5-tel 
            //Console.Write("Adj meg egy számot: ");
            ////Adatbekérés
            //int szam = int.Parse(Console.ReadLine());
            //if (szam % 3 == 0 && szam % 5 == 0)
            //{
            //    Console.WriteLine("A szám osztható 3-al és 5-el is");
            //}
            //else if (szam % 3 == 0)
            //{
            //    Console.WriteLine("A szám osztható 3-al");
            //}
            //else if (szam % 5 == 0)
            //{
            //    Console.WriteLine("A szám osztható 5-el");
            //}
            //else
            //{
            //    Console.WriteLine("A szám nem osztható egyikkel sem");
            //}

            //4. Feladat: Számok összege 1-től N-ig
            //sum = sum0 (kezdőérték)
            //ciklus i <- 1-től N-ig (N = elemek száma)
            //  sum = sum +* X[i]
            //ciklus vége
            //ki: sum

            //Console.Write("Adj meg egy számot: ");
            ////Adatbekérés
            //int szam = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 0; i < szam; i++)
            //{
            //    sum += i + 1;
            //}
            //Console.WriteLine($"Az összeg {sum}");

            //5. Feladat: Szorzótábla
            //Console.Write("Adj meg egy számot: ");
            ////Adatbekérés
            //int szam = int.Parse(Console.ReadLine());
            //for (int i = 0; i < 10; i++) 
            //{
            //    Console.WriteLine($"{szam} * {i + 1} = {szam * (i + 1)}");
            //}

            //6. Feladat: Faktoriális számítás
            //Console.Write("Adj meg egy számot: ");
            ////Adatbekérés
            //int szam = int.Parse(Console.ReadLine());
            //int sum = 1;
            //for (int i = 0; i < szam; i++)
            //{
            //    sum *= i + 1;
            //}
            //Console.WriteLine($"{szam}! = {sum}");

            //7. Feladat: Pénzváltás
            //Console.Write("Adj meg egy számot: ");
            ////Adatbekérés
            //int szam = int.Parse(Console.ReadLine());
            //int db200 = szam / 200;
            //szam = szam % 200;
            //int db100 = szam / 100;
            //szam = szam % 100;
            //int db50 = szam / 50;
            //szam = szam % 50;
            //Console.WriteLine($"200: {db200}, 100: {db100}, 50: {db50}, maradék: {szam}");

            //8. Feladat: Térfogat számítás
            //Console.Write("Kérem az első oldalt: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Kérem a második oldalt: ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("Kérem a harmadik oldalt: ");
            //int c = int.Parse(Console.ReadLine());
            //Console.WriteLine($"A test térfogata: {a * b * c}");

            //9. Feladat: Átlagszámítás
            //Console.Write("Kérem az első számot: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Kérem a második számot: ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("Kérem a harmadik számot: ");
            //int c = int.Parse(Console.ReadLine());
            //Console.WriteLine($"A három szám átlaga: {(a + b + c) / 3.0}");

            //10. Feladat: Számok fordított sorrendben
            //Console.Write("Adj meg egy számot: ");
            ////Adatbekérés
            //int szam = int.Parse(Console.ReadLine());
            //for (int i = szam - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(i + 1);
            //}

            //11. Feladat: Tökéletes szám ellenőrzése
            //6 = (1, 2, 3) => 1 + 2 + 3 = 6, tehát a 6 tökéletes szám
            //1 2 3 4 5
            //Console.Write("Adj meg egy számot: ");
            ////Adatbekérés
            //int szam = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i < szam; i++)
            //{
            //    if (szam % i == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //if (sum == szam)
            //{
            //    Console.WriteLine($"A {szam} tökéletes szám.");
            //}
            //else
            //{
            //    Console.WriteLine($"A {szam} nem tökéletes szám.");
            //}

            //12. Feladat: Számsorozat előállítása és ellenőrzése
            //Console.Write("Kérem a kezdőértéket: ");
            //int k = int.Parse(Console.ReadLine());
            //Console.Write("Kérem a záró értéket: ");
            //int z = int.Parse(Console.ReadLine());
            //if (k < z)
            //{
            //    for (int i = k; i <= z; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.Write($"{i} ");
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("A kezdőértéknek kisebbnek kell lennie, mint a záróérték!");
            //}

            //13. Feladat: Prímszám ellenőrzése
            //Console.Write("Adj meg egy számot: ");
            ////Adatbekérés
            //int szam = int.Parse(Console.ReadLine());
            //bool prim = true;
            //for (int i = 2; prim == true && i < szam; i++)
            //{
            //    if (szam % i == 0)
            //    {
            //        prim = false;
            //    }
            //}
            //if (prim)
            //{
            //    Console.WriteLine("A szám prím szám!");
            //}
            //else
            //{
            //    Console.WriteLine("A szám nem prím szám!");
            //}

            //14. Feladat: Fordított szöveg
            //Console.Write("Kérlek add meg a szöveget: ");
            //string szoveg = Console.ReadLine();
            //for (int i = szoveg.Length - 1; i >= 0; i--)
            //{
            //    Console.Write($"{szoveg[i]}");
            //}

            //15. Feladat: Számjegyek összege
            //Console.Write("Kérlek add meg a számot: ");
            //string szoveg = Console.ReadLine();
            //int sum = 0;
            //for (int i = 0; i < szoveg.Length; i++)
            //{
            //    sum += int.Parse(szoveg[i].ToString());
            //}
            //Console.WriteLine($"A számjegyek összege: {sum}");

            //15+1. Feladat: Fibonacci sorozat
            //0 1 1 2 3 5 8 13 ...
            Console.Write("Adj meg egy számot: ");
            //Adatbekérés
            int szam = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;

            Console.Write($"{a} {b} ");

            for (int i = 0; i < szam; i++)
            {
                int c = a + b;
                Console.Write($"{c} ");
                a = b;
                b = c;
            }
        }
    }
}
