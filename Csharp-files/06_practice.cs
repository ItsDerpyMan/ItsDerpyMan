namespace _06_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Számított értékek (Összeg summary, átlag summary / db, Legnagyobb max)
            double summary = 0;
            int db = 0;
            int max = int.MinValue;
            //Addig fut, amíg ez igaz
            bool fut = true;
            do
            {
                Console.Write("Add meg a számot: ");
                int tmp = int.Parse(Console.ReadLine());
                //Ha 0-át ad meg, akkor már nem fut tovább, csak kiír
                if (tmp == 0)
                {
                    fut = false;
                }
                else
                {
                    summary += tmp;
                    db++;
                    if (max < tmp)
                    {
                        max = tmp;
                    }
                }
            }while (fut != false);

            Console.WriteLine($"A számok összege: {summary}");
            Console.WriteLine($"A számok átlaga: {summary / db}");
            Console.WriteLine($"A legnagyobb szám: {max}");
        }
    }
}
