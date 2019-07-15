using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        return Array.IndexOf(Colors(), color);
    }

    public static string[] Colors()
    {
        return Color2;
    }
    static string[] Color2 = Enum.GetNames(typeof(ColorsEnum));
    private enum ColorsEnum : byte
    {
        black = 0,
        brown = 1,
        red = 2,
        orange = 3,
        yellow = 4,
        green = 5,
        blue = 6,
        violet = 7,
        grey = 8,
        white = 9

    }
}