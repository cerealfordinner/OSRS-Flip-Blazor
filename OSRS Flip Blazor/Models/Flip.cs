using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OSRS_Flip_Blazor.Data;

namespace OSRS_Flip_Blazor.Models
{
    public class Flip
    {
        public int Id { get; set; }
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
    public class IndexModel : PageModel
    {
        public readonly FlipDbContext _context;

        public IndexModel(FlipDbContext context) => _context = context;

        public async void OnGet()
        {
            Flips = await _context.Flips.ToListAsync();
        }

        public IEnumerable<Flip> Flips { get; set; } = Enumerable.Empty<Flip>();

    }
}
