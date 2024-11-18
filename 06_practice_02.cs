namespace _06_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Feladat: Hozz létre egy egész számok tárolására alkalmas listát
            //,melybe tölts fel véletlen számokat 1 és 100 között. A véletlen
            //számoknak a darabszáma az legyen 10000
            //majd írd ki a következő értékeket:
            //1, Mi az elemek átlaga
            //2, Mi az elemek közül a legnagyobb érték
            //3, Melyik elem ismétlődik a legtöbbször
            //4, Hozz létre egy olyan 100 elemű tömböt, amiben eltárolod,
            //hogy melyik szám (1-100-ig)az előző tömbben hányszor fordult elő.

            //Lista létrehozása és tárolása
            List<int> list = new List<int>();
            //Véletlenszám generátor létrehozása
            Random r = new Random();
            //Feltöltés
            for (int i = 0; i < 10000; i++)
            {
                list.Add(r.Next(1, 101));
            }
            //Átlagszámítás
            double sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            Console.WriteLine($"Átlag: {sum / list.Count}");
            //Legnagyobb elem
            int max = 0;
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] > list[max])
                {
                    max = i;
                }
            }
            Console.WriteLine($"A legnagyobb szám: {list[max]}");
            //100 elemű tömb az előfordulásokkal
            int[] elofordulas = new int[100];
            for (int i = 0;i < list.Count; i++)
            {
                for (int j = 0; j < elofordulas.Length; j++)
                {
                    if (list[i] == (j + 1))
                    {
                        elofordulas[j] += 1;
                    }
                }
            }
            //A legtöbbet előforduló elem
            int legtobb = 0;
            for (int i = 0; i < elofordulas.Length; i++)
            {
                if (elofordulas[i] > elofordulas[legtobb])
                {
                    legtobb = i;
                }
            }
            Console.WriteLine($"A legtöbbet előforduló szám: {legtobb + 1}");

            
            
            //Feladat: Hozz létre két 25 elemű tömböt, melyeket tölts fel 1 és 
            //100 közötti véletlen számokkal. A két tömbnek írd ki:
            //1, Az unióját (Azaz a két tömböt olvaszd össze)
            //2, A metszetét (A két tömbből írd ki, amelyik mind a kettőben
            //jelen van)
        }
    }
}
