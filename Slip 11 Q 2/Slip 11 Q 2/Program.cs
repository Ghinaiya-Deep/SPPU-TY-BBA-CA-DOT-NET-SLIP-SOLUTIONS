using System;

class Fruit
{
    public int totalFruits;
}

class Apples : Fruit
{
    public int CountApples(int count)
    {
        totalFruits += count;
        return count;
    }
}

class Mangoes : Fruit
{
    public int CountMangoes(int count)
    {
        totalFruits += count;
        return count;
    }
}

class Program
{
    static void Main()
    {
        Apples apple = new Apples();
        Mangoes mango = new Mangoes();

        int a = apple.CountApples(5);     // Assume 5 apples
        int m = mango.CountMangoes(7);    // Assume 7 mangoes

        int total = a + m;

        Console.WriteLine("Total Apples: " + a);
        Console.WriteLine("Total Mangoes: " + m);
        Console.WriteLine("Total Fruits in Basket: " + total);
    }
}
