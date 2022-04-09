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
    }
}
