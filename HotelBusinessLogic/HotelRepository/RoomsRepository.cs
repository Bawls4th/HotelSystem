using HotelModel.RoomModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Xml.Linq;

namespace HotelBusinessLogic.HotelRepository
{
    public class RoomsRepository
    {
        private string constrng = "Data Source=PANTSUS\\SQLEXPRESS;Initial Catalog=DBHotelReservation;Integrated Security=True;Persist Security Info=False;Pooling=False;";

        public RoomModel AddRooms(int roomNo, string roomType, string floor, string name, string capacity, decimal price, string status, bool isavail, string image)
        {
            RoomModel AR = null;

            try
            {
                string fileName = Path.GetFileName(image);
                string savePath = Path.Combine("Rooms Pictures", fileName);


                using (SqlConnection myConnection = new SqlConnection(constrng))
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.InsertRoom", myConnection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@RoomNo", roomNo));
                        cmd.Parameters.Add(new SqlParameter("@RoomType", roomType));
                        cmd.Parameters.Add(new SqlParameter("@Floor", floor));
                        cmd.Parameters.Add(new SqlParameter("@RoomName", name));
                        cmd.Parameters.Add(new SqlParameter("@Capacity", capacity));
                        cmd.Parameters.Add(new SqlParameter("@Price", price));
                        cmd.Parameters.Add(new SqlParameter("@Status", status));
                        cmd.Parameters.Add(new SqlParameter("@IsAvailable", isavail));

                        cmd.Parameters.Add(new SqlParameter("@RoomImage", fileName));

                        myConnection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                AR = new RoomModel
                                {
                                    RoomID = Convert.ToInt32(reader.GetValue(0)),
                                    RoomNo = Convert.ToInt32(reader.GetValue(1)),
                                    RoomType = reader.GetString(2),
                                    Floor = reader.GetString(3),
                                    RoomName = reader.GetString(4),
                                    RoomCapacity = reader.GetString(5),
                                    Price = Convert.ToDecimal(reader.GetValue(6)),
                                    Status = reader.GetString(7),
                                    IsAvailable = reader.GetBoolean(8),
                                    RoomPicture = reader.GetString(9)
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
            return AR;
        }

        public void UpdateRooms(int roomid, int roomNo, string roomType, string floor, string name, string capacity, decimal price, string status, bool isavail)
        {
            using (SqlConnection myConnection = new SqlConnection(constrng))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.UpdateRooms", myConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@RoomID", roomid));
                    cmd.Parameters.Add(new SqlParameter("@RoomNo", roomNo));
                    cmd.Parameters.Add(new SqlParameter("@RoomType", roomType));
                    cmd.Parameters.Add(new SqlParameter("@Floor", floor));
                    cmd.Parameters.Add(new SqlParameter("@RoomName", name));
                    cmd.Parameters.Add(new SqlParameter("@Capacity", capacity));
                    cmd.Parameters.Add(new SqlParameter("@Price", price));
                    cmd.Parameters.Add(new SqlParameter("@Status", status));
                    cmd.Parameters.Add(new SqlParameter("@IsAvailable", isavail));

                    myConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteRooms(int roomID,int roomNo)
        {
            using (SqlConnection myConnection = new SqlConnection(constrng))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.DeleteRoomByRoomNo", myConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@RoomNo", roomNo));
                    myConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<RoomModel> SearchRooms(string searchTerm, string searchType)
        {
            List<RoomModel> rooms = new List<RoomModel>();

            using (SqlConnection myConnection = new SqlConnection(constrng))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.SearchRooms", myConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@SearchTerm", searchTerm));
                    cmd.Parameters.Add(new SqlParameter("@SearchType", searchType));

                    myConnection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rooms.Add(new RoomModel
                            {
                                RoomID = Convert.ToInt32(reader.GetValue(0)),
                                RoomNo = Convert.ToInt32(reader.GetValue(1)),
                                RoomType = reader.GetString(2),
                                Floor = reader.GetString(3),
                                RoomName = reader.GetString(4),
                                RoomCapacity = reader.GetString(5),
                                Price = Convert.ToDecimal(reader.GetValue(6)),
                                Status = reader.GetString(7),
                                IsAvailable = reader.GetBoolean(8),
                                RoomPicture = reader.GetString(9)
                            });
                        }
                    }
                }
            }

            return rooms;
        }

        public List<RoomModel> GetAllRooms()
        {
            List<RoomModel> guests = new List<RoomModel>();


            using (SqlConnection myConnection = new SqlConnection(constrng))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.SelectRooms", myConnection))
                {
                    myConnection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            guests.Add(new RoomModel
                            {
                                RoomID = Convert.ToInt32(reader.GetValue(0)),
                                RoomNo = Convert.ToInt32(reader.GetValue(1)),
                                RoomType = reader.GetString(2),
                                Floor = reader.GetString(3),
                                RoomName = reader.GetString(4),
                                RoomCapacity = reader.GetString(5),
                                Price = Convert.ToDecimal(reader.GetValue(6)),
                                Status = reader.GetString(7),
                                IsAvailable = reader.GetBoolean(8),
                                RoomPicture = reader.GetString(9),
                            });
                        }
                    }
                }
            }
            return guests;
        }

        public bool DoesRoomsExist(int roomNo)
        {

            using (SqlConnection myConnection = new SqlConnection(constrng))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.CheckForRoomExist", myConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@RoomNo", roomNo));
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
                SqlCommand command = new SqlCommand("dbo.ReservedRoom", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@RoomID", roomId);

                connection.Open();

                int count = Convert.ToInt32(command.ExecuteScalar());
                hasActiveReservations = count > 0;
            }

            return hasActiveReservations;
        }

        public bool RoomReserved(int roomNo, string status, bool isavail)
        {
            using (SqlConnection myConnection = new SqlConnection(constrng))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.CheckForUsedRooms", myConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@RoomNo", roomNo));
                    cmd.Parameters.Add(new SqlParameter("@Status", status));
                    cmd.Parameters.Add(new SqlParameter("@IsAvailable", isavail));
                    myConnection.Open();

                    cmd.ExecuteNonQuery(); 
                    return true; 
                   
                }
            }
        }

    }
}
