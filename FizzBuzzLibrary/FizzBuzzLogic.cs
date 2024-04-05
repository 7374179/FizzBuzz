namespace FizzBuzzLibrary;

public class FizzBuzzLogic
{
    public string? GetOutput(int? number)
    {
        if (number < 0)
        {
            throw new Exception("Number cannot be negative.");
        }
        if (number > 100)
        {
            throw new Exception("Number cannot be greater than 100.");
        }
        if (number is null)
        {
            throw new Exception("Number cannot be null.");
        }

        string output = string.Empty;
        for(int i = 1; i <= number; i++)
        {
            if(i % 3 == 0 && i % 5 == 0)
            {
                output += "FizzBuzz ";
            }
            else if(i % 3 == 0)
            {
                output += "Fizz ";
            }
            else if(i % 5 == 0)
            {
                output += "Buzz ";
            }
            else
            {
                output += $"{i} ";
            }
        }
        return output;

    }
}
