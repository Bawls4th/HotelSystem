using HotelBusinessLogic.HotelRepository;
using HotelModel.GuestModel;
using System.Data.SqlClient;

namespace HotelBusinessLogic.HotelController
{
    public class GuestController
    {
        private GuestRepository GRep;

        public GuestController()
        {
            GRep = new GuestRepository();
        }

        public List<GuestModel> FetchAllGuests()
        {
            return GRep.GetAllGuests();
        }

        public GuestModel GetGuestModel(string FirstName, string MiddleName, string LastName, DateTime BirthDate, string ageNoStr, string Gender, string Ethnic, string GEmailAddress, string contactNo, DateTime TimeRegistered)
        {
            
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(MiddleName) || string.IsNullOrEmpty(LastName) 
                || string.IsNullOrEmpty(Gender) || string.IsNullOrEmpty(Ethnic) || string.IsNullOrEmpty(GEmailAddress) || string.IsNullOrEmpty(contactNo))
            {
                throw new Exception("Please fill all the fields...");
            }

            if (BirthDate == DateTime.Now.Date)
            {
                throw new Exception("BirthDate should not be on today's date.");
            }

            if (BirthDate > DateTime.Now.Date)
            {
                throw new Exception("BirthDate should not be in Future's date.");
            }

            if (!int.TryParse(ageNoStr, out int Age) || Age <= 0)
            {
                throw new Exception("Please enter a valid contact number.");
            }

            if (Age < 18)
            {
                throw new Exception("Only Adults can booked to our hotel.");
            }

            if (GRep.DoesGuestExist(FirstName, MiddleName, LastName, GEmailAddress, contactNo))
            {
                throw new Exception("This Guest is already booked...");
            }

            return GRep.getGuestModel(FirstName, MiddleName, LastName, BirthDate, Age, Gender, Ethnic, GEmailAddress, contactNo, TimeRegistered);
        }

        public List<GuestModel> SearchGuests(string searchTerm, string searchType)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                return new List<GuestModel>(); 
            }

            if (searchType == "ID" && !int.TryParse(searchTerm, out _))
            {
                throw new Exception("Please enter a numeric value...");
            }

            return GRep.SearchGuests(searchTerm, searchType);
        }

        public void UpdateGuest(DataGridViewSelectedRowCollection selectedRows, string firstName, string middleName, string lastName, DateTime birth, string ageNoStr, string gender, string ethnic, string email, string contactNo, DateTime registered)
        {
            if (selectedRows.Count == 0)
            {
                throw new Exception("Please select a guest to update.");
            }

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(middleName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(ethnic) || string.IsNullOrEmpty(email))
            {
                throw new Exception("Please fill all the fields.");
            }

            if (birth == DateTime.Now.Date)
            {
                throw new Exception("BirthDate should not be on today's date.");
            }

            if (birth > DateTime.Now.Date)
            {
                throw new Exception("BirthDate should not be in Future's date.");
            }

            if (!int.TryParse(ageNoStr, out int age) || age <= 0)
            {
                throw new Exception("Please enter a valid contact number.");
            }

            if (age < 18)
            {
                throw new Exception("Only Adults can booked to our hotel.");
            }
            
            int guestId = Convert.ToInt32(selectedRows[0].Cells[0].Value);

            try
            {
                GRep.UpdateGuest(guestId, firstName, middleName, lastName, birth, age, gender, ethnic, email, contactNo, registered);
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating guest information: " + ex.Message);
            }
        }

        public void DeleteGuest(DataGridViewSelectedRowCollection selectedRows)
        {
            if (selectedRows.Count == 0)
            {
                throw new Exception("Please select a guest to delete.");
            }

            int guestId = Convert.ToInt32(selectedRows[0].Cells[0].Value);

            if (GRep.ActiveReservations(guestId))
            {
                throw new Exception("This Guest is currently in Reservation.");
            }

            GRep.DeleteGuest(guestId);
            
        }
    }
    
}