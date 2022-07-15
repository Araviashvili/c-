using System;


class coin
{

    static int[] tetri = { 1, 5, 10, 20, 50 };
    static int n = tetri.Length;

    static void findMin(int V)
    {
        List<int> ans = new List<int>();
        for (int i = n - 1; i >= 0; i--)
        {

            while (V >= tetri[i])
            {
                V -= tetri[i];
                ans.Add(tetri[i]);
            }
        }

        for (int i = 0; i < ans.Count; i++)
        {
            Console.Write(" " + ans[i]);
        }
    }

    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the amount of ");
        int n =int.Parse(Console.ReadLine());
        Console.Write("Following is minimal number " +
                      "of change for " + n + ": ");

        findMin(n);
    }
}