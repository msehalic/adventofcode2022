   static void Main(string[] args)
        {
            string input = System.IO.File.ReadAllText("day6.txt");
            int i;
            for (i = 3; i < input.Length; i++)
            {
                //replace start with 14 and range with i-13, 14 for part 2
                List<char> last4Chars = input.ToList().GetRange(i - 3, 4);
                if(last4Chars.Count == last4Chars.Distinct().Count())
                        break;
            }
                Console.WriteLine("First index is " + (i+1));
        }