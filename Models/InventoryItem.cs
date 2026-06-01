using System;

namespace StayManager.Models
{
    public class InventoryItem
    {
        public int Id { get; set; }

        public string ItemName { get; set; }

        public string Category { get; set; }

        public int Quantity { get; set; }

        public int MinimumQuantity { get; set; }

        public string Unit { get; set; }

        public decimal UnitPrice { get; set; }

        public InventoryStatus Status { get; set; }

        public string Note { get; set; }

        public DateTime CreatedAt { get; set; }

        public InventoryItem()
        {
            ItemName = string.Empty;
            Category = string.Empty;
            Unit = string.Empty;
            Note = string.Empty;
            MinimumQuantity = 0;
            Status = InventoryStatus.Available;
            CreatedAt = DateTime.Now;
        }
    }
}
