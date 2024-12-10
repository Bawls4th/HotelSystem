using HotelBusinessLogic.HotelRepository;
using HotelModel.ManagerModel;

namespace HotelBusinessLogic.HotelController
{
    public class ManagerController
    {
        private ManagerRepository ManRep;

        public ManagerController()
        {
            ManRep = new ManagerRepository();
        }

        public ManagerModel GetManModel(string MGUserName, string MGPassWord)
        {
            if (string.IsNullOrEmpty(MGUserName) && string.IsNullOrEmpty(MGPassWord))
            {
                throw new Exception("Username/password is empty...");
            }

            else if (string.IsNullOrWhiteSpace(MGUserName) && string.IsNullOrWhiteSpace(MGPassWord))
            {
                throw new Exception("Space values was inputted...");
            }
            return ManRep.getManModel(MGUserName, MGPassWord);
        }
    }
}
