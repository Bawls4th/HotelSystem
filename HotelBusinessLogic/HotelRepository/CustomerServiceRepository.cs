using System.Data.SqlClient;
using System.Data;
using HotelModel.CustomerServiceModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelBusinessLogic.HotelRepository
{
    public class CustomerServiceRepository
    {
        private string constrng = "Data Source=PANTSUS\\SQLEXPRESS;Initial Catalog=DBHotelReservation;Integrated Security=True;Persist Security Info=False;Pooling=False;";

        public ServicorModel AddServicor(string fn, string mdn, string ln, string gender, string desc, decimal price, bool isavail, DateTime ds)
        {
            ServicorModel AS = null;

            try
            {
                using (SqlConnection myConnection = new SqlConnection(constrng))
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.InsertServicor", myConnection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@FirstName", fn));
                        cmd.Parameters.Add(new SqlParameter("@MiddleName", mdn));
                        cmd.Parameters.Add(new SqlParameter("@LastName", ln));
                        cmd.Parameters.Add(new SqlParameter("@Gender", gender));
                        cmd.Parameters.Add(new SqlParameter("@Description", desc));
                        cmd.Parameters.Add(new SqlParameter("@Price", price));
                        cmd.Parameters.Add(new SqlParameter("@Available", isavail));
                        cmd.Parameters.Add(new SqlParameter("@DateService", ds));

                        myConnection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                AS = new ServicorModel
                                {
                                    ServiceID = Convert.ToInt32(reader.GetValue(0)),
                                    FirstName = reader.GetString(1),
                                    MiddleName = reader.GetString(2),
                                    LastName = reader.GetString(3),
                                    Gender = reader.GetString(4),
                                    Description = reader.GetString(5),
                                    Price = Convert.ToDecimal(reader.GetValue(6)),
                                    Available = reader.GetBoolean(7),
                                    DateService = reader.GetDateTime(8)
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
            return AS;
        }

        public void UpdateServicor(int servID, string fn, string mdn, string ln, string gender, string desc, decimal price, bool isavail, DateTime ds)
        {
            using (SqlConnection myConnection = new SqlConnection(constrng))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.UpdateServicor", myConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID", servID));
                    cmd.Parameters.Add(new SqlParameter("@FirstName", fn));
                    cmd.Parameters.Add(new SqlParameter("@MiddleName", mdn));
                    cmd.Parameters.Add(new SqlParameter("@LastName", ln));
                    cmd.Parameters.Add(new SqlParameter("@Gender", gender));
                    cmd.Parameters.Add(new SqlParameter("@Description", desc));
                    cmd.Parameters.Add(new SqlParameter("@Price", price));
                    cmd.Parameters.Add(new SqlParameter("@Available", isavail));
                    cmd.Parameters.Add(new SqlParameter("@DateService", ds));

                    myConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteServicor(int servID)
        {
            using (SqlConnection myConnection = new SqlConnection(constrng))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.DeleteServicor", myConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID", servID));
                    myConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<ServicorModel> SearchRooms(string searchTerm, string searchType)
        {
            List<ServicorModel> service = new List<ServicorModel>();

            using (SqlConnection myConnection = new SqlConnection(constrng))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.SearchServicor", myConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@SearchTerm", searchTerm));
                    cmd.Parameters.Add(new SqlParameter("@SearchType", searchType));

                    myConnection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            service.Add(new ServicorModel
                            {
                                ServiceID = Convert.ToInt32(reader.GetValue(0)),
                                FirstName = reader.GetString(1),
                                MiddleName = reader.GetString(2),
                                LastName = reader.GetString(3),
                                Gender = reader.GetString(4),
                                Description = reader.GetString(5),
                                Price = Convert.ToDecimal(reader.GetValue(6)),
                                Available = reader.GetBoolean(7),
                                DateService = reader.GetDateTime(8)
                            });
                        }
                    }
                }
            }

            return service;
        }

        public List<ServicorModel> GetAllService()
        {
            List<ServicorModel> guests = new List<ServicorModel>();
            using (SqlConnection myConnection = new SqlConnection(constrng))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.SelectServicors", myConnection))
                {
                    myConnection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            guests.Add(new ServicorModel
                            {

                                ServiceID = Convert.ToInt32(reader.GetValue(0)),
                                FirstName = reader.GetString(1),
                                MiddleName = reader.GetString(2),
                                LastName = reader.GetString(3),
                                Gender = reader.GetString(4),
                                Description = reader.GetString(5),
                                Price = Convert.ToDecimal(reader.GetValue(6)),
                                Available = reader.GetBoolean(7),
                                DateService = reader.GetDateTime(8)
                            });
                        }
                    }
                }
            }
            return guests;
        }

        public bool DoesServicorExist(string fn, string mdn, string ln, string gender, string desc)
        {
            using (SqlConnection myConnection = new SqlConnection(constrng))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.CheckIFServicorExist", myConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FirstName", fn));
                    cmd.Parameters.Add(new SqlParameter("@MiddleName", mdn));
                    cmd.Parameters.Add(new SqlParameter("@LastName", ln));
                    cmd.Parameters.Add(new SqlParameter("@Gender", gender));
                    cmd.Parameters.Add(new SqlParameter("@Description", desc));
                    myConnection.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public bool ActiveReservations(int roomId)
        {
            bool hasActiveReservations = false;

            using (SqlConnection connection = new SqlConnection(constrng))
            {
                SqlCommand command = new SqlCommand("dbo.ReservedServicor", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ServiceID", roomId);

                connection.Open();

                int count = Convert.ToInt32(command.ExecuteScalar());
                hasActiveReservations = count > 0;
            }

            return hasActiveReservations;
        }

        public bool ServicorAvailability(string fn, string mdn, string ln, bool isavail)
        {
            using (SqlConnection myConnection = new SqlConnection(constrng))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.CheckForServicorAvailability", myConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FirstName", fn));
                    cmd.Parameters.Add(new SqlParameter("@MiddleName", mdn));
                    cmd.Parameters.Add(new SqlParameter("@LastName", ln));
                    cmd.Parameters.Add(new SqlParameter("@Available", isavail));
                    myConnection.Open();

                    cmd.ExecuteNonQuery();
                    return true;

                }
            }
        }
    }
}
