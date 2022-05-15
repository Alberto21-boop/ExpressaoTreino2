namespace Expressao00021;

public class ExercicicosExpressoes
{
    public static void Main(string[] args)
    {
        //[(18 + 3 · 2) ÷ 8 + 5 · 3] ÷ 6.
        int a = (((18 + 3 * 2) / 8) + 5 * 3) / 6;
        Console.WriteLine(a);

        //{[(8 · 4 + 3) ÷ 7 + (3 + 15 ÷ 5) · 3] · 2 – (19 – 7) ÷ 6} · 2 + 12.
        int b = (((8 * 4 + 3) / 7 + (3 + 15 / 5) * 3) * 2 - (19 - 7) / 6) * 2 + 12;
        Console.WriteLine(b);


    }
}