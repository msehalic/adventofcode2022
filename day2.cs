static void Day2(string[] args)
        {
            int totalSum = 0;
            foreach (string line in System.IO.File.ReadLines("rockpaperscissors.txt"))
            {
                string[] parts = line.Split(new[] { ' ' });
                switch (parts[0])
                {
                    case "A":
                        {
                            switch (parts[1])
                            {
                                case "X":
                                    totalSum += 3; // 4
                                    break;
                                case "Y":
                                    totalSum += 4; // 8
                                    break;
                                case "Z":
                                    totalSum += 8; // 3
                                    break;
                            }
                            break;
                        }
                    case "B":
                        {
                            switch (parts[1])
                            {
                                case "X":
                                    totalSum += 1; // 1
                                    break;
                                case "Y":
                                    totalSum += 5; // 5
                                    break;
                                case "Z":
                                    totalSum += 9; // 9
                                    break;
                            }
                            break;
                        }
                    case "C":
                        {
                            switch (parts[1])
                            {
                                case "X":
                                    totalSum += 2; // 7
                                    break;
                                case "Y":
                                    totalSum += 6; // 2
                                    break;
                                case "Z":
                                    totalSum += 7; // 6
                                    break;
                            }
                            break;
                        }
                }
                Console.WriteLine("Sum is: " + totalSum);
            }       
        }