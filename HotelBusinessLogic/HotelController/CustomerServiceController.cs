using HotelBusinessLogic.HotelRepository;
using HotelModel.CustomerServiceModel;

namespace HotelBusinessLogic.HotelController
{
    public class CustomerServiceController
    {
        private CustomerServiceRepository Crep;

        public CustomerServiceController()
        {
            Crep = new CustomerServiceRepository();
        }
        private bool ParseAvailability(string availability)
        {
            if (string.IsNullOrEmpty(availability))
            {
                throw new Exception("Please select availability.");
            }
            if (availability == "Yes")
            {
                return true;
            }
            else if (availability == "No")
            {
                return false;
            }
            else
            {
                throw new Exception("Please select 'Yes' or 'No' for availability.");
            }
        }

        private decimal ParsePrice(string priceText)
        {
            string cleanedPrice = priceText.Replace("₱", "").Replace(",", "").Trim();
            if (decimal.TryParse(cleanedPrice, out decimal price))
            {
                return price;
            }
            else
            {
                throw new Exception("Price must be a valid number.");
            }
        }

        public ServicorModel AddServicor(string FirstName, string MidName, string LastName, string Gender, string desc, string priceToDec, string availability, DateTime DateServ)
        {
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(MidName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(Gender) || string.IsNullOrEmpty(desc))
            {
                throw new Exception("Please fill all the fields...");
            }

            decimal price = ParsePrice(priceToDec);

            if (Crep.DoesServicorExist(FirstName, MidName, LastName, Gender, desc))
            {
                throw new Exception("Servicor is already exists.");
            }

            bool Avail = ParseAvailability(availability);


            if (DateServ < DateTime.Now.Date)
            {
                throw new Exception("Date cannot be in past.");
            }

            return Crep.AddServicor(FirstName, MidName, LastName, Gender,desc, price, Avail, DateServ);

        }

        public void UpdateServicor(DataGridViewSelectedRowCollection selectedRows, string FirstName, string MidName, string LastName, string Gender, string desc, string priceToDec, string availability, DateTime DateServ)
        {
            int servID = Convert.ToInt32(selectedRows[0].Cells[0].Value);
            if (selectedRows.Count == 0)
            {
                throw new Exception("Please select a Servicor to update.");
            }

            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(MidName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(Gender) || string.IsNullOrEmpty(desc))
            {
                throw new Exception("Please fill all the fields...");
            }

            decimal price = ParsePrice(priceToDec);

            bool Avail = ParseAvailability(availability);

            //if (Crep.ServicorAvailability(FirstName, MidName, LastName, Avail))
            //{
            //    throw new Exception("Availability value cannot be change when currently served.");
            //}

            if (Avail && DateServ.Date < DateTime.Now.Date)
            {
                throw new Exception("The servicor is not booked to be served yet.");
            }

            if (Avail && DateServ.Date != DateTime.Now.Date)
            {
                throw new Exception("The servicor is not booked to be served yet.");
            }

            if (Avail && DateServ.Date >= DateTime.Now.Date)
            {
               Crep.UpdateServicor(servID, FirstName, MidName, LastName, Gender, desc, price, Avail, DateServ);
            }

            Crep.UpdateServicor(servID, FirstName, MidName, LastName, Gender, desc, price, Avail, DateServ);

        }

        public void DeleteServicor(DataGridViewSelectedRowCollection selectedRows)
        {
            int servID = Convert.ToInt32(selectedRows[0].Cells[0].Value);
            if (selectedRows.Count == 0)
            {
                throw new Exception("Please select a Servicor to update.");
            }
            if (Crep.ActiveReservations(servID))
            {
                throw new Exception("This Servicor is Currently in served.");
            }
            Crep.DeleteServicor(servID);
          
        }

        public List<ServicorModel> SearchRooms(string searchTerm, string searchType)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                return new List<ServicorModel>();
            }

            if (searchType == "ID" && !int.TryParse(searchTerm, out _))
            {
                throw new Exception("Please enter a numeric value...");
            }

            return Crep.SearchRooms(searchTerm, searchType);
        }

        public List<ServicorModel> FetchAllService()
        {
            return Crep.GetAllService();
        }
    }
}
