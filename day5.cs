 static void Main(string[] args)
        {
            List<List<char>> heapList = new List<List<char>>();
            //seeding the list
            heapList.Add(new List<char> { 'T', 'D', 'W', 'Z', 'V', 'P' });
            heapList.Add(new List<char> { 'L', 'S', 'W', 'V', 'F', 'J', 'D' });
            heapList.Add(new List<char> { 'Z', 'M', 'L', 'S', 'V', 'T', 'B', 'H' });
            heapList.Add(new List<char> { 'R', 'S', 'J' });
            heapList.Add(new List<char> { 'C', 'Z', 'B', 'G', 'F', 'M', 'L', 'W' });
            heapList.Add(new List<char> { 'Q', 'W', 'V', 'H', 'Z', 'R', 'G', 'B' });
            heapList.Add(new List<char> { 'V', 'J', 'P', 'C', 'B', 'D', 'N' });
            heapList.Add(new List<char> { 'P', 'T', 'B', 'Q' });
            heapList.Add(new List<char> { 'H', 'G', 'Z', 'R', 'C' });

            foreach (string line in System.IO.File.ReadLines("day5.txt"))
            {
                string parsedInput = Regex.Replace(line, "[^0-9]", " ");
                parsedInput = Regex.Replace(parsedInput, @"\s+", " ").Trim();
                int[] arraysToSwap = Array.ConvertAll(parsedInput.Split(' '), int.Parse);
                var elementsToMove = heapList[arraysToSwap[1] - 1].TakeLast(arraysToSwap[0]);
                heapList[arraysToSwap[2] - 1].AddRange(elementsToMove); // reverse on elementsToMove needed in part 1
                heapList[arraysToSwap[1] - 1].RemoveRange(heapList[arraysToSwap[1] -1].Count - arraysToSwap[0], arraysToSwap[0]);
            }
            for (int i = 0; i < heapList.Count(); i++)
            Console.WriteLine("Top element of the list looks like this: " + heapList[i].LastOrDefault());
        }