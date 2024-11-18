namespace _03_Iterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ciklusok
            //C# esetében 4 ciklusfajtát különbözetünk meg:
            //-Elöltesztelős ciklus, amely a belépési feltételt vizsgálja a kódismétléshez
            //-Hátultesztelős ciklus, amely a kilépési feltételt vizsgálja a kódismétléshez
            //-Számlálós ciklus, amely egy adott iterációt X lépésszer végrehajt
            //-Gyűjteménybejáró ciklus, amely egy adott összetett adatszerkezet minden tagját
            //érinti és felhasználja

            //1. feladat: Írj egy olyan ciklust, ami kiírja a számokat 1-től 10-ig.
            //Megoldás I.
            //Kezdőérték adás
            //int i = 0;
            ////Bennmaradási feltétel megadása
            //while (i < 10)
            //{
            //    Console.WriteLine(i + 1);
            //    //Ciklusváltozó inkrementálása (növelése)
            //    i++;
            //}

            ////Megoldás II.
            //for (int j = 0; j < 10; j++)
            //{
            //    Console.WriteLine(j + 1);
            //}

            //2. feladat: Írj egy olyan programot, ami bekér a felhasználótól egy
            //felhasználónevet és jelszót. Ha a felhasználó azt a felhasználó nevet
            //írja be, hogy "tarnabena" és a jelszónak azt írja be, hogy "milyenigaz"
            //akkor vége a ciklusnak és kiírja, hogy "Belépés engedélyezve!". Minden más esetben
            //bekéri újra a felhasználó nevet és jelszót.
            //string fnev = string.Empty;
            //string pwd = string.Empty;
            //do
            //{
            //    Console.Write("Add meg a felhasználónevet: ");
            //    fnev = Console.ReadLine();
            //    Console.Write("Add meg a jelszavadat is: ");
            //    pwd = Console.ReadLine();
            //    //A ciklus akkor ér véget, ha a kimenete a feltételnek false-hamis értékké válik!
            //} while (!(fnev == "tarnabena" && pwd == "milyenigaz"));

            //Random r = new Random(); //Készít egy randomszám generátor példányt
            //Console.WriteLine(r.Next(1, 6)); //r.Next generál számot 1 és 5 között
            //r.Next esetén az intervallum balról zárt, jobbról nyitott [1, 6[ intervallum

            //3. Feladat: Generálj le egy véletlen számot 1 és 100 között. Kérj be a felhasználó-
            //tól egy számot és írd ki, hogy a véletlen számnál ez kisebb, nagyobb vagy egyenlő.
            //Ezt ismételje a program addig, amíg a felhasználó ki nem találta a véletlen számot.

            //Random rnd = new Random();
            //int vszam = rnd.Next(1, 101);
            //int tipp = 0;
            //do
            //{
            //    Console.Write("Kérem a tippet: ");
            //    tipp = int.Parse(Console.ReadLine());
            //    if (tipp < vszam)
            //    {
            //        Console.WriteLine("A gondolt szám nagyobb!");
            //    }
            //    else if (tipp > vszam)
            //    {
            //        Console.WriteLine("A gondolt szám kisebb!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Eltaláltad!");
            //    }

            //} while (vszam != tipp);

            //4. Feladat: A rendszer generáljon egy X-Y koordinátapárt 1 és 100 között. A feladat, hogy a fel-
            //használótól kérjünk be koordináta párokat, és írjuk ki, milyen messze van a felhasználó által
            //megadott pont a rendszer által generált ponttól. Addit kérjük be az értékeket, amíg a felhasz-
            //náló el nem találja mind a két koordinátát.
            //Két pont távolsága: gyök((x1-x2)^2+(y1-y2)^2)
            //Math.Pow(x,0.5) v. Math.Sqrt()

            Random r2 = new Random();
            int gx = r2.Next(1, 101);
            int gy = r2.Next(1, 101);
            int tippx = 0;
            int tippy = 0;
            double d = Math.Sqrt(Math.Pow(gx - tippx, 2) + Math.Pow(gy - tippy, 2));
            do
            {
                Console.Write("Kérem az x koordinátát: ");
                tippx = int.Parse(Console.ReadLine());
                Console.Write("Kérem az y koordinátát: ");
                tippy = int.Parse(Console.ReadLine());
                d = Math.Sqrt(Math.Pow(gx - tippx, 2) + Math.Pow(gy - tippy, 2));
                if (d > 0)
                {
                    //d:0.00 -> Formázd úgy, hogy két tizedes jegyre!
                    Console.WriteLine($"Nem talált, a távolság: {d:0.00}");
                }
                else
                {
                    Console.WriteLine("Telitalálat!");
                }
            } while (d > 0);
        }
    }
}
