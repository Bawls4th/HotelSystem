namespace HotelModel.RoomModel
{
    public class RoomModel
    {
        public int RoomID { get; set; }
        public int RoomNo { get; set; }
        public string RoomType { get; set; }
        public string Floor { get; set; }
        public string RoomName { get; set; }
        public string RoomCapacity { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
        public bool IsAvailable { get; set; }
        public string RoomPicture { get; set; }
    }
}
