using System;

class BonusScore
{
    static void Main()
    {
        int num;
        string str;
        do
        {
            str = Console.ReadLine();
        } while (!int.TryParse(str, out num));

        switch (num)
        {
            case 1:
            case 2:
            case 3:
                str = (num * 10).ToString();
                break;
            case 4:
            case 5:
            case 6:
                str = (num * 100).ToString();
                break;
            case 7:
            case 8:
            case 9:
                str = (num * 1000).ToString();
                break;
            default:
                str = "invalid score";
                break;
        }
        Console.WriteLine(str);
    }
}
