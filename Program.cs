namespace Assignment_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> count = new Dictionary<string, int>();
            string[] input = { "a", "b", "c", "a", "b" };

            foreach (string s in input)
            {
                if (!count.TryAdd(s, 1))
                {
                    count[s]++;

                }
            }

            Console.WriteLine();
            foreach (KeyValuePair<string, int> kvp in count)
            {
                Console.WriteLine("Key={0}, Count={1}",
                kvp.Key, kvp.Value);

            }
        }
    }
}
