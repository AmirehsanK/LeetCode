namespace Top_Interview_150.Array_String;

public class BestTimetoBuyandSellStock1
{
    public int MaxProfit(int[] prices)
    {
        var maxProfit = 0;
        var lowest=prices[0];
        foreach (var price in prices)
        {
            if (lowest > price)
                lowest = price;
            else if(price-lowest > maxProfit)
                maxProfit = price-lowest;
        }
        return maxProfit;
    }
}