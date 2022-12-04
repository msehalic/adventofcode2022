//part 1  
	    int totalSum = 0;
	    foreach (string line in System.IO.File.ReadLines("day3.txt"))
            {
                string firstPart = line.Substring(0, line.Length / 2);
                string secondPart = line.Substring(line.Length / 2, line.Length / 2);

                char commonItemType = firstPart.Intersect(secondPart).FirstOrDefault();

                if (Char.IsLower(commonItemType))
                    totalSum += (int)commonItemType - 96;
                else if (Char.IsUpper(commonItemType))
                    totalSum += (int)commonItemType - 38;
            }
            Console.WriteLine("Total sum is: " + totalSum);
//part 2
            int totalSum = 0;
            int index = 2;

            IEnumerable<string> lines = System.IO.File.ReadLines("day3.txt");
            while (index < lines.Count())
            {
                char commonItemType = lines.ElementAt(index).Intersect(lines.ElementAt(index - 1))
							    .Intersect(lines.ElementAt(index - 2)).FirstOrDefault();
                if (Char.IsLower(commonItemType))
                    totalSum += (int)commonItemType - 96;
                else if (Char.IsUpper(commonItemType))
                    totalSum += (int)commonItemType - 38;
                index += 3;
            }
            Console.WriteLine("Total sum is: " + totalSum);