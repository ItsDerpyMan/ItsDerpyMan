//Ha kiveszed a jelölőt a Top level statement rész elől, akkor kapsz egy tiszta felületet, mint az alábbi, benne
//egy darab Console.WriteLine-al. Ilyenkor hasonló a felépítése a programnak, mint ami a Pythonnál is ismert volt

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/* Neumann elvei a programozásra:
 * Minden program leírható az alábbi három vezérlési szerkezet felhasználásával:
 * - Szekvencia: Utasítások véges sorozata (Pl.: Értékadás, kiírás, beolvasás, matematikai művelet...)
 * - Szelekció v. elágazások: Egy adott feltétel alapján a program más-más ágat hajt végre. (if, switch)
 * - Iteráció v. ciklusok: Egy adott kódsor ismétlése a feltételnek megfelelően. (for, while, until, foreach)
 * 
 * Teszteléshez az összetett adatnak stringet használunk (egyelőre)
 */

//1. feladat: Írj egy programot, ami kiírja, hogy a felhasználó által megadott szám páros szám-e. A páratlan
//számokra ne írjon ki semmit!

Console.Write("Add meg a számot: ");
//int.Parse -> string típusú változóból készít int típusú változót (CSAK stringet kezel!)
//Convert.ToInt32 -> Bármilyen értéket "kényszerít" int típusú értékké
int szam1 = int.Parse(Console.ReadLine());
//if (feltétel) { } a felépítése
//A % művelet adja vissza a két szám osztási maradékát (pl. 2 % 2 = 0, tehát a szám páros)
if (szam1 % 2 == 0)
{
    Console.WriteLine("A szám páros!");
}

//2. feladat: Írj egy programot, ami kiírja, hogy a felhasználó által megadott szám páros szám-e, vagy páratlan.

Console.Write("Add meg a számot: ");
int szam2 = int.Parse(Console.ReadLine());
if (szam2 % 2 == 0)
{
    Console.WriteLine("A szám páros!");
}
//Az else ág az, ami akkor fut le, ha az if feltétele nem teljesül
else
{
    Console.WriteLine("A szám páratlan!");
}

//3. feladat: Írj egy programot, ami kiírja, hogy a felhasználó által megadott szám osztható-e 3-al, és ha nem,
//mennyi az osztás madadéka!

//Megoldás 1.
Console.Write("Add meg a számot: ");
int szam3 = int.Parse(Console.ReadLine());
if (szam3 % 3 == 1)
{
    Console.WriteLine("A szám nem osztható hárommal, maradék: 1!");
}
//Ha akarunk az első if-hez képest új feltételt vizsgálni, azt további else if-ekkel tehetjük meg.
else if (szam3 % 3 == 2)
{
    Console.WriteLine("A szám nem osztható hárommal, maradék: 2!");
}
//Ilyenkor az else az a "Minden más esetben ezt írd ki... " elvet jelenti.
else
{
    Console.WriteLine("A szám osztható hárommal maradék nélkül!");
}

//Megoldás 2.
Console.Write("Add meg a számot: ");
int szam4 = int.Parse(Console.ReadLine());

if (szam4 % 3 == 0)
{
    Console.WriteLine("A szám osztható hárommal maradék nélkül!");
}
else
{
    //$ egy string előtt azt jelenti, hogy benne a kapcsoszárójelek paramétert jelölnek, amit be kell illesztenie
    Console.WriteLine($"A szám nem osztható hárommal, maradék: {szam4 % 3}!");
}

//4. feladat: Írj egy programot, ami kiírja, hogy a felhasználó által megadott szám osztható-e 5-el, és ha nem,
//mennyi az osztás madadéka! Oldjátok meg if-ekkel is ÉS nézzétek meg, hogyan működik a switch utasítás és azzal
//is oldjátok meg!

//Megoldás 1.
Console.Write("Add meg a számot: ");
int szam5 = int.Parse(Console.ReadLine());

if (szam5 % 5 == 0)
{
    Console.WriteLine("A szám osztható öttel maradék nélkül!");
}
else
{
    //$ egy string előtt azt jelenti, hogy benne a kapcsoszárójelek paramétert jelölnek, amit be kell illesztenie
    Console.WriteLine($"A szám nem osztható öttel, maradék: {szam5 % 5}!");
}

//Megoldás 2.
//switch-be kerül az az érték, aminek szeretnénk vizsgálni az értékét
switch (szam5 % 5)
{
    //case után beírjuk a konkrét értéket, amit vizsgálunk.
    case 1: Console.WriteLine("A szám nem osztható 5-el, maradék az 1!");
        //break jelzi egy case végét mindig!
        break;
    case 2: Console.WriteLine("A szám nem osztható 5-el, maradék az 2!");
        break;
    case 3: Console.WriteLine("A szám nem osztható 5-el, maradék az 3!");
        break;
    case 4: Console.WriteLine("A szám nem osztható 5-el, maradék az 4!");
        break;
    //default-ba kerül a "minden más esetben..."
    default: Console.WriteLine("A szám osztható 5-el maradék nélkül!");
        break;
}

//Megoldás 3.
switch (szam5 % 5)
{
    case 0: Console.WriteLine("A szám osztható 5-el maradék nélkül!");
        break;
    default: Console.WriteLine($"A szám nem osztható 5-el, maradék: {szam5 % 5}!");
        break;
}

//Utolsó feladat: Kérj be a felhasználótól egy ágazati alapvizsga eredményt százalékban!
//Írj rá elágazás-//rendszert, ami kiírja, hogy az adott százalék hányas érdemjegyet ér.
//Százalékhatárok: 0-39 -> 1; 40-49 -> 2; 50-59 -> 3; 60-79 -> 4; 80-100 -> 5
//Utána írj egy olyan switch elágazást, ami megkapja az érdemjegyet számként (1-5)
//és kiírja az érdemjegyet//szövegesen: 1 -> elégtelen; 2 -> elégséges; 3 -> közepes;
//4 -> jó; 5 -> jeles

Console.Write("Add meg az eredményt: ");
int szazalek = int.Parse(Console.ReadLine());
int jegy = 0;
if (szazalek < 40)
{
    jegy = 1;
}
else if (szazalek < 50)
{
    jegy = 2;
}
else if (szazalek < 60)
{
    jegy = 3;
}
else if (szazalek < 80)
{
    jegy = 4;
}
else
{
    jegy = 5;
}

switch (jegy)
{
    case 1: Console.WriteLine("A vizsga eredménye: Elégtelen(1)");
        break;
    case 2:
        Console.WriteLine("A vizsga eredménye: Elégséges(2)");
        break;
    case 3:
        Console.WriteLine("A vizsga eredménye: Közepes(3)");
        break;
    case 4:
        Console.WriteLine("A vizsga eredménye: Jó(4)");
        break;
    default:
        Console.WriteLine("A vizsga eredménye: Jeles(5)");
        break;
}