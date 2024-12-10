using HotelModel.GuestModel;
using System.Data.SqlClient;
using System.Data;

namespace HotelBusinessLogic.HotelRepository
{
    public class GuestRepository
    {
        private string constrng = "Data Source=PANTSUS\\SQLEXPRESS;Initial Catalog=DBHotelReservation;Integrated Security=True;Persist Security Info=False;Pooling=False;";

        public GuestModel getGuestModel(string FN, string MM, string LN, DateTime birth, int age, string gender, string ethnicity, string email, string contactno, DateTime registertime)
        {
            GuestModel Gmod = null;

            try
            {
                using (SqlConnection myConnection = new SqlConnection(constrng))
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.InsertGuest", myConnection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@FirstName", FN));
                        cmd.Parameters.Add(new SqlParameter("@MiddleName", MM));
                        cmd.Parameters.Add(new SqlParameter("@LastName", LN));
                        cmd.Parameters.Add(new SqlParameter("@BirthDate", birth));
                        cmd.Parameters.Add(new SqlParameter("@Age", age));
                        cmd.Parameters.Add(new SqlParameter("@Gender", gender));
                        cmd.Parameters.Add(new SqlParameter("@Ethnicity", ethnicity));
                        cmd.Parameters.Add(new SqlParameter("@EmailAddress", email));
                        cmd.Parameters.Add(new SqlParameter("@ContactNo", contactno));
                        cmd.Parameters.Add(new SqlParameter("@TimeRegistered", registertime));

                        myConnection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Gmod = new GuestModel
                                {
                                    GuestID = Convert.ToInt32(reader.GetValue(0)),
                                    GFirstName = reader.GetString(1),
                                    GMiddleName = reader.GetString(2),
                                    GLastName = reader.GetString(3),
                                    BirthDate = reader.GetDateTime(4),
                                    Age = Convert.ToInt32(reader.GetValue(5)),
                                    Gender = reader.GetString(6),
                                    Ethnicity = reader.GetString(7),
                                    GEmailAddress = reader.GetString(8),
                                    GContactNo = reader.GetString(9),
                                    Registered = reader.GetDateTime(10)
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
            return Gmod;
        }

        public bool DoesGuestExist(string firstN, string midN, string lastN, string email, string contactNo)
        {

            using (SqlConnection myConnection = new SqlConnection(constrng))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.CheckIFGuestExist", myConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FirstName", firstN));
                    cmd.Parameters.Add(new SqlParameter("@MiddleName", midN));
                    cmd.Parameters.Add(new SqlParameter("@LastName", lastN));
                    cmd.Parameters.Add(new SqlParameter("@EmailAddress", email));
                    cmd.Parameters.Add(new SqlParameter("@ContactNo", contactNo));

                    myConnection.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }

        }

        public List<GuestModel> GetAllGuests()
        {
            List<GuestModel> guests = new List<GuestModel>();


            using (SqlConnection myConnection = new SqlConnection(constrng))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.SelectBookedGuest", myConnection))
                {
                    myConnection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            guests.Add(new GuestModel
                            {
                                GuestID = reader.GetInt32(0),
                                GFirstName = reader.GetString(1),
                                GMiddleName = reader.GetString(2),
                                GLastName = reader.GetString(3),
                                BirthDate = reader.GetDateTime(4),
                                Age = reader.GetInt32(5),
                                Gender = reader.GetString(6),
                                Ethnicity = reader.GetString(7),
                                GEmailAddress = reader.GetString(8),
                                GContactNo = reader.GetString(9),
                                Registered = reader.GetDateTime(10)
                            });
                        }
                    }
                }
            }
            return guests;
        }

        public List<GuestModel> SearchGuests(string searchTerm, string searchType)
        {
            List<GuestModel> guests = new List<GuestModel>();

                using (SqlConnection myConnection = new SqlConnection(constrng))
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.SearchGuests", myConnection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@SearchTerm", searchTerm));
                        cmd.Parameters.Add(new SqlParameter("@SearchType", searchType));

                        myConnection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                guests.Add(new GuestModel
                                {
                                    GuestID = Convert.ToInt32(reader.GetValue(0)),
                                    GFirstName = reader.GetString(1),
                                    GMiddleName = reader.GetString(2),
                                    GLastName = reader.GetString(3),
                                    BirthDate = reader.GetDateTime(4),
                                    Age = Convert.ToInt32(reader.GetValue(5)),
                                    Gender = reader.GetString(6),
                                    Ethnicity = reader.GetString(7),
                                    GEmailAddress = reader.GetString(8),
                                    GContactNo = reader.GetString(9),
                                    Registered = reader.GetDateTime(10)
                                });
                            }
                        }
                    }
                }

            return guests;
        }
        public void UpdateGuest(int guestId, string FN, string MM, string LN, DateTime birth, int age, string gender, string ethnicity, string email, string contactno, DateTime registeredtime)
        {
            using (SqlConnection myConnection = new SqlConnection(constrng))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.UpdateGuest", myConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID", guestId));
                    cmd.Parameters.Add(new SqlParameter("@FirstName", FN));
                    cmd.Parameters.Add(new SqlParameter("@MiddleName", MM));
                    cmd.Parameters.Add(new SqlParameter("@LastName", LN));
                    cmd.Parameters.Add(new SqlParameter("@BirthDate", birth));
                    cmd.Parameters.Add(new SqlParameter("@Age", age));
                    cmd.Parameters.Add(new SqlParameter("@Gender", gender));
                    cmd.Parameters.Add(new SqlParameter("@Ethnicity", ethnicity));
                    cmd.Parameters.Add(new SqlParameter("@EmailAddress", email));
                    cmd.Parameters.Add(new SqlParameter("@ContactNo", contactno));
                    cmd.Parameters.Add(new SqlParameter("@TimeRegistered", registeredtime));

                    myConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public void DeleteGuest(int guestId)
        {
            using (SqlConnection myConnection = new SqlConnection(constrng))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.DeleteGuest", myConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID", guestId));
                    myConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool ActiveReservations(int guestId)
        {
            bool hasActiveReservations = false;

            using (SqlConnection connection = new SqlConnection(constrng))
            {
                SqlCommand command = new SqlCommand("dbo.ReservedGuest", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@GuestID", guestId);

                connection.Open();

                int count = Convert.ToInt32(command.ExecuteScalar());
                hasActiveReservations = count > 0;
            }

            return hasActiveReservations;
        }

    }
}
