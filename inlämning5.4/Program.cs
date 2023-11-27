using System;
namespace inlämning5.__4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = new string[] { "Isak", "Thoe", "Theo", "Sj", "Mako" };
            for(int i = 0; i < namn.Length; i++)
            {
                Array.Sort(namn);
                Console.WriteLine(namn[i]);
            }
        }
    }
}