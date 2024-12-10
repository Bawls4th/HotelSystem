using HotelModel.ReceptionistModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBusinessLogic.HotelRepository
{
    public class ReceptionistRepository
    {
        private string constrng = "Data Source=PANTSUS\\SQLEXPRESS;Initial Catalog=DBHotelReservation;Integrated Security=True;Persist Security Info=False;Pooling=False;";

        public ReceptionistModel getRepModel(string userN, string passW)
        {
            ReceptionistModel RepModel = null;

            try
            {
                using (SqlConnection myConnection = new SqlConnection(constrng))
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.ReceptionistLogin", myConnection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@UserName", userN));
                        cmd.Parameters.Add(new SqlParameter("@Password", passW));

                        myConnection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                RepModel = new ReceptionistModel
                                {
                                    RPID = reader.GetInt32(0),
                                    RPFirstName = reader.GetString(1),
                                    RPLastName = reader.GetString(2),
                                    RPEmailAddress = reader.GetString(3),
                                    RPContactNo = reader.GetString(4),
                                    RPUserName = reader.GetString(5),
                                    RPPassword = reader.GetString(6)
                                };
                            }
                            else
                            {
                                throw new ArgumentException("Invalid username or password...");
                            }
                            myConnection.Close();
                        }
                    }
                }

            }
            catch (ArgumentException AE)
            {
                throw new ArgumentException(AE.Message);
            }
            return RepModel;
        }

        public ReceptionistModel GetReceptionistModel(string firstname, string lastname, string email, string contactno, string username, string password)
        {
            ReceptionistModel RepModel = null;

            try
            {
                using (SqlConnection myConnection = new SqlConnection(constrng))
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.InsertReceptionist", myConnection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@FirstName", firstname));
                        cmd.Parameters.Add(new SqlParameter("@LastName", lastname));
                        cmd.Parameters.Add(new SqlParameter("@EmailAddress", email));
                        cmd.Parameters.Add(new SqlParameter("@ContactNo", contactno));
                        cmd.Parameters.Add(new SqlParameter("@UserName", username));
                        cmd.Parameters.Add(new SqlParameter("@Password", password));

                        myConnection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                RepModel = new ReceptionistModel
                                {
                                    RPID = Convert.ToInt32(reader.GetValue(0)),
                                    RPFirstName = reader.GetString(1),
                                    RPLastName = reader.GetString(2),
                                    RPEmailAddress = reader.GetString(3),
                                    RPContactNo = reader.GetString(4),
                                    RPUserName = reader.GetString(5),
                                    RPPassword = reader.GetString(6)
                                };
                            }
                            else
                            {
                                throw new ArgumentException("Invalid Inputs");
                            }
                            myConnection.Close();
                        }
                    }
                }
            }
            catch (ArgumentException AE)
            {
                throw new ArgumentException(AE.Message);
            }
            return RepModel;
        }

        public void UpdateReceptionist(int id, string firstname, string lastname, string email, string contactno, string username, string password)
        {
            using (SqlConnection myConnection = new SqlConnection(constrng))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.UpdateReceptionist", myConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID", id));
                    cmd.Parameters.Add(new SqlParameter("@FirstName", firstname));
                    cmd.Parameters.Add(new SqlParameter("@LastName", lastname));
                    cmd.Parameters.Add(new SqlParameter("@EmailAddress", email));
                    cmd.Parameters.Add(new SqlParameter("@ContactNo", contactno));
                    cmd.Parameters.Add(new SqlParameter("@UserName", username));
                    cmd.Parameters.Add(new SqlParameter("@Password", username));

                    myConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteReceptionist(int id)
        {
            using (SqlConnection myConnection = new SqlConnection(constrng))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.DeleteReceptionist", myConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID", id));
                    myConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<ReceptionistModel> SearchReceptionist(string searchTerm, string searchType)
        {
            List<ReceptionistModel> receptionist = new List<ReceptionistModel>();

            using (SqlConnection myConnection = new SqlConnection(constrng))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.SearchReceptionist", myConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@SearchTerm", searchTerm));
                    cmd.Parameters.Add(new SqlParameter("@SearchType", searchType));

                    myConnection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            receptionist.Add(new ReceptionistModel
                            {
                                RPID = Convert.ToInt32(reader.GetValue(0)),
                                RPFirstName = reader.GetString(1),
                                RPLastName = reader.GetString(2),
                                RPEmailAddress = reader.GetString(3),
                                RPContactNo = reader.GetString(4),
                                RPUserName = reader.GetString(5),
                                RPPassword = reader.GetString(6)
                            });
                        }
                    }
                }  
            }
            return receptionist;
        }

        public List<ReceptionistModel> GetAllReceptionist()
        {
            List<ReceptionistModel> receptionists = new List<ReceptionistModel>();

            using (SqlConnection myConnection = new SqlConnection(constrng))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.SelectReceptionist", myConnection))
                {
                    myConnection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            receptionists.Add(new ReceptionistModel
                            {
                                RPID = Convert.ToInt32(reader.GetValue(0)),
                                RPFirstName = reader.GetString(1),
                                RPLastName = reader.GetString(2),
                                RPEmailAddress = reader.GetString(3),
                                RPContactNo = reader.GetString(4),
                                RPUserName = reader.GetString(5),
                                RPPassword = reader.GetString(6)
                            });
                        }
                    }
                }
            }
            return receptionists;
        }
        public bool DoesReceptionistExist(string firstname, string lastname)
        {
            using (SqlConnection myConnection = new SqlConnection(constrng))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.CheckIFReceptionistExist", myConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FirstName", firstname));
                    cmd.Parameters.Add(new SqlParameter("@LastName", lastname));
                   

                    myConnection.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

    }
}
