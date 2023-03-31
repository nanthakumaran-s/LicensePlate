public class Program
{
    public static void Main(string[] args)
    {
        string plateNumber = LicensePlate("5F3Z-2e-9-w", 4);
        Console.WriteLine(plateNumber);
    }

    public static string LicensePlate(string s, int n)
    {
        s = s.ToUpper().Replace("-", "");
        int len = s.Length;
        List<string> result = new();
        for (int i = len - 1; i >= 0; i--)
        {
            result.Add(s[i].ToString());
            int lenOfRes = result.Count - result.Count(x => x.Contains("-"));
            if (lenOfRes % n == 0)
            {
                result.Add("-");
            }
        }
        result.Reverse();
        if (result[0] == "-")
        {
            result.RemoveAt(0);
        }
        return string.Join("", result.ToArray());
    }
}