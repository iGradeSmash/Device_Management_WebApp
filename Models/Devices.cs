using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Device_Management_Web.Models
{
    public class Devices
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Barcode { get; set; }
        public bool? Status { get; set; }
        public bool? IsAvailable { get; set; }
        public int? BorrowerId { get; set; }
        public DateTime? ExpectedReturnDate { get; set; }
    }
}