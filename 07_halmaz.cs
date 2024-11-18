//Halmaz -> Rendezett és ismétlődés nélküli tömb/lista
//Első  feladat: Hozzunk hozzá létre tömböt, amiben el tudunk számolni 5 számot.
//Az első vizsgált feltétel: Az ismétlődések kizárása lesz. Ha az elem már benne van, akkor
//nem rakjuk hozzá az elemet újra.
//int[] halmaz = new int[5];
//int db = 0;
//Random rnd = new Random();
//while (db < 5)
//{
//    int szam = rnd.Next(1, 91);
//    //halmaz.Contains -> A halmaz tartalmazza-e az adott számot (! az elején azt vizsgálja, hogy
//    //NEM tartalmazza)
//    if (!halmaz.Contains(szam))
//    {
//        halmaz[db] = szam;
//        db++;
//    }
//}
////Számok megjelenítése konzolon
//foreach (int i in halmaz)
//{
//    Console.WriteLine(i);
//}
//Rendezés -> Minimum kiválasztásos rendezés
//X - [2, 3, 5, 7, 9, 10]
//for (int i = 0; i < halmaz.Length - 1; i++)
//{
//    int min = i;
//    for (int j = i + 1; j < halmaz.Length; j++)
//    {
//        if (halmaz[j] < halmaz[min])
//        { 
//            min = j;
//        }
//    }
//    int tmp = halmaz[i];
//    halmaz[i] = halmaz[min];
//    halmaz[min] = tmp;
//}
////Kiíratás
//foreach(int i in halmaz)
//{
//    Console.WriteLine(i);
//}

//0. Feladat: Generálj le 30 darab sorsolást (30x5 számot halmazként)
//1. Feladat: Határozd meg, melyik számot hányszor húzták ki a sorsolások során
//2. Feladat: Melyik számokat húzták ki legtöbbször!

int[] numbers = new int[90];
for (int num = 0; num < 30;  num++)
{
    int[] halmaz = new int[5];
    int db = 0;
    Random rnd = new Random();
    while (db < 5)
    {
        int szam = rnd.Next(1, 91);
        //halmaz.Contains -> A halmaz tartalmazza-e az adott számot (! az elején azt vizsgálja, hogy
        //NEM tartalmazza)
        if (!halmaz.Contains(szam))
        {
            halmaz[db] = szam;
            numbers[szam-1]++;
            db++;
        }
    }
    for (int i = 0; i < halmaz.Length - 1; i++)
    {
        int min = i;
        for (int j = i + 1; j < halmaz.Length; j++)
        {
            if (halmaz[j] < halmaz[min])
            {
                min = j;
            }
        }
        int tmp = halmaz[i];
        halmaz[i] = halmaz[min];
        halmaz[min] = tmp;
    }
}
for (int i = 0; i  < numbers.Length; i++)
{
    Console.WriteLine($"{i + 1} - {numbers[i]}");
}

int max = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}
List<int> maximums = new List<int>();
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == max)
    {
        maximums.Add(i + 1);
    }
}
Console.WriteLine("Legnagyobb kihúzott számok:");
foreach (int i in maximums)
{
    Console.WriteLine(i);
}