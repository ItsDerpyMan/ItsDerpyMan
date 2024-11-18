//Tömbök
//Változó létrehozása és értékadása
int a = 0;
//Tömb létrehozása
//Változó (tömb) deklarálása
int[] arr;
//Tömb inicializálása -> 10 elemű tömb lefoglalása
arr = new int[10];
//Tömb deklarálás és inicializálás egyben
int[] szamok = new int[10];
//Tömb deklarálás és inicializálás értékadással
int[] parosszamok = new int[] { 2, 4, 6, 8, 10, 12 };
//Console.WriteLine(parosszamok[5]);
//Írjunk programot, ami az arr tömböt feltölti 10 darab vélet-
//len számmal 1 és 100 között, majd kiírja a számok átlagát.
Random r = new Random();
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = r.Next(1, 101);
    sum += arr[i];
    Console.WriteLine(arr[i]);
}
Console.WriteLine($"A számok átlaga: {(double)sum / arr.Length}");
//Tömbök dimenziói
//Két dimenziós tömb
int[,] matrix = new int[10, 10];
//Feladat: Írj programot, ami az előbbi matrix nevű változóba eltárolja a 
//szorzótáblát 1x1-től egészen 10x10 értékig. ([0, 0] -> 1 x 1, [0, 1] -> 1 x 2)
for  (int i = 0;i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = (i + 1) * (j + 1);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
//Listák
//Deklarálás és inicializálás egyben
List<int> list = new List<int>();
for (int i = 0; i < arr.Length; i++)
{
    list.Add(arr[i]);
}
//Add -> Lista végére fűz, Inset -> Adott indexű vagy sorszámú helyre szúr
list.Insert(0, 10);
//Remove -> Adott elem törlése
list.Remove(10);
//RemoveAt -> Adott sorszámú elem törlése
list.RemoveAt(0);
//Clear -> Törli a teljes lista tartalmát
list.Clear();
//Feladat: Kérj be egy diák nevet, majd kérd be, hogy hány darab jegyet osszunk
//ki neki. Tárolja el a jegyeit egy megfelelő adatszerkezetben és utána írja ki
//az alábbi adatokat:
//(A jegyeket random sorsoljuk ki!)
//A diák neve: X.Y
//A diák jegyeinek száma: 10
//A diák jegyei: X  X   X   X   X...
// A diák átlaga:
//A diák legrosszabb jegye:
//A diák legjobb jegye:
//A legtöbb jegy az alábbi: 