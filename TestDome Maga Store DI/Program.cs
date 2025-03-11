using TestDome_Maga_Store;

internal class Program
{
    private static void Main(string[] args)
    {
        CalculateDiscountedPrices _calculateDiscountedPrices = new();
        Console.WriteLine(_calculateDiscountedPrices.GetDiscountedPrice(12, 100, Discount.DiscountType.Weight).ToString("0.0"));
    }
}
