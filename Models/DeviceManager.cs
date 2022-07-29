using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Device_Management_Web.Models
{
    public class DeviceManager
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int DeviceId { get; set; }
        public int TechnicianId { get; set; }
        public int AdminId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Barcode { get; set; }
        public bool? Status { get; set; }
        public string TransactionType { get; set; }
        public DateTime TransactionDate { get; set; }
        public bool? IsApproved { get; set; }
        public DateTime? DecisionDate { get; set; }

        public virtual User User { get; set; }
    }
}