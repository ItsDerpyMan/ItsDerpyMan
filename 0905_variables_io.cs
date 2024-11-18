namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Változók - Variables áttekintése
            //a = "Alma" Python esetében működik, DE
            //A Python Típusfüggetlen nyelv -> A Python futásidőben dönti el egy változó típusát
            //A C# Erősen típusos nyelv -> A C# esetében előre meg kell határozni a változó típusát
            //Numerikus változó típusok
            //Egész szám típusú változók
            //int -> Integer szó rövidítése, ami egy 32 bites egész számot tárol el.
            int szam = 42;
            //uint -> Unsigned Integer rövidítése, ami egy 32 bites POZITÍV egész számot tárol el.
            uint pozszam = 152;
            //byte -> Bitkód, 8 bites pozitív egész számot tárol
            byte kisszam = 52;
            //long -> 64 bites egész szám (integer64)
            long nagyszam = 6666666666666;

            //Valós szám típusra
            //Float -> Floating point number (lebegőpontos szám), 4 byte a mérete -> 32 bit
            //Ennél a típusnál a szám végén jelezni kell, hogy lebegőpontos szám! (35 helyett 35f)
            float valszam = 15.05f;
            //Double -> Kétszeres pontosságú lebegőpontos szám, 8 byte a mérete -> 64 bit
            double ketszeres = 69.96;
            //Decimal -> Valós szám 16 byte formában -> 128 bites
            decimal tizes = 128.128M;

            //Szöveg típusú változó
            //Char típus -> egy karakter tárolására való változó
            //'' -> Egy karaktert jelöl
            //"" -> Szöveget jelöl
            char karakter = 'A';
            //String típus -> Egy szöveg tárolására való változó (Összetett adattípus)
            string szoveg = "My little pony, dancing on rainbow!";

            //Logikai típusú változó
            //Boolean típus -> Egy logikai érték tárolására való változó
            //1 bites változó
            bool igaze = "Ladisz" == "Buzi";
            bool hamise = 0 > 15;

            //Következő alkalmaktól... További összetett adatszerkezetek jönnek
            //Következő órán jönnek a vezérlési szerkezetek
            //Elágazások, ciklusok

            //IO műveletek
            //Egy sor kiírása a konzolra (A kurzort a sor végén hagyja!)
            Console.Write("KFC");
            //Egy sor kiírása a konzolra (A kurzort a következő sor elejére helyezi!)
            Console.WriteLine("Hello, World!");  
            Console.WriteLine(szoveg);
            //Egy sor bekérése a konzolról, a vége egy ENTER leütése kell legyen!
            Console.ReadLine();
            //Egy billentyű kér be / leütésére vár
            Console.ReadKey();
        }
    }
}
