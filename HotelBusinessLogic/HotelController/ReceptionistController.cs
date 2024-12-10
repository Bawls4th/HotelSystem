using HotelBusinessLogic.HotelRepository;
using HotelModel.ReceptionistModel;

namespace HotelBusinessLogic.HotelController
{
    public class ReceptionistController
    {
        private ReceptionistRepository RepRep;

        public ReceptionistController()
        {
            RepRep = new ReceptionistRepository();
        }


        public ReceptionistModel GetEmpModel(string RPUserName, string RPPassWord)
        {
            if (string.IsNullOrEmpty(RPUserName) && string.IsNullOrEmpty(RPPassWord))
            {
                throw new Exception("Username/password is empty...");
            }

            else if (string.IsNullOrWhiteSpace(RPUserName) && string.IsNullOrWhiteSpace(RPPassWord))
            {
                throw new Exception("Space values was inputted...");
            }
            return RepRep.getRepModel(RPUserName, RPPassWord);
        }

        public ReceptionistModel GetReceptionistModel(string FirstName, string LastName, string EmailAddress, string contactNo, string Username, string password)
        {
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName)
                || string.IsNullOrEmpty(EmailAddress) || string.IsNullOrEmpty(contactNo)
                || string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(password))
            {
                throw new Exception("Please fill all the fields...");
            }

            if (RepRep.DoesReceptionistExist(FirstName, LastName))
            {
                throw new Exception("This Receptionist already works here...");
            }

            return RepRep.GetReceptionistModel(FirstName, LastName, EmailAddress, contactNo, Username, password);
        }

        public void UpdateReceptionist(DataGridViewSelectedRowCollection selectedRows, string firstName, string lastName, string email, string contactNo, string Username, string password)
        {
            if (selectedRows.Count == 0)
            {
                throw new Exception("Please select a receptionist to update.");
            }

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email)
                || string.IsNullOrEmpty(contactNo) || string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(password))
            {
                throw new Exception("Please fill all the fields.");
            }

            int repID = Convert.ToInt32(selectedRows[0].Cells[0].Value);

            RepRep.UpdateReceptionist(repID, firstName, lastName, email, contactNo, Username, password);
        }

        public void DeleteReceptionist(DataGridViewSelectedRowCollection selectedRows)
        {
            if (selectedRows.Count == 0)
            {
                throw new Exception("Please select a receptionist to delete.");
            }

            int repID = Convert.ToInt32(selectedRows[0].Cells[0].Value);

            RepRep.DeleteReceptionist(repID);
        }

        public List<ReceptionistModel> FetchAllReceptionist()
        {
            return RepRep.GetAllReceptionist();
        }

        public List<ReceptionistModel> SearchReceptionist(string searchTerm, string searchType)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                return new List<ReceptionistModel>();
            }

            if (searchType == "ID" && !int.TryParse(searchTerm, out _))
            {
                throw new Exception("Please enter a numeric value...");
            }

            return RepRep.SearchReceptionist(searchTerm, searchType);
        }


    }
}
