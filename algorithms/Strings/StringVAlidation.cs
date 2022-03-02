
using System.Linq;
namespace validation;
using System.Text;

public static class stringValidation
{

    //validation
    public static Boolean IsUpper(string s)
    {
        return s.All(char.IsUpper);
    }

    public static Boolean IsLower(string s)
    {
        return s.All(char.IsLower);
    }

    public static Boolean IsPasswordComplex(string s)
    {
        return s.Any(char.IsUpper) && s.Any(char.IsLower) && s.Any(char.IsDigit);
    }

    //normalizing
    //limit the input of to a certain type. using a validator to ensure the string is 
    // of a certain form

    public static string NormalizeString(String input)
    {
        string lowercased = input.ToLower().Trim().Replace(",", "");
        return lowercased;
    }


    //searching data within a string
    //know nothing about the string , you have to check all the character.

    //if strings are alphabetical

    public static void Parcecontent(string s)
    {
        Console.WriteLine("option 1");

        foreach (char c in s)
        {
            Console.WriteLine(c);
        }

        Console.WriteLine("Option 2");
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            Console.WriteLine(c);
        }
    }

    public static Boolean isAtEvenIndex(string s, char item)
    {

        if (String.IsNullOrEmpty(s))
        {
            return false;
        }
        for (int i = 0; i < s.Length / 2 + 1; i = i + 2)
        {
            if (s[i] == item)
            {
                return true;
            }
        }
        return false;
    }

    // Edwin Muraya
    // Muraya Edwin


    public static string ReverseEachWord(string sentence)
    {

        if (String.IsNullOrEmpty(sentence))
        {
            return sentence;
        }

        StringBuilder result = new StringBuilder();
        string[] words = sentence.Split(" ");
        for (int i = 0; i < words.Length; i++)
        {
            result.Append(Reverse(words[i]));
            if (i != words.Length - 1)
            {
                result.Append(" ");
            }
        }

        return result.ToString();
    }

    //the output of a validation ah


    //reverse a string

    public static string Reverse(string input)
    {

        //string are imumutable.
        if (String.IsNullOrEmpty(input))
        {
            return input;
        }

        StringBuilder reversed = new StringBuilder(input.Length);
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed.Append(input[i]);
        }

        Console.WriteLine(reversed.ToString());
        return reversed.ToString();
    }

    public static string Reverse2(String input)
    {
        if (String.IsNullOrEmpty(input))
        {
            return input;
        }

        char[] arr = input.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }


    public static Boolean checkifStringContainsUninqueCharacters(string input)
    {
        int check = 0;

        for (int i = 0; i < input.Length; i++)
        {
            int charToInt = input[i] - 'a';
            if ((check & (1 << charToInt)) > 0)
                return false;

            check |= (1 << charToInt);
        }
        return true;
    }

    //reverse each word in a string
    //input: string
    // new string with each word reveresed
    //assumptions: no punctuations in the string, each word separated by spaces.
    //casing should remain the same.

    // leverage validation, normalization, and /or search algorithm

}