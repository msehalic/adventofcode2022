          int totalSum = 0;
            foreach (string line in System.IO.File.ReadLines("day4.txt"))
            {
                int[] firstSection = Array.ConvertAll(line.Split(',').First().Split('-'), int.Parse);
                int[] secondSection = Array.ConvertAll(line.Split(',').Last().Split('-'), int.Parse);
                var firstSectionRange = Enumerable.Range(firstSection.Min(), firstSection.Max() - firstSection.Min() + 1);
                var secondSectionRange = Enumerable.Range(secondSection.Min(), secondSection.Max() - secondSection.Min() + 1);
                bool firstContainsSecond = firstSectionRange.Contains(secondSection.Min()) && firstSectionRange.Contains(secondSection.Max());
                bool secondContainsFirst = secondSectionRange.Contains(firstSection.Min()) && secondSectionRange.Contains(firstSection.Max());
                totalSum += (firstContainsSecond || secondContainsFirst) ? 1 : 0;
            }
            Console.WriteLine("Total sum is: " + totalSum);