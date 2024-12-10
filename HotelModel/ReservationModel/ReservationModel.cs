
namespace HotelModel.ReservationModel
{
    public class ReservationModel
    {
        public int ReservationID { get; set; }
        public int GuestID { get; set; }
        public int RoomID { get; set; }
        public int ServiceID { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public DateTime DateIssued { get; set; }

        public string Guest { get; set; }
        public int RoomNo { get; set; }
        public string Servicor { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal RoomPrice { get; set; }
        public decimal ServicorPrice { get; set; }

    }
}
