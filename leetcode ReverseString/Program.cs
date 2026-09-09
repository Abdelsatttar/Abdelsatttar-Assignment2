public class Solution
{
    public void ReverseString(char[] s)
    {
        int l = 0;
        int r = s.Length - 1;

        while (l < r)
        {
            char temp = s[l];
            s[l] = s[r];
            s[r] = temp;

            l++;
            r--;
        }
    }
}

public static class Program
{
    // Minimal entry point so the project builds and we can run a quick sanity check.
    public static void Main()
    {
        var s = new char[] { 'h', 'e', 'l', 'l', 'o' };
        new Solution().ReverseString(s);
        System.Console.WriteLine(new string(s));
    }
}