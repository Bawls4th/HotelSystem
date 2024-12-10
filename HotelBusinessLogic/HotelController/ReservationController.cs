using HotelBusinessLogic.HotelRepository;
using HotelModel.ReservationModel;

namespace HotelBusinessLogic.HotelController
{
    public class ReservationController
    {
        private ReservationRepository Reserve_rep;

        public ReservationController()
        {
            Reserve_rep = new ReservationRepository();
        }

        public ReservationModel GetReservationInfo(string guestNostr, string roomNostr, string servicorNoStr, DateTime checkIn, DateTime checkOut, DateTime Issued) 
        {
            if(!int.TryParse(guestNostr, out int guestID) || guestID <= 0 || !int.TryParse(roomNostr, out int roomID) || roomID <= 0 
                || !int.TryParse(servicorNoStr, out int serviceID) || serviceID <= 0)
            {
                throw new Exception("Please Fill all fields.");
            }

            if (checkIn < DateTime.Now.Date) 
            { 
                throw new Exception("Check In cannot be in past.");  
            }
            if (checkOut < DateTime.Now.Date) 
            {
                throw new Exception("Check Out cannot be in past.");
            }

            if (Reserve_rep.DoesServicorExist(guestID, roomID, serviceID))
            {
                throw new Exception("This Reservant already exist.");
            }

            return Reserve_rep.Reserve(guestID, roomID, serviceID, checkIn, checkOut, Issued);

        }

        public void UpdateInfo(DataGridViewSelectedRowCollection selectedRows, string guestNostr, string roomNostr, string servicorNoStr, DateTime datecheckIn, DateTime checkOut, DateTime Issued)
        {
            if (selectedRows.Count == 0)
            {
                throw new Exception("Please Select an Info to Update.");
            }
            int reservationID = Convert.ToInt32(selectedRows[0].Cells[0].Value);


            if (!int.TryParse(guestNostr, out int guestID) || guestID <= 0 || !int.TryParse(roomNostr, out int roomID) || roomID <= 0
                || !int.TryParse(servicorNoStr, out int serviceID) || serviceID <= 0)
            {
                throw new Exception("Please Fill all fields.");
            }

            DateTime currentDate = Convert.ToDateTime(selectedRows[0].Cells[4].Value);


            if (datecheckIn != currentDate)
            {
                throw new Exception("Check In date cannot be changed.");
            }

            if (checkOut < DateTime.Now)
            {
                throw new Exception("Check Out cannot be in past.");
            }

            Reserve_rep.UpdateReservation(reservationID, guestID, roomID, serviceID, datecheckIn, checkOut, Issued);

        }

        public void DeleteInfo(DataGridViewSelectedRowCollection selectedRows)
        {
            if (selectedRows.Count == 0)
            {
                throw new Exception("Please Select an Info to Update.");
            }
            int reservationID = Convert.ToInt32(selectedRows[0].Cells[0].Value);
            Reserve_rep.DeleteReservation(reservationID);
        }

        public List<ReservationModel> GetReservationInfo()
        {
            return Reserve_rep.ReservationInfo();
        }

        public List<ReservationModel> SearchRooms(string searchTerm, string searchType)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                return new List<ReservationModel>();
            }
            if (searchType == "ReservationID" && !int.TryParse(searchTerm, out _))
            {
                throw new Exception("Please enter a numeric value...");
            }

            if (searchType == "RoomNo" && !int.TryParse(searchTerm, out _))
            {
                throw new Exception("Please enter a numeric value...");
            }

            return Reserve_rep.SearchReservants(searchTerm, searchType);
        }

        //public void PrintReservation(DataGridViewSelectedRowCollection SelectedRows)
        //{
        //    try
        //    {
        //        string filePath = @"C:\\Users\\Julius Mendoza\\source\\repos\\ErvinAbiadSTI\\BT3102.Group7.App\\BetterCallRoomy\\Resources\\ReservationInfos\\"
        //                          + SelectedRows[0].Cells[0].Value.ToString() + ".txt";

        //        string directory = Path.GetDirectoryName(filePath);
        //        if (!Directory.Exists(directory))
        //        {
        //            Directory.CreateDirectory(directory);
        //        }

        //        using (StreamWriter writer = new StreamWriter(filePath))
        //        {
        //            writer.WriteLine("Reservation ID: " + SelectedRows[0].Cells[0].Value.ToString());
        //            writer.WriteLine("Guest: " + SelectedRows[0].Cells[1].Value.ToString());
        //            writer.WriteLine("Room No: " + SelectedRows[0].Cells[2].Value.ToString());
        //            writer.WriteLine("Servicor: " + SelectedRows[0].Cells[3].Value.ToString());
        //            writer.WriteLine("Check In: " + SelectedRows[0].Cells[4].Value.ToString());
        //            writer.WriteLine("Check Out: " + SelectedRows[0].Cells[5].Value.ToString());
        //            writer.WriteLine("Date Issued: " + SelectedRows[0].Cells[6].Value.ToString());
        //            writer.WriteLine("Price: " + SelectedRows[0].Cells[7].Value.ToString());
        //        }

        //        MessageBox.Show("Reservation details have been printed to a text file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"An error occurred while printing reservation: {ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

    }
}
