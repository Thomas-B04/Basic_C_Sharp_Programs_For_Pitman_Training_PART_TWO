using System;

    class Program
{
    static void Main(string[] args)
    {
        //int[] test_scores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //for (int i = 0; i < test_scores.Length; i++)
        //{
        //    if (test_scores[i] > 85)
        //    {
        //        Console.WriteLine($"Passing test score: {test_scores[i]}");
        //    }
        //}
        //Console.ReadLine();

        //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

        //for (int n = 0; n < names.Length; n++)
        //{
        //    Console.WriteLine(names[n]);
        //}
        //Console.ReadLine();

        //List<int> test_scores = [98, 99, 85, 70, 82, 34, 91, 90, 94];

        //foreach (int score in test_scores)
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine($"Passing test score: {score}");
        //    }
        //}

        //List<string> names = ["Jesse", "Erik", "Daniel", "Adam"];

        //foreach (string name in names)
        //{
        //    if (name == "Jesse")
        //    {
        //        Console.WriteLine(name);
        //    }
        //}

        List<int> test_scores = [98, 99, 85, 70, 82, 34, 91, 90, 94];
        List<int> passing_scores = new List<int>();

        foreach (int score in test_scores)
        {
            if (score > 85)
            {
                passing_scores.Add(score);
            }
        }

        Console.WriteLine(passing_scores.Count);

    }
}

