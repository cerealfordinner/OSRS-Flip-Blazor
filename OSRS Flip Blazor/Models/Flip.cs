namespace OSRS_Flip_Blazor.Models
{
    public class Flip
    {
        public string ItemName { get; set; }
        public int BuyPrice { get; set; }
        public int SellPrice { get; set; }
        public int Quantity { get; set; }
        public int Margin { get; set; }
        public int Profit { get; set; }

        public Flip(string itemName, int buyPrice, int sellPrice, int quantity)
        {
            ItemName = itemName;
            BuyPrice = buyPrice;
            SellPrice = sellPrice;
            Quantity = quantity;
            Margin = sellPrice - buyPrice;
            Profit = Margin * quantity;
        }
    }
}
