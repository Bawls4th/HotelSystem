using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelModel.RoomModel;
using System.Transactions;
using HotelModel.TransactionModel;

namespace HotelBusinessLogic.HotelRepository
{
    public class TransactionRepository
    {
        private string constrng = "Data Source=PANTSUS\\SQLEXPRESS;Initial Catalog=DBHotelReservation;Integrated Security=True;Persist Security Info=False;Pooling=False;";

        public bool InsertTransaction(int reservationID, decimal roomcharge, decimal balance, decimal amountPaid, string paymentMethod, out int transactionID)
        {
            using (SqlConnection connection = new SqlConnection(constrng))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("dbo.TransactionProcess", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ReservationID", reservationID);
                        command.Parameters.AddWithValue("@RoomCharge", roomcharge);
                        command.Parameters.AddWithValue("@Balance", balance);
                        command.Parameters.AddWithValue("@AmountPaid", amountPaid);
                        command.Parameters.AddWithValue("@PaymentMethod", paymentMethod);

                        SqlParameter outputTransactionID = new SqlParameter("@TransactionID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputTransactionID);

                        int rowsAffected = command.ExecuteNonQuery();

                        transactionID = (int)outputTransactionID.Value;

                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    transactionID = 0;
                    return false;
                }
            }
        }

        public List<TransactionModel> GetTransactions()
        {
            List<TransactionModel> transac = new List<TransactionModel>();
            using (SqlConnection myConnection = new SqlConnection(constrng))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.SelectTransactions", myConnection))
                {
                    myConnection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            transac.Add(new TransactionModel
                            {
                                TransactionID = reader.GetInt32(reader.GetOrdinal("TransactionID")),
                                ReservationID = reader.GetInt32(reader.GetOrdinal("ReservationID")),
                                RoomCharge = reader.GetDecimal(reader.GetOrdinal("RoomCharge")),
                                Balance = reader.GetDecimal(reader.GetOrdinal("Balance")),
                                AmountPaid = reader.GetDecimal(reader.GetOrdinal("AmountPaid")),
                                PaymentMethod = reader.GetString(reader.GetOrdinal("PaymentMethod"))

                            });
                        }
                    }
                }
            }
            return transac;
        }

    }
}