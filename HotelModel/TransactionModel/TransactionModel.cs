using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModel.TransactionModel
{
    public class TransactionModel
    {
        public int TransactionID { get; set; }
        public int ReservationID { get; set; }
        public decimal RoomCharge { get; set; }
        public decimal Balance { get; set; }
        public decimal AmountPaid { get; set; }
        public string PaymentMethod { get; set; }

    }
}
