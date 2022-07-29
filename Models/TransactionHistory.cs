using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Device_Management_Web.Models
{
    public class TransactionHistory
    {
        public int HistoryId { get; set; }
        public int DeviceManagerId { get; set; }
        public int BorrowerId { get; set; }
        public string BorrowerName { get; set; }
        public string BorrowerDepartment { get; set; }
        public string BorrowerDescription { get; set; }
        public int DeviceId { get; set; }
        public string DeviceName { get; set; }
        public string DeviceBrand { get; set; }
        public string DeviceModel { get; set; }
        public string DeviceBarcode { get; set; }
        public int ApproverId { get; set; }
        public string ApproverName { get; set; }
        public string ApproverRole { get; set; }
        public int TransactionType { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}