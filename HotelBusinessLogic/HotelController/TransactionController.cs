using HotelBusinessLogic.HotelRepository;
using HotelModel.RoomModel;
using HotelModel.TransactionModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBusinessLogic.HotelController
{
    public class TransactionController
    {
        private TransactionRepository Trep;

        public TransactionController()
        {
            Trep = new TransactionRepository();
        }

        public bool ProcessTransaction(TransactionModel transaction)
        {
            try
            {
                int transactionID;
                bool isSuccess = Trep.InsertTransaction(transaction.ReservationID,transaction.RoomCharge, transaction.Balance, transaction.AmountPaid, transaction.PaymentMethod, out transactionID);

                if (isSuccess)
                {
                    Console.WriteLine("Transaction ID: " + transactionID);
                }

                return isSuccess;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error processing transaction: " + ex.Message);
                return false;
            }
        }

        public List<TransactionModel> GetAllTransactions()
        {
            return Trep.GetTransactions();
        }

        public void TextFile(DataGridViewSelectedRowCollection SelectedRows)
        {
            try
            {
                int transactionID = Convert.ToInt32(SelectedRows[0].Cells["TransactionID"].Value);
                int reservationID = Convert.ToInt32(SelectedRows[0].Cells["ReservationID"].Value);
                decimal roomCharge = Convert.ToDecimal(SelectedRows[0].Cells["RoomCharge"].Value);
                decimal balance = Convert.ToDecimal(SelectedRows[0].Cells["Balance"].Value);
                decimal amountPaid = Convert.ToDecimal(SelectedRows[0].Cells["AmountPaid"].Value);
                string paymentMethod = SelectedRows[0].Cells["PaymentMethod"].Value.ToString();

                string filePath = @"C:\\Users\\Julius Mendoza\\source\\repos\\ErvinAbiadSTI\\BT3102.Group7.App\\BetterCallRoomy\\Resources\\Transactions\\"
                                    + transactionID + ".txt"; 

                string directory = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Transaction ID: " + transactionID);
                    writer.WriteLine("Reservation ID: " + reservationID);
                    writer.WriteLine("Room Charge: " + roomCharge.ToString("C", new CultureInfo("fil-PH")));
                    writer.WriteLine("Balance: " + balance.ToString("C", new CultureInfo("fil-PH")));
                    writer.WriteLine("Amount Paid: " + amountPaid.ToString("C", new CultureInfo("fil-PH")));
                    writer.WriteLine("Payment Method: " + paymentMethod);
                }
                MessageBox.Show("Reservation details have been printed to a text file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while printing reservation: {ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
