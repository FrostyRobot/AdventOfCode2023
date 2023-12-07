using System.Xml;

namespace AdventOfCode.src.DayDrivers;

public class Day01
{
    private string inputFilePath;

    public Day01(String fileIndex)
    {
        inputFilePath = "Input//" + fileIndex + ".txt";
    }

    public string Solve_1()
    {
        int answerI = 0;

        using (StreamReader reader = new StreamReader(inputFilePath))
        {
            string? line = "";

            while ((line = reader.ReadLine()) != null)
            {
                answerI += readLine_PartOne(line);
            }
        }

        return answerI.ToString();
    }

    private int readLine_PartOne(string inputLine)
    {
        int firstDigit = -1;
        int secondDigit = -1;

        foreach (char c in inputLine)
        {
            if (char.IsDigit(c))
            {
                if (firstDigit == -1)
                {
                    firstDigit = c - '0';
                    secondDigit = c - '0';
                }
                else
                {
                    secondDigit = c - '0';
                }
            }
        }

        int lineOutput = firstDigit * 10 + secondDigit;

        Console.WriteLine("Input : " + inputLine + " Output : " + lineOutput);

        return lineOutput;
    }

    public static int readLine_PartTwo(string inputLine)
    {
        Int32 lineOutput = -1;

        int firstDigit = -1;
        int secondDigit = -1;

        List<Trie> tries = new List<Trie>();

        // Pre-parse the line
        foreach (Char c in inputLine)
        {
            if (char.IsDigit(c))
            {
                tries.Clear();

                if (firstDigit == -1)
                {
                    firstDigit = c - '0';
                    secondDigit = c - '0';
                }
                else
                {
                    secondDigit = c - '0';
                }
            }
            else
            {
                bool isMatch = false;
                int charDigit = -1;

                foreach(Trie trie1 in tries)
                {
                    if (trie1.isDead) continue;

                    if (Trie.State.MATCH == trie1.Index(c))
                    {
                        charDigit = trie1.indexNode.getDecimal();
                        isMatch = true;
                    }
                }

                if (isMatch) 
                {
                    if (firstDigit == -1)
                    {
                        firstDigit = charDigit;
                        secondDigit = charDigit;
                    }
                    else
                    {
                        secondDigit = charDigit;
                    }

                    tries.Clear(); 
                    continue; 
                }

                // Add a new trie to the group and see if it indexes
                Trie trie = new Trie();

                if(trie.Index(c) == Trie.State.INCREMENTED){
                    tries.Add(trie);
                }
            }
        }

        if(firstDigit == -1)
        {
            return -1;
        }

        lineOutput = firstDigit * 10 + secondDigit;

        Console.WriteLine("Input : " + inputLine + " Output : " + lineOutput);

        return lineOutput;
    }

    public string Solve_2()
    {
        int linesread = 0;

        int answerI = 0;

        using (StreamReader reader = new StreamReader(inputFilePath))
        {
            string line = "";

            while ((line = reader.ReadLine()) != null)
            {
                linesread++;

                int value = readLine_PartTwo(line);

                if (value != -1){
                    answerI += value;
                }
            }
        }

        return new(answerI.ToString());
    }
}
