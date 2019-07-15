using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        string reversed = "";
        int length = input.Length - 1;
        while (length >= 0)
        {
            reversed += input[length];
            length--;
        }
        return reversed;
    }
}