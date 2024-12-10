
namespace HotelModel.CustomerServiceModel
{
    public class ServicorModel
    {
        public int ServiceID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Available { get; set; }
        public DateTime DateService { get; set; }
    }
}
