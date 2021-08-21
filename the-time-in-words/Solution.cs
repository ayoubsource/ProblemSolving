using System;


class Solution
{
    public static string NumberToString(int n)
    {
        switch (n)
        {
            case 1:return "one";
            case 2:return "two";
            case 3:return "three";
            case 4:return "four";
            case 5:return "five";
            case 6:return "six";
            case 7:return "seven";
            case 8:return "eighth";
            case 9:return "nine";
            case 10:return "ten";
            case 11:return "eleven";
            case 12:return "twelve";
            case 13:return "thirteen";
            case 14:return "fourteen";
            case 15:return "quarter";
            case 16:return "sixteen";
            case 17:return "seventeen";
            case 18:return "eighteen";
            case 19:return "nineteen";
            case 20:return "twenty";
            case 21:return "twenty one";
            case 22:return "twenty two";
            case 23:return "twenty three";
            case 24:return "twenty four";
            case 25:return "twenty five";
            case 26:return "twenty six";
            case 27:return "twenty seven";
            case 28:return "twenty eight";
            case 29:return "twenty nine";
            case 30:return "half";
            case 31:return "thirty one";
            case 32:return "thirty two";
            case 33:return "thirty three";
            case 34:return "thirty four";
            case 35:return "thirty five";
            case 36:return "thirty six";
            case 37:return "thirty seven";
            case 38:return "thirty eight";
            case 39:return "thirty nine";
            case 40:return "forty";
            case 41:return "forty one";
            case 42:return "forty two";
            case 43:return "forty three";
            case 44:return "forty four";
            case 45:return "forty five";
            case 46:return "forty six";
            case 47:return "forty seven";
            case 48:return "forty eight";
            case 49:return "forty nine";
            case 50:return "fifty";
            case 51:return "fifty one";
            case 52:return "fifty two";
            case 53:return "fifty three";
            case 54:return "fifty four";
            case 55:return "fifty five";
            case 56:return "fifty six";
            case 57:return "fifty seven";
            case 58:return "fifty eight";
            case 59:return "fifty nine";
            default: return "unknown";
        }
    }
    public static void Main(string[] args)
    {
        int h = Convert.ToInt32(Console.ReadLine().Trim());

        int m = Convert.ToInt32(Console.ReadLine().Trim());

        
        if(m==0)
            Console.WriteLine(NumberToString(h)+" o' clock");
        else if (m <= 30)
        {
            var str = (m != 15 && m!=30) ? " minutes" : "";
            str = (m == 1) ? str.Remove(str.Length - 1) :str;
            Console.WriteLine(NumberToString(m) + str +" past "+NumberToString(h));
        }
       
        else
        {
            var str = (m != 45) ? " minutes" : "";
            str = (m == 59) ? str.Remove(str.Length - 1) : str;

            Console.WriteLine(NumberToString(60-m) + str + " to " + NumberToString(h+1));
        }
    }
}