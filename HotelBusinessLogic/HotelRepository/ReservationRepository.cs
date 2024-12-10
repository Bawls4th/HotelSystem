using HotelModel.ReservationModel;
using System.Data.SqlClient;
using System.Data;

namespace HotelBusinessLogic.HotelRepository
{
    public class ReservationRepository
    {
        private string constrng = "Data Source=PANTSUS\\SQLEXPRESS;Initial Catalog=DBHotelReservation;Integrated Security=True;Persist Security Info=False;Pooling=False;";

        public ReservationModel Reserve(int guestid, int roomid, int serviceid, DateTime checkin, DateTime checkout, DateTime issued)
        {
            ReservationModel RM = null;

            try
            {
                using (SqlConnection myConnection = new SqlConnection(constrng))
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.InsertReservation", myConnection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@GuestID", guestid));
                        cmd.Parameters.Add(new SqlParameter("@RoomID", roomid));
                        cmd.Parameters.Add(new SqlParameter("@ServiceID", serviceid));
                        cmd.Parameters.Add(new SqlParameter("@CheckIn", checkin));
                        cmd.Parameters.Add(new SqlParameter("@CheckOut", checkout));
                        cmd.Parameters.Add(new SqlParameter("@DateIssued", issued));

                        myConnection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                RM = new ReservationModel
                                {
                                    ReservationID = Convert.ToInt32(reader.GetValue(0)),
                                    GuestID = Convert.ToInt32(reader.GetValue("GuestID")),
                                    RoomID = Convert.ToInt32(reader.GetValue("RoomID")),
                                    ServiceID = Convert.ToInt32(reader.GetValue("ServiceID")),
                                    CheckIn = reader.GetDateTime(4),
                                    CheckOut = reader.GetDateTime(5),
                                    DateIssued = reader.GetDateTime(6)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception EX)
            {
                throw new Exception(EX.Message);
            }
            return RM;
        }

        public void UpdateReservation(int reservationdId, int guestid, int roomid, int serviceid, DateTime checkin, DateTime checkout, DateTime issued)
        {
            using (SqlConnection myConnection = new SqlConnection(constrng))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.UpdateReservation", myConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ReservationID", reservationdId));
                    cmd.Parameters.Add(new SqlParameter("@GuestID", guestid));
                    cmd.Parameters.Add(new SqlParameter("@RoomID", roomid));
                    cmd.Parameters.Add(new SqlParameter("@ServiceID", serviceid));
                    cmd.Parameters.Add(new SqlParameter("@CheckIn", checkin));
                    cmd.Parameters.Add(new SqlParameter("@CheckOut", checkout));
                    cmd.Parameters.Add(new SqlParameter("@DateIssued", issued));
                    myConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteReservation(int reservationdId)
        {
            using (SqlConnection myConnection = new SqlConnection(constrng))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.DeleteReservation", myConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ReservationID", reservationdId));
                    myConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<ReservationModel> ReservationInfo()
        {
            List<ReservationModel> reserves = new List<ReservationModel>();
            using (SqlConnection myConnection = new SqlConnection(constrng))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.SelectReservationInfo", myConnection))
                {
                    myConnection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            reserves.Add(new ReservationModel
                            {
                                ReservationID = Convert.ToInt32(reader["ReservationID"]),
                                GuestID = Convert.ToInt32(reader["GuestID"]),
                                RoomID = Convert.ToInt32(reader["RoomID"]),
                                ServiceID = Convert.ToInt32(reader["ServiceID"]),
                                Guest = reader["Guest"].ToString(),
                                RoomNo = Convert.ToInt32(reader["RoomNo"]),
                                Servicor = reader["Servicor"].ToString(),
                                TotalPrice = Convert.ToDecimal(reader["TotalPrice"]),
                                RoomPrice = Convert.ToDecimal(reader["RoomPrice"]),
                                ServicorPrice = Convert.ToDecimal(reader["ServicorPrice"]),
                                CheckIn = reader.GetDateTime(reader.GetOrdinal("CheckIn")),
                                CheckOut = reader.GetDateTime(reader.GetOrdinal("CheckOut")),
                                DateIssued = reader.GetDateTime(reader.GetOrdinal("DateIssued"))
                            });
                        }
                    }
                }
            }
            return reserves;
        }

        public List<ReservationModel> SearchReservants(string searchTerm, string searchType)
        {
            List<ReservationModel> reservants = new List<ReservationModel>();

            using (SqlConnection myConnection = new SqlConnection(constrng))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.SearchReservants", myConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@SearchTerm", searchTerm));
                    cmd.Parameters.Add(new SqlParameter("@SearchType", searchType));

                    myConnection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            reservants.Add(new ReservationModel
                            {
                                ReservationID = Convert.ToInt32(reader["ReservationID"]),
                                Guest = reader["Guest"].ToString(),
                                RoomNo = Convert.ToInt32(reader["RoomNo"]),
                                Servicor = reader["Servicor"].ToString(),
                                TotalPrice = Convert.ToDecimal(reader["TotalPrice"]),
                                CheckIn = reader.GetDateTime(reader.GetOrdinal("CheckIn")),
                                CheckOut = reader.GetDateTime(reader.GetOrdinal("CheckOut")),
                                DateIssued = reader.GetDateTime(reader.GetOrdinal("DateIssued"))
                            });
                        }
                    }
                }
            }

            return reservants;
        }

        public bool DoesServicorExist(int guestid, int roomid, int serviceid)
        {
            using (SqlConnection myConnection = new SqlConnection(constrng))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.CheckIFReservantsExist", myConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@GuestID", guestid));
                    cmd.Parameters.Add(new SqlParameter("@RoomID", roomid));
                    cmd.Parameters.Add(new SqlParameter("@ServiceID", serviceid));
                    myConnection.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }


    }
}

