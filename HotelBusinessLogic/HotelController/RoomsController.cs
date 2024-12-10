using HotelBusinessLogic.HotelRepository;
using HotelModel.RoomModel;

namespace HotelBusinessLogic.HotelController
{
    public class RoomsController
    {
        private RoomsRepository Rrep;

        public RoomsController()
        {
            Rrep = new RoomsRepository();
        }

        private bool ParseAvailability(string availability, string status)
        {
            if (string.IsNullOrEmpty(availability))
            {
                throw new Exception("Please select availability.");
            }

            if (status == "Available")
            {
                if (availability == "Yes")
                {
                    return true;
                }
                else if (availability == "No")
                {
                    throw new Exception("A room that is 'Available' cannot be marked as 'No'.");
                }
            }
            else if (status == "Occupied" || status == "Out of Order" || status == "Reserved")
            {
                if (availability == "Yes")
                {
                    throw new Exception($"A room with a status '{status}' cannot be marked as 'Yes'.");
                }
                else if (availability == "No")
                {
                    return false; 
                }
            }
            else
            {
                throw new Exception($"Unknown room status: {status}. Please insert the following status");
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

        public RoomModel GetRooms(string roomNoInt, string roomType, string floor, string name, string capacity, string priceToDec, string status, string availability, string image)
        {

            if (!int.TryParse(roomNoInt, out int roomNo) || roomNo <= 0 || string.IsNullOrEmpty(roomType) || string.IsNullOrEmpty(floor) ||
                string.IsNullOrEmpty(name) || string.IsNullOrEmpty(capacity) || string.IsNullOrEmpty(status))
            {
                throw new Exception("Please fill all fields.");
            }

           decimal price = ParsePrice(priceToDec);

            if (Rrep.DoesRoomsExist(roomNo))
            {
                throw new Exception("This Room already exist.");
            }

            bool isAvail = ParseAvailability(availability, status);

            if (string.IsNullOrEmpty(image))
            {
                throw new Exception("Please select an image for the room.");
            }

            return Rrep.AddRooms(roomNo, roomType, floor, name, capacity, price, status, isAvail, image);
        }

        public void UpdateRooms(DataGridViewSelectedRowCollection selectedRows, string roomNoInt , string roomType, string floor, string name, string capacity, string priceToDec, string status, string availability)
        {
            int roomID = Convert.ToInt32(selectedRows[0].Cells[0].Value);
            if (selectedRows.Count == 0)
            {
                throw new Exception("Please select a room to update.");
            }

            if (!int.TryParse(roomNoInt, out int roomNo) || roomNo <= 0 || (string.IsNullOrEmpty(roomType) || string.IsNullOrEmpty(floor)
                 || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(capacity) || string.IsNullOrEmpty(status)))  
            {
                throw new Exception("Please fill all fields.");
            }

            decimal price = ParsePrice(priceToDec);

            bool isAvail = ParseAvailability(availability, status);

            //if (Rrep.RoomReserved(roomNo, status, isAvail))
            //{
            //    throw new Exception("This Room is Currently used.");
            //}

            Rrep.UpdateRooms(roomID, roomNo, roomType, floor, name, capacity, price, status, isAvail);
            
        }

        public void DeleteRooms(DataGridViewSelectedRowCollection selectedRows, string roomNoInt)
        {
            if (selectedRows.Count == 0)
            {
                throw new Exception("Please select a room to delete.");
            }

            if (!int.TryParse(roomNoInt, out int roomNo) || roomNo <= 0)
            {
                throw new Exception("Invalid room number.");
            }

            int roomID = Convert.ToInt32(selectedRows[0].Cells[0].Value);

            if (Rrep.ActiveReservations(roomID))
            {
                throw new Exception("This room currently reserved.");
            }

            Rrep.DeleteRooms(roomID, roomNo);
        }

        public List<RoomModel> SearchRooms(string searchTerm, string searchType)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                return new List<RoomModel>();
            }
            if (searchType == "RoomID" && !int.TryParse(searchTerm, out _))
            {
                throw new Exception("Please enter a numeric value...");
            }

            if (searchType == "RoomNo" && !int.TryParse(searchTerm, out _))
            {
                throw new Exception("Please enter a numeric value...");
            }

            return Rrep.SearchRooms(searchTerm, searchType);
        }

        public List<RoomModel> FetchAllRooms()
        {
            return Rrep.GetAllRooms();
        }

    }
}
