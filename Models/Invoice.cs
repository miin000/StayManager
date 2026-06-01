using System;

namespace StayManager.Models
{
    public class Invoice
    {
        public int Id { get; set; }

        public int ReservationId { get; set; }

        public int CustomerId { get; set; }

        public decimal RoomCharge { get; set; }

        public decimal ServiceCharge { get; set; }

        public decimal Discount { get; set; }

        public decimal TotalAmount { get; set; }

        public string PaymentMethod { get; set; }

        public InvoiceStatus Status { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? PaidAt { get; set; }

        public Invoice()
        {
            PaymentMethod = string.Empty;
            Status = InvoiceStatus.Unpaid;
            CreatedAt = DateTime.Now;
        }
    }
}
