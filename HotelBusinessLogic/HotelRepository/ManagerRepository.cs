using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using HotelModel.ManagerModel;

namespace HotelBusinessLogic.HotelRepository
{
    public class ManagerRepository
    {
        private string constrng = "Data Source=PANTSUS\\SQLEXPRESS;Initial Catalog=DBHotelReservation;Integrated Security=True;Persist Security Info=False;Pooling=False;";
        public ManagerModel getManModel(string userN, string passW)
        {

            ManagerModel ManModel = null;

            try
            {
                using (SqlConnection myConnection = new SqlConnection(constrng))
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.ManagerLogin", myConnection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@UserName", userN));
                        cmd.Parameters.Add(new SqlParameter("@Password", passW));

                        myConnection.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ManModel = new ManagerModel
                                {
                                    MGID = reader.GetInt32(0),
                                    MGFirstName = reader.GetString(1),
                                    MGLastName = reader.GetString(2),
                                    MGEmailAddress = reader.GetString(3),
                                    MGContactNo = reader.GetString(4),
                                    MGUserName = reader.GetString(5),
                                    MGPassword = reader.GetString(6)
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
            return ManModel;
        }

    }
}
