using System;

class Print_aDeck
{
    static void Main()
    {
        char card;
        int cardValue;
        bool input = char.TryParse(Console.ReadLine(), out card);

        switch (card)
        {
            case 'J':
            case 'j':
                cardValue = 11;
                break;
            case 'Q':
            case 'q':
                cardValue = 12;
                break;
            case 'K':
            case 'k':
                cardValue = 13;
                break;
            case 'A':
            case 'a':
                cardValue = 14;
                break;
            default:
                cardValue = (int)card - 0x30;
                break;
        }

        if (!input)
        {
            cardValue = 10; //No char for 10!!! 
        }
        if (cardValue < 2 ||  cardValue > 14)
        {
            throw new Exception("Invalid Input!!!");
        }

        string tmp;

        for (byte b = 2; b <= cardValue; b++)
        {
            switch (b)
            {
                case 11:
                    tmp = "J";
                    break;
                case 12:
                    tmp = "Q";
                    break;
                case 13:
                    tmp = "K";
                    break;
                case 14:
                    tmp = "A";
                    break;
                default:
                    tmp = b.ToString();
                    break;
            }
            Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", tmp);
        }
    }
}

