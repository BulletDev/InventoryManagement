using System;

namespace InventoryManagement.Models
{
    public class SupplierModel
    {
        public int Id { get; set; }
        public string SupplierId { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
    }
}
