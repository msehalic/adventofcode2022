static void Day1(string[] args)
        {
            int counter = 0;
            int internalSum = 0;
            int[] sum = new int[1000];
            foreach (string line in System.IO.File.ReadLines("test.txt"))
            {
                if (string.IsNullOrEmpty(line))
                {
                    Console.WriteLine("Sum of elf " + counter + " is: ****   " + internalSum + "****");
                    sum[counter] = internalSum;
                    counter++;
                    internalSum = 0;
                }
                else internalSum += int.Parse(line);

                var sortedList = sum.ToList();
                sortedList.Sort();
                Console.WriteLine("Elf with the highest yield is " + sortedList.Last());
                Console.WriteLine("Sum is: " + sortedList.TakeLast(3).Sum());
            }
        }