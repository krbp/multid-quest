namespace Quetes_boucle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] uniD = new int[3, 3]
            {
                 {1, 2, 3}, {2, 3, 4 }, {3, 4, 5 }
            };

            int[][] irregD = new int[3][]
            {
                new int[] { uniD[0, 0], uniD[0, 1], uniD[0, 2] },
                new int[] { uniD[1, 1], uniD[1, 2] },
                new int[] { uniD[2, 2] }
            };

            irregD[0][0] = uniD[0, 0];
            Console.WriteLine($"{irregD[0][0]}{irregD[0][1]}{irregD[0][2]}\n{irregD[1][0]}{irregD[1][1]}\n{irregD[2][0]}");
        }
    }
}
