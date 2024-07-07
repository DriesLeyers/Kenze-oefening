namespace Kenze
{
    public class Program
    {
        static void Main(string[] args)
        {
            var inputFile = "C:\\Users\\dries\\Documents\\GitHub\\Kenze-oefening\\Kenze\\Kenze\\input.txt";
            var words = File.ReadAllLines(inputFile);
            var wordSet = new HashSet<string>(words);

            var valid = FindValids(wordSet);
            PrintHashSet(valid);
        }

        public static HashSet<string> FindValids(HashSet<string> words)
        {
            var valid = new HashSet<string>();

            foreach (var x in words)
                foreach (var y in words)
                    if (x.Length + y.Length == 6)
                        if (words.Contains(x + y))
                            valid.Add($"{x}+{y}={x + y}");

            return valid;
        }

        public static void PrintHashSet(HashSet<string> validList)
        {
            foreach (var combination in validList)
                Console.WriteLine(combination);
        }
    }
}
