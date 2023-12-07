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

    private int readLine_PartTwo(string inputLine)
    {
        // Pre-parse the line
        inputLine = inputLine.Replace("one", "1");

        inputLine = inputLine.Replace("two", "2");
        inputLine = inputLine.Replace("three", "3");

        inputLine = inputLine.Replace("four", "4");
        inputLine = inputLine.Replace("five", "5");

        inputLine = inputLine.Replace("six", "6");
        inputLine = inputLine.Replace("seven", "7");

        inputLine = inputLine.Replace("eight", "8");

        inputLine = inputLine.Replace("nine", "9");

        int lineOutput = readLine_PartOne(inputLine);

        Console.WriteLine("Input : " + inputLine + " Output : " + lineOutput);

        return lineOutput;
    }

    public string Solve_2()
    {
        int answerI = 0;

        using (StreamReader reader = new StreamReader(inputFilePath))
        {
            string line = "";

            while ((line = reader.ReadLine()) != null)
            {
                answerI += readLine_PartTwo(line);
            }
        }

        return new(answerI.ToString());
    }
}
