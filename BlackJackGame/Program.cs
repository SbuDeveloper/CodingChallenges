internal class Program
{
    private static void Main(string[] args)
    {
        string[] strArry = ["ace", "queen"];
        Console.WriteLine();
    }
    public static string DistributedCards(string[] strArry){
        var handCount = PlayersHand(strArry);
        if(handCount == 21){
            return "BlackJack";
        }
        else if(handCount > 21){
            return "Above";
        }
        else{
            return "Below";
        }
    }
    public static int PlayersHand(string[] strArry){
        List<int> list = new List<int>();
        var _acedHand = false;
        var handCount = 0;

        foreach (var item in strArry)
        {
            if(item == "ace"){
                _acedHand = true;
            }

            switch (item.ToLower())
            {
                case "one" or "ace":
                list.Add(CardValue(item, list));
                break;
                case "two":
                list.Add(2);
                break;
                case "three":
                list.Add(3);
                break;
                case "four":
                list.Add(4);
                break;
                case "five":
                list.Add(5);
                break;
                case "six":
                list.Add(6);
                break;
                case "seven":
                list.Add(7);
                break;
                case "eight":
                list.Add(8);
                break;
                case "nine":
                list.Add(9);
                break;
                case "ten" or "jack" or "queen" or "king":
                list.Add(10);
                break;
            }
            
        }

        if(_acedHand == true){
            handCount = list.Sum();
            if(handCount > 21){
                handCount = handCount - 10;
            }
        }

        return handCount;

    }
    public static int CardValue(string card, List<int> playerHand){
        var _cardValue = 1;

        if(card == "ace"){
            if(playerHand.Count > 0){
                var countAcedHand = playerHand.Sum();
                if(countAcedHand > 21){
                    _cardValue = 1;
                }
                else{
                    _cardValue = 11;
                }
            }
        }
        else{
            _cardValue = 1;
        }
        
        return _cardValue;

    }
}